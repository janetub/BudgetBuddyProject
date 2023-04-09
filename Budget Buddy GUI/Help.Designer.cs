namespace Budget_Buddy_GUI
{
    partial class Help
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
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
            panel1.TabIndex = 6;
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
            button6.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 11;
            label1.Text = "NEED HELP?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(22, 163);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(218, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.facebook.com/nina.janeee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 108);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 13;
            label2.Text = "Having trouble? Contact our ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 136);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 14;
            label3.Text = "Scrum Master here:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(12, 192);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(233, 15);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://www.instagram.com/persephonin/";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel2;
    }
}