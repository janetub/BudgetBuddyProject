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
            Add_Button = new RoundButton();
            Exit_Button = new Button();
            PageName_Label = new Label();
            AddActivityButton = new RoundButton();
            AddItemLabel = new Label();
            AddActivityLabel = new Label();
            AddItemButton = new RoundButton();
            CollapseButton = new RoundButton();
            Placeholder_Panel = new Krypton.Toolkit.KryptonPanel();
            modalPanel = new SemiTransparentPanel();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).BeginInit();
            SuspendLayout();
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 218, 70);
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 1;
            AppBar.TabStop = false;
            AppBar.MouseDown += AppBar_MouseDown;
            AppBar.MouseMove += AppBar_MouseMove;
            AppBar.MouseUp += AppBar_MouseUp;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(255, 218, 70);
            MenuButton.BackgroundImage = Properties.Resources.MenuButton_Image;
            MenuButton.BackgroundImageLayout = ImageLayout.Center;
            MenuButton.CausesValidation = false;
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
            // Add_Button
            // 
            Add_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Add_Button.BackColor = Color.LightGray;
            Add_Button.BackgroundImage = Properties.Resources.PlusButton_Image;
            Add_Button.BackgroundImageLayout = ImageLayout.Center;
            Add_Button.CausesValidation = false;
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
            Exit_Button.BackColor = Color.FromArgb(255, 218, 70);
            Exit_Button.BackgroundImage = Properties.Resources.XButton_Image;
            Exit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Exit_Button.CausesValidation = false;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Location = new Point(318, 12);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(30, 30);
            Exit_Button.TabIndex = 2;
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // PageName_Label
            // 
            PageName_Label.Anchor = AnchorStyles.None;
            PageName_Label.AutoSize = true;
            PageName_Label.BackColor = Color.FromArgb(255, 218, 70);
            PageName_Label.CausesValidation = false;
            PageName_Label.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            PageName_Label.ForeColor = Color.Black;
            PageName_Label.Location = new Point(115, 15);
            PageName_Label.Name = "PageName_Label";
            PageName_Label.Size = new Size(130, 21);
            PageName_Label.TabIndex = 0;
            PageName_Label.Text = "BudgetBuddy";
            PageName_Label.TextAlign = ContentAlignment.MiddleCenter;
            PageName_Label.SizeChanged += PageName_Label_SizeChanged;
            PageName_Label.MouseDown += AppBar_MouseDown;
            PageName_Label.MouseMove += AppBar_MouseMove;
            PageName_Label.MouseUp += AppBar_MouseUp;
            // 
            // AddActivityButton
            // 
            AddActivityButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityButton.BackColor = Color.LightGray;
            AddActivityButton.BackgroundImage = Properties.Resources.AddActivityButton1_1;
            AddActivityButton.BackgroundImageLayout = ImageLayout.Center;
            AddActivityButton.FlatAppearance.BorderSize = 0;
            AddActivityButton.FlatStyle = FlatStyle.Flat;
            AddActivityButton.ForeColor = Color.Transparent;
            AddActivityButton.Location = new Point(276, 457);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new Size(39, 39);
            AddActivityButton.TabIndex = 52;
            AddActivityButton.UseVisualStyleBackColor = false;
            AddActivityButton.Visible = false;
            AddActivityButton.Click += AddActivityButton_Click;
            // 
            // AddItemLabel
            // 
            AddItemLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemLabel.AutoSize = true;
            AddItemLabel.BackColor = Color.DimGray;
            AddItemLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddItemLabel.ForeColor = Color.White;
            AddItemLabel.Location = new Point(206, 520);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(64, 16);
            AddItemLabel.TabIndex = 55;
            AddItemLabel.Text = "Add item";
            AddItemLabel.Visible = false;
            AddItemLabel.Click += AddItemButton_Click;
            // 
            // AddActivityLabel
            // 
            AddActivityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityLabel.AutoSize = true;
            AddActivityLabel.BackColor = Color.DimGray;
            AddActivityLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddActivityLabel.ForeColor = Color.White;
            AddActivityLabel.Location = new Point(189, 468);
            AddActivityLabel.Name = "AddActivityLabel";
            AddActivityLabel.Size = new Size(81, 16);
            AddActivityLabel.TabIndex = 54;
            AddActivityLabel.Text = "Add activity";
            AddActivityLabel.Visible = false;
            AddActivityLabel.Click += AddActivityButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemButton.BackColor = Color.LightGray;
            AddItemButton.BackgroundImage = Properties.Resources.AddItemButton1_1;
            AddItemButton.BackgroundImageLayout = ImageLayout.Center;
            AddItemButton.FlatAppearance.BorderSize = 0;
            AddItemButton.FlatStyle = FlatStyle.Flat;
            AddItemButton.ForeColor = Color.Transparent;
            AddItemButton.Location = new Point(276, 506);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(39, 39);
            AddItemButton.TabIndex = 51;
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Visible = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CollapseButton.BackColor = Color.LightGray;
            CollapseButton.BackgroundImage = Properties.Resources.XButton_Image;
            CollapseButton.BackgroundImageLayout = ImageLayout.Center;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.ForeColor = Color.Transparent;
            CollapseButton.Location = new Point(276, 561);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(49, 49);
            CollapseButton.TabIndex = 53;
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Visible = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // Placeholder_Panel
            // 
            Placeholder_Panel.Anchor = AnchorStyles.Bottom;
            Placeholder_Panel.Location = new Point(0, 48);
            Placeholder_Panel.Name = "Placeholder_Panel";
            Placeholder_Panel.Size = new Size(360, 590);
            Placeholder_Panel.StateCommon.Color1 = Color.White;
            Placeholder_Panel.TabIndex = 0;
            // 
            // modalPanel
            // 
            modalPanel.Location = new Point(0, 0);
            modalPanel.Name = "modalPanel";
            modalPanel.Size = new Size(360, 640);
            modalPanel.TabIndex = 57;
            modalPanel.Visible = false;
            // 
            // AppPanel_Form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 640);
            Controls.Add(modalPanel);
            Controls.Add(AddActivityButton);
            Controls.Add(AddItemLabel);
            Controls.Add(AddActivityLabel);
            Controls.Add(AddItemButton);
            Controls.Add(CollapseButton);
            Controls.Add(PageName_Label);
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
            FormClosing += AppPanel_Form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private RoundButton Add_Button;
        private Button Exit_Button;
        private Label PageName_Label;
        private RoundButton AddActivityButton;
        private Label AddItemLabel;
        private Label AddActivityLabel;
        private RoundButton AddItemButton;
        private RoundButton CollapseButton;
        private Krypton.Toolkit.KryptonPanel Placeholder_Panel;
        private SemiTransparentPanel modalPanel;
    }
}