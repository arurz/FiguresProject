using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Ellipse:Shape
    {
        public Ellipse(int x,int y,double width,double height) : base(x, y, width, height) 
        {
            Name = "Ellipse";
        }
        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black, 2))
                graphics.DrawEllipse(pen, Location.X, Location.Y, (float)Width, (float)Height);
            using (var brush = new SolidBrush(Color2))
                graphics.FillEllipse(brush, Location.X, Location.Y, (float)Width, (float)Height);
        }
        public override bool Containsss(PointF point)
        {
            point.X -= Centre.X;
            point.Y -= Centre.Y;
            return (Math.Pow(point.X,2) / Math.Pow(Width / 2,2) + Math.Pow(point.Y, 2) / Math.Pow(Height / 2, 2) <= 1);
        }
        public override float GetCalculateArea()
        {
            return (float)(Math.PI * (Width / 2) * (Height / 2));
        }
        public override void CalculateArea() => MessageBox.Show("Area of " + Name + " : " + GetCalculateArea().ToString());
        public override void CalculateContourLength() => MessageBox.Show("Contour length of " + Name + " : " + (2 * Math.PI * Math.Sqrt((Math.Pow(Width, 2) + Math.Pow(Height, 2)) / 8)).ToString());
    }
}
