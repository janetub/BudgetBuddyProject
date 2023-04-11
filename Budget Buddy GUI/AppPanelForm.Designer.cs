namespace Budget_Buddy_GUI
{
    partial class AppPanelForm
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
            AppBar = new PictureBox();
            MenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            SuspendLayout();
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 1;
            AppBar.TabStop = false;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(255, 178, 30);
            MenuButton.BackgroundImage = Properties.Resources.MenuButton_Image;
            MenuButton.BackgroundImageLayout = ImageLayout.Center;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(30, 30);
            MenuButton.TabIndex = 21;
            MenuButton.UseVisualStyleBackColor = false;
            // 
            // AppPanelForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 640);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AppPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationPanelForm";
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
    }
}