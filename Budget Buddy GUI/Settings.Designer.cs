﻿namespace Budget_Buddy_GUI
{
    partial class Settings
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
            panel1 = new Panel();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(217, 4);
            button6.Name = "button6";
            button6.Size = new Size(29, 23);
            button6.TabIndex = 0;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(43, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 69);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "            This is settings. \nThis is still under construction.\nThank you for understanding.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 10;
            label1.Text = "ABOUT US";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}