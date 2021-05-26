using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Polygon:Shape
    {
        protected double Side1 { get; set; }
        protected double Side2 { get; set; }
        protected double Side3 { get; set; }
        public Polygon(PointF[] points) : base(points) { }
        public Polygon() { }
    }
}
