namespace CourseProject
{
    partial class Circle_Create_Form
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
            this.Diametre = new System.Windows.Forms.NumericUpDown();
            this.y_Value = new System.Windows.Forms.NumericUpDown();
            this.x_Value = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Diametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Diametre
            // 
            this.Diametre.Location = new System.Drawing.Point(348, 68);
            this.Diametre.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Diametre.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Diametre.Name = "Diametre";
            this.Diametre.Size = new System.Drawing.Size(120, 22);
            this.Diametre.TabIndex = 16;
            this.Diametre.Value = new decimal(new int[] {
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
            this.y_Value.TabIndex = 15;
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
            this.x_Value.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diametre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseProject.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(68, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Circle_Create_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diametre);
            this.Controls.Add(this.y_Value);
            this.Controls.Add(this.x_Value);
            this.Controls.Add(this.button1);
            this.Name = "Circle_Create_Form";
            this.Text = "Circle Create Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Circle_Create_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Diametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Diametre;
        private System.Windows.Forms.NumericUpDown y_Value;
        private System.Windows.Forms.NumericUpDown x_Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}