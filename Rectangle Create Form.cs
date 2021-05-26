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
    public partial class Rectangle_create_form : Form
    {
        private readonly Form1 parent;
        public Rectangle_create_form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToInt32(x_Value.Value),
                                        Convert.ToInt32(y_Value.Value),
                                        Convert.ToDouble(Width.Value),
                                        Convert.ToDouble(Heigth.Value));
            rectangle.Name = "Rectangle";
            rectangle.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                rectangle.Color2 = colorDialog1.Color;
                rectangle._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(rectangle);
            parent.Show();
            Hide();
            Close();
        }

        private void Rectangle_create_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
