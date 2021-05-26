using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Triangle:Polygon
    {
        readonly double SemiPerimeter;
        public PointF[] points { get; set; }
        public Triangle(PointF point1, PointF point2, PointF point3) : base(new PointF[] { point1, point2, point3 }) 
        {
            Name = "Triangle";
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;

            points = new PointF[3];
            points[0] = Point1;
            points[1] = Point2;
            points[2] = Point3;


            Side1 = Math.Sqrt(Math.Pow((point2.X - point1.X), 2)+ Math.Pow((point2.Y - point1.Y), 2));
            Side2 = Math.Sqrt(Math.Pow((point3.X - point2.X), 2) + Math.Pow((point3.Y - point2.Y), 2));
            Side3 = Math.Sqrt(Math.Pow((point1.X - point3.X), 2) + Math.Pow((point1.Y - point3.Y), 2));
            SemiPerimeter = (Side1 + Side2 + Side3) / 2;
        }
        public Triangle() { }
        public override PointF Centre
        {
            get => new PointF((points[0].X + points[1].X + points[2].X) / 3, (points[0].Y+points[1].Y+points[2].Y)/3);
        }

        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black, 2))
                graphics.DrawPolygon(pen, points);
            using (Brush brush = new SolidBrush(Color2))
                graphics.FillPolygon(brush, points);
        }
        public override bool Containsss(PointF point)=>
                (((point.X - points[0].X) * (points[1].Y - points[0].Y) - (point.Y - points[0].Y) * (points[1].X - points[0].X)) * ((points[2].X - points[0].X) * (points[1].Y - points[0].Y) - (points[2].Y - points[0].Y) * (points[1].X - points[0].X)) >= 0) &&
                (((point.X - points[1].X) * (points[2].Y - points[1].Y) - (point.Y - points[1].Y) * (points[2].X - points[1].X)) * ((points[0].X - points[1].X) * (points[2].Y - points[1].Y) - (points[0].Y - points[1].Y) * (points[2].X - points[1].X)) >= 0) &&
                (((point.X - points[2].X) * (points[0].Y - points[2].Y) - (point.Y - points[2].Y) * (points[0].X - points[2].X)) * ((points[1].X - points[2].X) * (points[0].Y - points[2].Y) - (points[1].Y - points[2].Y) * (points[0].X - points[2].X)) >= 0);
        public override float GetCalculateArea()
        {
            return (float)Math.Abs((Math.Sqrt(SemiPerimeter * (SemiPerimeter - Side1) * (SemiPerimeter - Side2) * (SemiPerimeter - Side3))));
        }
        public override void CalculateArea() => MessageBox.Show("Area of " + Name + " : " + GetCalculateArea().ToString());
        public override void CalculateContourLength() => MessageBox.Show("Contour length of " + Name + " : " + (Side1 + Side2 + Side3).ToString());
    }
}
