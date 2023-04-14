namespace Budget_Buddy_GUI
{
    partial class AppPanel_Form
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
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            Placeholder_Panel = new Krypton.Toolkit.KryptonPanel();
            Add_Button = new RoundButton();
            Exit_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).BeginInit();
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
            MenuButton.TabIndex = 0;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(3, 76);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(70, 21);
            Amount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Label.TabIndex = 33;
            Amount_Label.Values.Text = "Amount";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(23, 3);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(54, 21);
            Name_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.TabIndex = 31;
            Name_Label.Values.Text = "Name";
            // 
            // Placeholder_Panel
            // 
            Placeholder_Panel.Location = new Point(0, 50);
            Placeholder_Panel.Name = "Placeholder_Panel";
            Placeholder_Panel.Size = new Size(360, 590);
            Placeholder_Panel.StateCommon.Color1 = Color.White;
            Placeholder_Panel.TabIndex = 0;
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
            Add_Button.TabIndex = 1;
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Visible = false;
            Add_Button.Click += Add_Button_Click;
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
            Exit_Button.TabIndex = 2;
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // AppPanel_Form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 640);
            Controls.Add(Exit_Button);
            Controls.Add(Add_Button);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            Controls.Add(Placeholder_Panel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AppPanel_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationPanelForm";
            KeyDown += AppPanel_Form_KeyDown;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonPanel Placeholder_Panel;
        private RoundButton Add_Button;
        private Button Exit_Button;
    }
}