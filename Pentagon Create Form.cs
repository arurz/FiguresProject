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
    public partial class Pentagon_Create_Form : Form
    {
        private readonly Form1 parent;
        public Pentagon_Create_Form(Form1 scene)
        {
            InitializeComponent();
            parent = scene;
            colorDialog1.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pentagon pentagon= new Pentagon(new Point(Convert.ToInt32(x1_Value.Value), Convert.ToInt32(y1_Value.Value)),
                                             new Point(Convert.ToInt32(x2_Value.Value), Convert.ToInt32(y2_Value.Value)),
                                             new Point(Convert.ToInt32(x3_Value.Value), Convert.ToInt32(y3_Value.Value)),
                                             new Point(Convert.ToInt32(x4_Value.Value), Convert.ToInt32(y4_Value.Value)),
                                             new Point(Convert.ToInt32(x5_Value.Value), Convert.ToInt32(y5_Value.Value)));
            pentagon.Name = "Triangle";
            pentagon.Order = parent._shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                pentagon.Color2 = colorDialog1.Color;
                pentagon._originalColor = colorDialog1.Color;
            }
            parent._shapes.Add(pentagon);
            Hide();
            parent.Show();
            Close();
        }

        private void Pentagon_Create_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            parent.Show();
            Close();
        }
    }
}
