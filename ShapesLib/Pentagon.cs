using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Pentagon : Polygon
    { 
        private PointF Point4 { get; set; }
        private PointF Point5 { get; set; }
        private double Side4 { get; set; }
        private double Side5 { get; set; }
        public PointF[] points { get; set; }
        public Pentagon(PointF point1, PointF point2, PointF point3, PointF point4, PointF point5) : base(new PointF[] { point1, point2, point3, point4, point5 })
        {
            Name = "Pentagon";
            Point1 = point1;
            Point2 = point5;
            Point3 = point4;
            Point4 = point3;
            Point5 = point2;

            Location = Point1;

            points = new PointF[5];
            points[0] = Point1;
            points[1] = Point2;
            points[2] = Point3;
            points[3] = Point4;
            points[4] = Point5;

            Side1 = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
            Side2 = Math.Sqrt(Math.Pow((point3.X - point2.X), 2) + Math.Pow((point3.Y - point2.Y), 2));
            Side3 = Math.Sqrt(Math.Pow((point4.X - point3.X), 2) + Math.Pow((point4.Y - point3.Y), 2));
            Side4 = Math.Sqrt(Math.Pow((point5.X - point4.X), 2) + Math.Pow((point5.Y - point4.Y), 2));
            Side5 = Math.Sqrt(Math.Pow((point1.X - point5.X), 2) + Math.Pow((point1.Y - point5.Y), 2));
        }
        public Pentagon() { }
        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black, 2))
                graphics.DrawPolygon(pen, points);
            using (Brush brush = new SolidBrush(Color2))
                graphics.FillPolygon(brush, points);
        }

        public override bool Containsss(PointF point)
        {
            bool result = false;
            int j = 4;
            for (int i = 0; i < 5; i++)
            {
                if (points[i].Y < point.Y && points[j].Y >= point.Y || points[j].Y < point.Y && points[i].Y >= point.Y)
                    if (points[i].X + (point.Y - points[i].Y) / (points[j].Y - points[i].Y) * (points[j].X - points[i].X) < point.X)
                        result = !result;
                j = i;
            }
            return result;
        }
        public PointF FindCentroid()
        {
            int num_points = points.Length;
            PointF[] pts = new PointF[num_points + 1];
            points.CopyTo(pts, 0);
            pts[num_points] = points[0];

            float X = 0;
            float Y = 0;
            float second_factor;
            for (int i = 0; i < num_points; i++)
            {
                second_factor = pts[i].X * pts[i + 1].Y - pts[i + 1].X * pts[i].Y;
                X += (pts[i].X + pts[i + 1].X) * second_factor;
                Y += (pts[i].Y + pts[i + 1].Y) * second_factor;
            }
            float polygon_area = GetCalculateArea();
            X /= (6 * polygon_area);
            Y /= (6 * polygon_area);
            return new PointF(X, Y);
        }
        public override PointF Centre
        {
            get => FindCentroid();
        }
        public override float GetCalculateArea()
        {
            float sum1 = 0;
            float sum2 = 0;
            float result;
            float[] a = new float[6]
            {
                Point1.X,
                Point2.X,
                Point3.X,
                Point4.X,
                Point5.X,
                Point1.X
            };
            float[] b = new float[6]
            {
                Point1.Y,
                Point2.Y,
                Point3.Y,
                Point4.Y,
                Point5.Y,
                Point1.Y
            };
            for (int i = 0; i < a.Length - 1; i++)
                sum1 += a[i] * b[i + 1];
            for (int j = 0; j < b.Length - 1; j++)
                sum2 += b[j] * a[j + 1];
            result = (sum2 - sum1) / 2;
            return Math.Abs(result);
        }
        public override void CalculateArea()
        {
            float result = GetCalculateArea();
            MessageBox.Show("Area of " + Name + " : " + Math.Abs(result).ToString());
        }
        public override void CalculateContourLength() => MessageBox.Show("Contour length of " + Name + " : " + (Side1 + Side2 + Side3 + Side4 + Side5).ToString());
    }
}

