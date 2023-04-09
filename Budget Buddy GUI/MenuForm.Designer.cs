namespace Budget_Buddy_GUI
{
    partial class MenuForm
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
            Exit = new Button();
            label1 = new Label();
            HomeButton = new Button();
            SettingsButton = new Button();
            AboutUsButton = new Button();
            HelpButton = new Button();
            FAQsButton = new Button();
            sideBar = new Panel();
            panel1.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 178, 30);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 3;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.Popup;
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Location = new Point(217, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 23);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
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
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(255, 178, 30);
            HomeButton.FlatAppearance.BorderColor = Color.Gray;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.Location = new Point(0, 85);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(252, 41);
            HomeButton.TabIndex = 9;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(255, 178, 30);
            SettingsButton.FlatAppearance.BorderColor = Color.Gray;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsButton.Location = new Point(0, 125);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(252, 41);
            SettingsButton.TabIndex = 10;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = false;
            // 
            // AboutUsButton
            // 
            AboutUsButton.BackColor = Color.FromArgb(255, 178, 30);
            AboutUsButton.FlatAppearance.BorderColor = Color.Gray;
            AboutUsButton.FlatStyle = FlatStyle.Flat;
            AboutUsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AboutUsButton.Location = new Point(0, 165);
            AboutUsButton.Name = "AboutUsButton";
            AboutUsButton.Size = new Size(252, 41);
            AboutUsButton.TabIndex = 11;
            AboutUsButton.Text = "About Us";
            AboutUsButton.UseVisualStyleBackColor = false;
            AboutUsButton.Click += AboutUsButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.FromArgb(255, 178, 30);
            HelpButton.FlatAppearance.BorderColor = Color.Gray;
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HelpButton.Location = new Point(0, 205);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(252, 41);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // FAQsButton
            // 
            FAQsButton.BackColor = Color.FromArgb(255, 178, 30);
            FAQsButton.FlatAppearance.BorderColor = Color.Gray;
            FAQsButton.FlatStyle = FlatStyle.Flat;
            FAQsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FAQsButton.Location = new Point(0, 245);
            FAQsButton.Name = "FAQsButton";
            FAQsButton.Size = new Size(252, 41);
            FAQsButton.TabIndex = 13;
            FAQsButton.Text = "FAQ's";
            FAQsButton.UseVisualStyleBackColor = false;
            // 
            // sideBar
            // 
            sideBar.Controls.Add(FAQsButton);
            sideBar.Controls.Add(HelpButton);
            sideBar.Controls.Add(AboutUsButton);
            sideBar.Controls.Add(SettingsButton);
            sideBar.Controls.Add(HomeButton);
            sideBar.Controls.Add(label1);
            sideBar.Location = new Point(0, 32);
            sideBar.MaximumSize = new Size(252, 351);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(252, 293);
            sideBar.TabIndex = 0;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button Exit;
        private Label label1;
        private Button HomeButton;
        private Button SettingsButton;
        private Button AboutUsButton;
        private Button HelpButton;
        private Button FAQsButton;
        private Panel sideBar;
    }
}