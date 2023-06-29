namespace WindowsFormsApp_PaintWhyyy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_freeline = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.label_colText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_circle = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(138, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(650, 426);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // button_freeline
            // 
            this.button_freeline.Location = new System.Drawing.Point(12, 12);
            this.button_freeline.Name = "button_freeline";
            this.button_freeline.Size = new System.Drawing.Size(120, 23);
            this.button_freeline.TabIndex = 1;
            this.button_freeline.Text = "Free Line";
            this.button_freeline.UseVisualStyleBackColor = true;
            this.button_freeline.Click += new System.EventHandler(this.button_freeline_Click);
            // 
            // button_line
            // 
            this.button_line.Location = new System.Drawing.Point(13, 42);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(119, 23);
            this.button_line.TabIndex = 2;
            this.button_line.Text = "Line";
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.Location = new System.Drawing.Point(13, 71);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(119, 23);
            this.button_rectangle.TabIndex = 3;
            this.button_rectangle.Text = "Rectangle";
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(13, 415);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(119, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_clearAll
            // 
            this.button_clearAll.Location = new System.Drawing.Point(13, 386);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(119, 23);
            this.button_clearAll.TabIndex = 5;
            this.button_clearAll.Text = "Clear All";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // label_colText
            // 
            this.label_colText.AutoSize = true;
            this.label_colText.Location = new System.Drawing.Point(12, 195);
            this.label_colText.Name = "label_colText";
            this.label_colText.Size = new System.Drawing.Size(34, 13);
            this.label_colText.TabIndex = 6;
            this.label_colText.Text = "Color:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_circle
            // 
            this.button_circle.Location = new System.Drawing.Point(12, 101);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(120, 23);
            this.button_circle.TabIndex = 8;
            this.button_circle.Text = "Circle";
            this.button_circle.UseVisualStyleBackColor = true;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 143);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_circle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_colText);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_rectangle);
            this.Controls.Add(this.button_line);
            this.Controls.Add(this.button_freeline);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_freeline;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_clearAll;
        private System.Windows.Forms.Label label_colText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

