namespace Budget_Buddy_GUI
{
    partial class View_Activity2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Activity2));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            circularButton1 = new CircularButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 257);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "This is view actvity 2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 50);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // circularButton1
            // 
            circularButton1.AllowDrop = true;
            circularButton1.BackColor = Color.FromArgb(217, 217, 217);
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.FromArgb(217, 217, 217);
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(292, 570);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(49, 49);
            circularButton1.TabIndex = 30;
            circularButton1.UseVisualStyleBackColor = false;
            // 
            // View_Activity2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 640);
            Controls.Add(circularButton1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "View_Activity2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Activity2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private CircularButton circularButton1;
    }
}