namespace Budget_Buddy_GUI
{
    partial class AppPanel_SampleForm
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
            MenuButton = new Button();
            AppBar = new PictureBox();
            Exit_Button = new Button();
            Add_Button = new RoundButton();
            Placeholder_Panel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).BeginInit();
            SuspendLayout();
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
            MenuButton.TabIndex = 34;
            MenuButton.UseVisualStyleBackColor = false;
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 36;
            AppBar.TabStop = false;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.FromArgb(255, 178, 30);
            Exit_Button.BackgroundImage = Properties.Resources.XButton_Image;
            Exit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Location = new Point(318, 12);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(30, 30);
            Exit_Button.TabIndex = 38;
            Exit_Button.UseVisualStyleBackColor = false;
            // 
            // Add_Button
            // 
            Add_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Add_Button.BackColor = Color.LightGray;
            Add_Button.BackgroundImage = Properties.Resources.PlusButton_Image;
            Add_Button.BackgroundImageLayout = ImageLayout.Center;
            Add_Button.FlatAppearance.BorderSize = 0;
            Add_Button.FlatStyle = FlatStyle.Flat;
            Add_Button.ForeColor = Color.Transparent;
            Add_Button.Location = new Point(276, 561);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(49, 49);
            Add_Button.TabIndex = 37;
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Visible = false;
            // 
            // Placeholder_Panel
            // 
            Placeholder_Panel.Location = new Point(0, 50);
            Placeholder_Panel.Name = "Placeholder_Panel";
            Placeholder_Panel.Size = new Size(360, 590);
            Placeholder_Panel.StateCommon.Color1 = Color.White;
            Placeholder_Panel.TabIndex = 35;
            // 
            // AppPanel_SampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 640);
            Controls.Add(MenuButton);
            Controls.Add(Exit_Button);
            Controls.Add(Add_Button);
            Controls.Add(Placeholder_Panel);
            Controls.Add(AppBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppPanel_SampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppPanel_SampleForm";
            Load += AppPanel_SampleForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button MenuButton;
        private PictureBox AppBar;
        private Button Exit_Button;
        private RoundButton Add_Button;
        private Krypton.Toolkit.KryptonPanel Placeholder_Panel;
    }
}