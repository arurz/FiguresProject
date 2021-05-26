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
    public partial class Square_Create_Form : Form
    {
        private readonly Form1 parent;
        public Square_Create_Form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square square = new Square(Convert.ToInt32(x_Value.Value),
                                        Convert.ToInt32(y_Value.Value),
                                        Convert.ToDouble(Width.Value));

            square.Name = "Square";
            square.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                square.Color2 = colorDialog1.Color;
                square._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(square);
            Hide();
            parent.Show();
            Close();
        }

        private void Square_Create_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
