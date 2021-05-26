using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Shape
    {
        [NonSerialized]
        public Color color;
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Order { get; set; }
        public Color Color2
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Color _originalColor { get; set; }
        public PointF Location { get; set; }
        protected PointF[] Points { get; set; }
        protected  PointF Point1 { get; set; }
        protected PointF Point2 { get; set; }
        protected PointF Point3 { get; set; }

        public virtual PointF Centre
        {
            get => new PointF((float)(Width / 2 + Location.X), (float)(Height / 2 + Location.Y));
        }
        public Shape(int x,int y, double width,double height)
        {
            PointF point = new PointF(x, y);
            Location = point;
            Width = width;
            Height = height;
        }
        public Shape(PointF[] points)
        {
            Points = points;
        }
        public Shape() { }
        public virtual void Draw(Graphics graphics)
        {
            using(var pen = new Pen(Color.Black, 2))
                graphics.DrawRectangle(pen, Location.X, Location.Y, (float)Width, (float)Height);
            using(Brush brush = new SolidBrush(Color2))
                graphics.FillRectangle(brush, Location.X, Location.Y, (float)Width, (float)Height);
        }
        public virtual float GetCalculateArea() 
        { 
            return 0f; 
        }
        public virtual void CalculateArea() => MessageBox.Show("Area of " + Name + " : " + (Width*Height).ToString());
        public virtual void CalculateContourLength() => MessageBox.Show("Contour length of " + Name + " : " + ((Width + Height)*2).ToString());
        public virtual bool Containsss(PointF point) =>
                Location.X < point.X && Location.X + Width > point.X &&
                Location.Y < point.Y && Location.Y + Height > point.Y;
    }
}
