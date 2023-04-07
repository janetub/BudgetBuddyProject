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
            roundButton1 = new RoundButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 178, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2);
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
            label2.Location = new Point(69, 182);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 20;
            label2.Text = "No activities / items.";
            label2.Click += label2_Click;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(217, 217, 217);
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.ForeColor = Color.White;
            roundButton1.Image = (Image)resources.GetObject("roundButton1.Image");
            roundButton1.Location = new Point(200, 341);
            roundButton1.Margin = new Padding(2);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(37, 30);
            roundButton1.TabIndex = 21;
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += roundButton1_Click;
            // 
            // EmptyActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 385);
            Controls.Add(roundButton1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmptyActivity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmptyActivity";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private RoundButton roundButton1;
        private PictureBox pictureBox1;
    }
}