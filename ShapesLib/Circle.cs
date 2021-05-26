using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Circle : Ellipse
    {
        public double Diameter { get; set; }
        public Circle(int x, int y, double width) : base(x, y, width, width)
        {
            Name = "Circle";
            Diameter = width;
        }
        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black, 2))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, (float)Diameter, (float)Diameter);
            }
            using (Brush brush = new SolidBrush(Color2))
            {
                graphics.FillEllipse(brush, Location.X, Location.Y, (float)Diameter, (float)Diameter);
            }
        }
        public override bool Containsss(PointF point)
        {
            return  (point.X - (Location.X + Diameter/2)) * (point.X - (Location.X + Diameter / 2))
                + (point.Y - (Location.Y + Diameter/ 2)) * (point.Y - (Location.Y + Diameter / 2)) <= Diameter / 2 * Diameter / 2;
        }
        public override float GetCalculateArea()
        {
            return (float)(Math.PI * Math.Pow((Diameter / 2), 2));
        }
        public override void CalculateArea()
        {
            MessageBox.Show("Area of " + Name + " : " + GetCalculateArea().ToString());
        }
        public override void CalculateContourLength()
        {
            MessageBox.Show("Contour length of " + Name + " : " + (Math.PI * Diameter).ToString());
        }
    }
}
