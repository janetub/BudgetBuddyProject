namespace Budget_Buddy_GUI
{
    partial class MenuForCreateBudget
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
            sideBar = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Controls.Add(button5);
            sideBar.Controls.Add(button4);
            sideBar.Controls.Add(button3);
            sideBar.Controls.Add(button2);
            sideBar.Controls.Add(button1);
            sideBar.Controls.Add(label1);
            sideBar.Location = new Point(0, 33);
            sideBar.MaximumSize = new Size(252, 351);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(252, 306);
            sideBar.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 178, 30);
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(0, 245);
            button5.Name = "button5";
            button5.Size = new Size(252, 41);
            button5.TabIndex = 13;
            button5.Text = "FAQ's";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 178, 30);
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(0, 205);
            button4.Name = "button4";
            button4.Size = new Size(252, 41);
            button4.TabIndex = 12;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 178, 30);
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 165);
            button3.Name = "button3";
            button3.Size = new Size(252, 41);
            button3.TabIndex = 11;
            button3.Text = "About Us";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 178, 30);
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 125);
            button2.Name = "button2";
            button2.Size = new Size(252, 41);
            button2.TabIndex = 10;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 178, 30);
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 85);
            button1.Name = "button1";
            button1.Size = new Size(252, 41);
            button1.TabIndex = 9;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(93, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 8;
            label1.Text = "MENU";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 4;
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
            // MenuForCreateBudget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(panel1);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForCreateBudget";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForCreateBudget";
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Button button6;
    }
}