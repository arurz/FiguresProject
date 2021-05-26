namespace CourseProject
{
    partial class Ellipse_Create_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heigth = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.y_Value = new System.Windows.Forms.NumericUpDown();
            this.x_Value = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Heigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Heigth
            // 
            this.Heigth.Location = new System.Drawing.Point(348, 96);
            this.Heigth.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Heigth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Heigth.Name = "Heigth";
            this.Heigth.Size = new System.Drawing.Size(120, 22);
            this.Heigth.TabIndex = 13;
            this.Heigth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(348, 68);
            this.Width.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Width.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(120, 22);
            this.Width.TabIndex = 12;
            this.Width.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // y_Value
            // 
            this.y_Value.Location = new System.Drawing.Point(348, 40);
            this.y_Value.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.y_Value.Name = "y_Value";
            this.y_Value.Size = new System.Drawing.Size(120, 22);
            this.y_Value.TabIndex = 11;
            // 
            // x_Value
            // 
            this.x_Value.Location = new System.Drawing.Point(348, 12);
            this.x_Value.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.x_Value.Name = "x_Value";
            this.x_Value.Size = new System.Drawing.Size(120, 22);
            this.x_Value.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Heigth:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseProject.Properties.Resources.ellipse;
            this.pictureBox1.Location = new System.Drawing.Point(54, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Ellipse_Create_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Heigth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.y_Value);
            this.Controls.Add(this.x_Value);
            this.Controls.Add(this.button1);
            this.Name = "Ellipse_Create_Form";
            this.Text = "Ellipse Create Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ellipse_Create_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Heigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Heigth;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown y_Value;
        private System.Windows.Forms.NumericUpDown x_Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}