namespace Budget_Buddy_GUI
{
    partial class AboutUs
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
            exitButton = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(exitButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(217, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(29, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 9;
            label1.Text = "ABOUT US";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(29, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(187, 45);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "     We are the BB Developers, a 2nd year BSCS students of Visayas State University.";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(29, 147);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(187, 26);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "Scrum Master: Nina Jane Tubigon";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(29, 179);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(187, 42);
            richTextBox3.TabIndex = 12;
            richTextBox3.Text = "Coder:       Jake Patolilic\n\t   Judy Lee Baguinang";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Location = new Point(29, 227);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(187, 26);
            richTextBox4.TabIndex = 13;
            richTextBox4.Text = "Tester: Rhuvie Joyce Amarille";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(255, 178, 30);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Location = new Point(29, 268);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(187, 42);
            richTextBox5.TabIndex = 14;
            richTextBox5.Text = "UI/UX :      Tiffany Andrade\n\t   Jhon Brayl Malinao";
            richTextBox5.TextChanged += richTextBox5_TextChanged;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutUs";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button exitButton;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
    }
}