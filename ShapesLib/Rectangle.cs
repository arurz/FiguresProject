using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    [Serializable]
    public class Rectangle:Shape
    {
        public Rectangle(int x,int y,double width,double heigth) : base(x, y, width, heigth) 
        {
            Name = "Rectangle";
        }
        public override float GetCalculateArea()
        {
            return (float)(Width * Height);
        }
    }
}
