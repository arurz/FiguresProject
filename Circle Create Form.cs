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
    public partial class Circle_Create_Form : Form
    {
        private readonly Form1 parent;

        public Circle_Create_Form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Convert.ToInt32(x_Value.Value),
                                        Convert.ToInt32(y_Value.Value),
                                        Convert.ToDouble(Diametre.Value));

            circle.Name = "Circle";
            circle.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                circle.Color2 = colorDialog1.Color;
                circle._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(circle);
            Hide();
            parent.Show();
            Close();
        }

        private void Circle_Create_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
