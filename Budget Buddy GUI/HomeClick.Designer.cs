﻿namespace Budget_Buddy_GUI
{
    partial class HomeClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeClick));
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(123, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
            label1.TabIndex = 9;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 178, 30);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 50);
            panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 178, 30);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 178, 30);
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 165);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(360, 68);
            button1.TabIndex = 12;
            button1.Text = "Create Budget";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 178, 30);
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 297);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(360, 68);
            button2.TabIndex = 13;
            button2.Text = "Analytics";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 178, 30);
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 232);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(360, 68);
            button3.TabIndex = 14;
            button3.Text = "Budget Created";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // HomeClick
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 640);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomeClick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeClick";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}