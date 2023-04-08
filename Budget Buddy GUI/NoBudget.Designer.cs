namespace Budget_Buddy_GUI
{
    partial class NoBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoBudget));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            circularButton1 = new CircularButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(127, 308);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 3;
            label2.Text = "No budgets.";
            label2.Click += label2_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 50);
            panel1.TabIndex = 4;
            // 
            // circularButton1
            // 
            circularButton1.AllowDrop = true;
            circularButton1.BackColor = Color.FromArgb(217, 217, 217);
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.FromArgb(217, 217, 217);
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(290, 570);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(49, 49);
            circularButton1.TabIndex = 29;
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += circularButton1_Click;
            // 
            // NoBudget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 640);
            Controls.Add(circularButton1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NoBudget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private CircularButton circularButton1;
    }
}