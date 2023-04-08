namespace Budget_Buddy_GUI
{
    partial class EmptyActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyActivity));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pb = new PictureBox();
            circularButton1 = new CircularButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 50);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 178, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(99, 303);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 20;
            label2.Text = "No activities / items.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 28);
            label1.TabIndex = 22;
            label1.Text = "This week's grocery shopping";
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Location = new Point(24, 122);
            pb.Name = "pb";
            pb.Size = new Size(311, 30);
            pb.TabIndex = 24;
            pb.TabStop = false;
            // 
            // circularButton1
            // 
            circularButton1.AllowDrop = true;
            circularButton1.BackColor = Color.FromArgb(217, 217, 217);
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.FromArgb(217, 217, 217);
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(288, 572);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(49, 49);
            circularButton1.TabIndex = 28;
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += circularButton1_Click;
            // 
            // EmptyActivity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 642);
            Controls.Add(circularButton1);
            Controls.Add(pb);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmptyActivity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmptyActivity";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pb;
        private CircularButton circularButton1;
    }
}