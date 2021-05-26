using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Square:Rectangle
    {
        public double Side { get; set; }
        public Square(int x,int y,double width) : base(x, y, width, width) 
        {
            Name = "Square";
            Side = width;
        }
        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black, 2))
                graphics.DrawRectangle(pen, Location.X, Location.Y, (float)Side, (float)Side);
            using (var brush = new SolidBrush(Color2))
                graphics.FillRectangle(brush, Location.X, Location.Y, (float)Side, (float)Side);
        }
        public override float GetCalculateArea()
        {
            return (float)(Math.Pow(Side, 2));
        }
        public override void CalculateArea() => MessageBox.Show("Area of " + Name + " : " + GetCalculateArea().ToString());
        public override void CalculateContourLength() => MessageBox.Show("Contour length of " + Name + " : " + (4 * Side).ToString());
        public override bool Containsss(PointF point) =>
            Location.X < point.X && Location.X + Side > point.X &&
            Location.Y < point.Y && Location.Y + Side > point.Y;
    }
}
