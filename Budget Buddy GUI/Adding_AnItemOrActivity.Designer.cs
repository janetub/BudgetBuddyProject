namespace Budget_Buddy_GUI
{
    partial class Adding_AnItemOrActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding_AnItemOrActivity));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            roundButton1 = new RoundButton();
            roundButton2 = new RoundButton();
            roundButton3 = new RoundButton();
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
            panel1.Size = new Size(360, 50);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 178, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 50);
            button1.Name = "button1";
            button1.Size = new Size(360, 88);
            button1.TabIndex = 9;
            button1.Text = "Budget Created No 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(217, 217, 217);
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundButton1.ForeColor = Color.Black;
            roundButton1.Location = new Point(281, 567);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(53, 50);
            roundButton1.TabIndex = 10;
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            roundButton2.BackColor = Color.FromArgb(217, 217, 217);
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(281, 485);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(53, 50);
            roundButton2.TabIndex = 11;
            roundButton2.UseVisualStyleBackColor = false;
            roundButton2.Click += roundButton2_Click;
            // 
            // roundButton3
            // 
            roundButton3.BackColor = Color.FromArgb(217, 217, 217);
            roundButton3.FlatAppearance.BorderSize = 0;
            roundButton3.FlatStyle = FlatStyle.Flat;
            roundButton3.ForeColor = Color.White;
            roundButton3.Location = new Point(281, 413);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(53, 50);
            roundButton3.TabIndex = 12;
            roundButton3.UseVisualStyleBackColor = false;
            // 
            // Adding_AnItemOrActivity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 640);
            Controls.Add(roundButton3);
            Controls.Add(roundButton2);
            Controls.Add(roundButton1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Adding_AnItemOrActivity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPopUpButtons";
            Load += Adding_AnItemOrActivity_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
    }
}