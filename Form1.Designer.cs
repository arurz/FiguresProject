namespace CourseProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDraw = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Pentagon = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Contour = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChangeColorBtn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete_All = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelDraw.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Controls.Add(this.statusStrip1);
            this.panelDraw.Location = new System.Drawing.Point(2, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(766, 603);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 27);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Tag = "";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 21);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 21);
            this.toolStripStatusLabel2.Text = "Area:";
            // 
            // Rectangle
            // 
            this.Rectangle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rectangle.Location = new System.Drawing.Point(69, 123);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(105, 34);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(69, 177);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(105, 31);
            this.Square.TabIndex = 2;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(69, 234);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(105, 29);
            this.Triangle.TabIndex = 3;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Pentagon
            // 
            this.Pentagon.Location = new System.Drawing.Point(69, 292);
            this.Pentagon.Name = "Pentagon";
            this.Pentagon.Size = new System.Drawing.Size(105, 27);
            this.Pentagon.TabIndex = 4;
            this.Pentagon.Text = "Pentagon";
            this.Pentagon.UseVisualStyleBackColor = true;
            this.Pentagon.Click += new System.EventHandler(this.Pentagon_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(69, 342);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(105, 27);
            this.Ellipse.TabIndex = 5;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(69, 392);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(105, 28);
            this.Circle.TabIndex = 6;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Contour
            // 
            this.Contour.Location = new System.Drawing.Point(65, 136);
            this.Contour.Name = "Contour";
            this.Contour.Size = new System.Drawing.Size(118, 28);
            this.Contour.TabIndex = 8;
            this.Contour.Text = "Contour";
            this.Contour.UseVisualStyleBackColor = true;
            this.Contour.Click += new System.EventHandler(this.Contour_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(65, 268);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 30);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete ";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(767, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(248, 603);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rectangle);
            this.tabPage1.Controls.Add(this.Triangle);
            this.tabPage1.Controls.Add(this.Pentagon);
            this.tabPage1.Controls.Add(this.Ellipse);
            this.tabPage1.Controls.Add(this.Circle);
            this.tabPage1.Controls.Add(this.Square);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creating Figures";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChangeColorBtn);
            this.tabPage2.Controls.Add(this.Save);
            this.tabPage2.Controls.Add(this.Delete_All);
            this.tabPage2.Controls.Add(this.Delete);
            this.tabPage2.Controls.Add(this.Contour);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(240, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Functions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChangeColorBtn
            // 
            this.ChangeColorBtn.Location = new System.Drawing.Point(65, 390);
            this.ChangeColorBtn.Name = "ChangeColorBtn";
            this.ChangeColorBtn.Size = new System.Drawing.Size(118, 31);
            this.ChangeColorBtn.TabIndex = 12;
            this.ChangeColorBtn.Text = "Change Color";
            this.ChangeColorBtn.UseVisualStyleBackColor = true;
            this.ChangeColorBtn.Click += new System.EventHandler(this.ChangeColorBtn_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(65, 200);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(118, 28);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete_All
            // 
            this.Delete_All.Location = new System.Drawing.Point(65, 329);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(118, 31);
            this.Delete_All.TabIndex = 10;
            this.Delete_All.Text = "Delete All";
            this.Delete_All.UseVisualStyleBackColor = true;
            this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelDraw);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Scene";
            this.panelDraw.ResumeLayout(false);
            this.panelDraw.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Pentagon;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Contour;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Delete_All;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button ChangeColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

