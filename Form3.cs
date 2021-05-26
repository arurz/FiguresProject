using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form = new Form1();
            Hide();
            Form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (!File.Exists("shapes"))
                return;
            var binformatter = new BinaryFormatter();
            using (var fileStream = new FileStream("shapes", FileMode.Open, FileAccess.Read))
            {
                if (fileStream.Length == 0)
                    return;
                else
                {
                    form1._shapes = (List<Shape>)binformatter.Deserialize(fileStream);
                    foreach (Shape shape in form1._shapes)
                        shape.Color2 = shape._originalColor;
                }
            }
            Hide();
            form1.ShowDialog();
            Close();
        }
    }
}
