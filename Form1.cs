using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form1 : Form
    {
        public List<Shape> _shapes = new List<Shape>();
        private Shape resultShape = null;
        private Shape _selectedShape = new Shape();

        private Pentagon selectedPentagon = new Pentagon();
        private Triangle selectedTriangle = new Triangle();
        private Color selectedColor = Color.FromArgb(red.Next(0,255), green.Next(0, 255), blue.Next(0, 255));

        private Point mouseStartPosition;

        private bool isMouseMove = false;
        private float deltaX = 0;
        private float deltaY = 0;
        private float angle = 150;

        static Random red = new Random();
        static Random green = new Random();
        static Random blue = new Random();
        public Form1()
        {
            InitializeComponent();
            panelDraw.Invalidate();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty |
                BindingFlags.Instance |
                BindingFlags.NonPublic,
                null,
                panelDraw,
                new object[] { true });
            this.MouseWheel += new MouseEventHandler(panelDraw_MouseWheel);
        }
        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
                foreach (var shape in _shapes)
                {
                    shape.Draw(e.Graphics);
                }
        }
        private void Area()
        {
            var sumArea = _shapes
                .Select(x => x.GetCalculateArea())
                .Sum();
            toolStripStatusLabel2.Text = "Area of all figures is: "+sumArea;
        }
       
        #region Mouse Events
        private Shape WhereContains(Point point)
        {
            foreach(var shape in _shapes)
            {
                if (shape.Containsss(point))
                    resultShape = shape;
            }
            return resultShape;
        }
        
        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Shape shape in _shapes)
                {
                    using (var graphics = panelDraw.CreateGraphics())
                    {
                        shape.Draw(graphics);
                    }
                }
                Area();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (_selectedShape != null)
                {
                    using (var graphics = panelDraw.CreateGraphics())
                    {
                        _selectedShape.Color2 = _selectedShape._originalColor;
                        _selectedShape.Draw(graphics);
                    }
                }
                _selectedShape = _shapes
                    .OrderByDescending(o => o.Order)
                    .Where(shape => shape.Containsss(e.Location))
                    .FirstOrDefault();
                if (_selectedShape != null)
                    using (var graphics = panelDraw.CreateGraphics())
                    {
                        selectedColor = Color.FromArgb(red.Next(0, 255), green.Next(0, 255), blue.Next(0, 255));
                        _selectedShape.Color2 = selectedColor;
                        _selectedShape.Draw(graphics);
                    }
                Area();
            }
            else if (e.Button == MouseButtons.Middle && _selectedShape.Containsss(e.Location) && _selectedShape!=null)
            {
                mouseStartPosition = e.Location;
                isMouseMove = true;
                if (_selectedShape is Pentagon)
                    selectedPentagon = (Pentagon)_selectedShape;
                else if (_selectedShape is Triangle)
                    selectedTriangle = (Triangle)_selectedShape;
                else
                {
                    deltaX = e.X - _selectedShape.Location.X;
                    deltaY = e.Y - _selectedShape.Location.Y;
                }
                Area();
            }
        }
       private void panelDraw_MouseWheel(object sender, MouseEventArgs e)
       {
            if (e.Delta > 0)
            {
                //Increase
                if (_selectedShape is Ellipse && _selectedShape.Containsss(e.Location))
                {
                    var selectedEllipcse = (Ellipse)_selectedShape;
                        selectedEllipcse.Width += 10;
                        selectedEllipcse.Height += 10;
                }
                if(_selectedShape is Square && _selectedShape.Containsss(e.Location))
                {
                    var selectedSquare = (Square)_selectedShape;
                        selectedSquare.Side += 10;
                }
                if (_selectedShape is Circle &&_selectedShape.Containsss(e.Location))
                {
                    var selectedCircle = (Circle)_selectedShape;
                        selectedCircle.Diameter += 10;
                }
                if (_selectedShape is Rectangle && _selectedShape.Containsss(e.Location))
                {
                    var selectedRectangle = (Rectangle)_selectedShape;
                        selectedRectangle.Width += 10;
                        selectedRectangle.Height += 10;
                }
                //Rotation
                if(_selectedShape is Pentagon && _selectedShape.Containsss(e.Location))
                {
                    PointF[] newPoints = new PointF[5];
                    selectedPentagon = (Pentagon)_selectedShape;
                    for(int i = 0; i < selectedPentagon.points.Length; i++)
                    {
                        float x = (float)(((selectedPentagon.points[i].X - selectedPentagon.Centre.X) * Math.Cos(angle) - ((selectedPentagon.points[i].Y - selectedPentagon.Centre.Y) * Math.Sin(angle)) + selectedPentagon.Centre.X));
                        float y = (float)(((selectedPentagon.points[i].X - selectedPentagon.Centre.X) * Math.Sin(angle) + ((selectedPentagon.points[i].Y - selectedPentagon.Centre.Y) * Math.Cos(angle)) + selectedPentagon.Centre.Y));
                        newPoints[i] = new PointF(x, y);
                    }
                    selectedPentagon.points = newPoints;
                }
                if (_selectedShape is Triangle && _selectedShape.Containsss(e.Location))
                {
                    PointF[] newPoints = new PointF[3];
                    selectedTriangle = (Triangle)_selectedShape;
                    for (int i = 0; i < selectedTriangle.points.Length; i++)
                    {
                        float x = (float)(((selectedTriangle.points[i].X - selectedTriangle.Centre.X) * Math.Cos(angle) - ((selectedTriangle.points[i].Y - selectedTriangle.Centre.Y) * Math.Sin(angle)) + selectedTriangle.Centre.X));
                        float y = (float)(((selectedTriangle.points[i].X - selectedTriangle.Centre.X) * Math.Sin(angle) + ((selectedTriangle.points[i].Y - selectedTriangle.Centre.Y) * Math.Cos(angle)) + selectedTriangle.Centre.Y));
                        newPoints[i] = new PointF(x, y);
                    }
                    selectedTriangle.points = newPoints;
                }
               
                Area();
            }
            else
            {
                //Decrease
                if (_selectedShape is Rectangle && _selectedShape.Containsss(e.Location))
                {
                    var selectedRectangle = (Rectangle)_selectedShape;
                    if (selectedRectangle.Width > 20 || selectedRectangle.Height > 20)
                    {
                        selectedRectangle.Width -= 10;
                        selectedRectangle.Height -= 10;
                    }
                }
                if (_selectedShape is Square && _selectedShape.Containsss(e.Location))
                {
                    var selectedSquare = (Square)_selectedShape;
                    if(selectedSquare.Side > 20)
                        selectedSquare.Side -= 10;
                }
                if (_selectedShape is Ellipse && _selectedShape.Containsss(e.Location))
                {
                    var selectedEllipse = (Ellipse)_selectedShape;
                        if (selectedEllipse.Width > 80 || selectedEllipse.Height > 80)
                        {
                            selectedEllipse.Width -= 10;
                            selectedEllipse.Height -= 10;
                        }
                }
                if (_selectedShape is Circle && _selectedShape.Containsss(e.Location))
                {
                    var selectedCircle = (Circle)_selectedShape;
                    if(selectedCircle.Diameter > 20)
                        selectedCircle.Diameter -= 10;
                }
                //Rotaion
                if (_selectedShape is Triangle && _selectedShape.Containsss(e.Location))
                {
                    PointF[] newPoints = new PointF[3];
                    selectedTriangle = (Triangle)_selectedShape;
                    for (int i = 0; i < selectedTriangle.points.Length; i++)
                    {
                        float x = (float)(((selectedTriangle.points[i].X - selectedTriangle.Centre.X) * Math.Cos(-angle) - ((selectedTriangle.points[i].Y - selectedTriangle.Centre.Y) * Math.Sin(-angle)) + selectedTriangle.Centre.X));
                        float y = (float)(((selectedTriangle.points[i].X - selectedTriangle.Centre.X) * Math.Sin(-angle) + ((selectedTriangle.points[i].Y - selectedTriangle.Centre.Y) * Math.Cos(-angle)) + selectedTriangle.Centre.Y));
                        newPoints[i] = new PointF(x, y);
                    }
                    selectedTriangle.points = newPoints;
                }
                if(_selectedShape is Pentagon && _selectedShape.Containsss(e.Location))
                {
                    PointF[] newPoints = new PointF[5];
                    selectedPentagon = (Pentagon)_selectedShape;
                    for (int i = 0; i < selectedPentagon.points.Length; i++)
                    {
                        float x = (float)(((selectedPentagon.points[i].X - selectedPentagon.Centre.X) * Math.Cos(-angle) - ((selectedPentagon.points[i].Y - selectedPentagon.Centre.Y) * Math.Sin(-angle)) + selectedPentagon.Centre.X));
                        float y = (float)(((selectedPentagon.points[i].X - selectedPentagon.Centre.X) * Math.Sin(-angle) + ((selectedPentagon.points[i].Y - selectedPentagon.Centre.Y) * Math.Cos(-angle)) + selectedPentagon.Centre.Y));
                        newPoints[i] = new PointF(x, y);
                    }
                    selectedPentagon.points = newPoints;
                }
                Area();
            }
            panelDraw.Invalidate();
        }
        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseMove && _selectedShape != null)
            {
                if(_selectedShape is Pentagon)
                {
                    for (int i = 0; i < selectedPentagon.points.Count(); i++)
                    {
                        selectedPentagon.points[i] = new PointF (selectedPentagon.points[i].X + (e.Location.X- mouseStartPosition.X), selectedPentagon.points[i].Y + (e.Location.Y- mouseStartPosition.Y)); 
                    }
                    mouseStartPosition = e.Location;
                }
                else if(_selectedShape is Triangle)
                {
                    for (int i = 0; i < selectedTriangle.points.Count(); i++)
                    {
                        selectedTriangle.points[i] = new PointF(selectedTriangle.points[i].X + (e.Location.X - mouseStartPosition.X), selectedTriangle.points[i].Y + (e.Location.Y - mouseStartPosition.Y));
                    }
                    mouseStartPosition = e.Location;
                }
                else 
                    _selectedShape.Location = new PointF(Math.Abs(deltaX-e.X), Math.Abs(deltaY-e.Y));
                panelDraw.Invalidate();
            }
        }
        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseMove = false;
        }
        #endregion
        #region Buttons
        private void Delete_All_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0)
                MessageBox.Show("Please, create the figure");
            else
            {
                _shapes.Clear();
                panelDraw.Invalidate();
            }
            Area();
        }
        private void Area_Click(object sender, EventArgs e)
        {
            if (_selectedShape == null)
                MessageBox.Show("Please, select figure");
            else
                _selectedShape.CalculateArea();
        }

        private void Contour_Click(object sender, EventArgs e)
        {
            if (_selectedShape == null || _selectedShape.Name == null)
                MessageBox.Show("Please, select figure");
            else
                _selectedShape.CalculateContourLength();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (_selectedShape == null || _selectedShape.Name == null)
                MessageBox.Show("Please, select figure");
            else
            {
                _shapes.Remove(_selectedShape);
                _selectedShape = null;
                panelDraw.Invalidate();
            }
            Area();
        }
        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            if (_selectedShape == null || _selectedShape.Name == null)
                MessageBox.Show("Please, select figure");
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    _selectedShape.Color2 = colorDialog1.Color;
                    _selectedShape._originalColor = colorDialog1.Color;
                    panelDraw.Invalidate();
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            var binformatter = new BinaryFormatter();
            using (var fileStream = new FileStream("shapes", FileMode.Create, FileAccess.Write))
                binformatter.Serialize(fileStream, _shapes);
        }
        #endregion
        #region Figure Forms Creation
        private void Rectangle_Click(object sender, EventArgs e)
        {
            Form Form = new Rectangle_create_form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Form Form = new Square_Create_Form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Form Form = new Triangle_Create_Form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }

        private void Pentagon_Click(object sender, EventArgs e)
        {
            Form Form = new Pentagon_Create_Form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            Form Form = new Ellipse_Create_Form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Form Form = new Circle_Create_Form(this);
            Hide();
            Form.ShowDialog();
            Area();
        }
        #endregion
    }
}
