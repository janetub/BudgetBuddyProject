namespace Budget_Buddy_GUI
{
    partial class View_Activity1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Activity1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pb = new PictureBox();
            button1 = new Button();
            button2 = new Button();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 50);
            panel1.TabIndex = 5;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 73);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 13;
            label1.Text = "March 2023 W1 Budget";
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Location = new Point(24, 122);
            pb.Name = "pb";
            pb.Size = new Size(311, 30);
            pb.TabIndex = 14;
            pb.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 240);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(380, 83);
            button1.TabIndex = 23;
            button1.Text = "This week's grocery shopping";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 318);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(380, 83);
            button2.TabIndex = 25;
            button2.Text = "Fare";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // circularButton1
            // 
            circularButton1.AllowDrop = true;
            circularButton1.BackColor = Color.FromArgb(217, 217, 217);
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.FromArgb(217, 217, 217);
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(286, 564);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(49, 49);
            circularButton1.TabIndex = 30;
            circularButton1.UseVisualStyleBackColor = false;
            // 
            // View_Activity1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 640);
            Controls.Add(circularButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "View_Activity1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Activity1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pb;
        private Button button1;
        private Button button2;
        private CircularButton circularButton1;
    }
}