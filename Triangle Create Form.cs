using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Triangle_Create_Form : Form
    {
        private readonly Form1 parent;
        public Triangle_Create_Form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(new Point(Convert.ToInt32(x1_Value.Value),Convert.ToInt32(y1_Value.Value)),
                                             new Point(Convert.ToInt32(x2_Value.Value), Convert.ToInt32(y2_Value.Value)),
                                             new Point(Convert.ToInt32(x3_Value.Value), Convert.ToInt32(y3_Value.Value)));

            triangle.Name = "Triangle";
            triangle.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                triangle.Color2 = colorDialog1.Color;
                triangle._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(triangle);
            Hide();
            parent.Show();
            Close();
        }

        private void Triangle_Create_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
