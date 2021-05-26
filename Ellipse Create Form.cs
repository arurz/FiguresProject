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
    public partial class Ellipse_Create_Form : Form
    {
        private readonly Form1 parent;
        public Ellipse_Create_Form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse(Convert.ToInt32(x_Value.Value),
                                        Convert.ToInt32(y_Value.Value),
                                        Convert.ToDouble(Width.Value),
                                        Convert.ToDouble(Heigth.Value));

            ellipse.Name = "Ellipse";
            ellipse.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                ellipse.Color2 = colorDialog1.Color;
                ellipse._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(ellipse);
            Hide();
            parent.Show();
            Close();
        }

        private void Ellipse_Create_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
