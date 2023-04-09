namespace Budget_Buddy_GUI
{
    partial class AddActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivityForm));
            AppBar = new PictureBox();
            MenuButton = new Button();
            AddButtonCollapsed = new RoundButton2();
            AddActivityButton = new RoundButton2();
            AddItemButton = new RoundButton2();
            CollapseButton = new RoundButton2();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            SuspendLayout();
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(252, 34);
            AppBar.TabIndex = 0;
            AppBar.TabStop = false;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(255, 178, 30);
            MenuButton.BackgroundImage = Properties.Resources.MenuButton_Image;
            MenuButton.BackgroundImageLayout = ImageLayout.Center;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Location = new Point(8, 3);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(30, 30);
            MenuButton.TabIndex = 20;
            MenuButton.UseVisualStyleBackColor = false;
            // 
            // AddButtonCollapsed
            // 
            AddButtonCollapsed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButtonCollapsed.BackColor = Color.LightGray;
            AddButtonCollapsed.BackgroundImage = (Image)resources.GetObject("AddButtonCollapsed.BackgroundImage");
            AddButtonCollapsed.BackgroundImageLayout = ImageLayout.Center;
            AddButtonCollapsed.FlatAppearance.BorderSize = 0;
            AddButtonCollapsed.FlatStyle = FlatStyle.Flat;
            AddButtonCollapsed.ForeColor = Color.Transparent;
            AddButtonCollapsed.Location = new Point(191, 323);
            AddButtonCollapsed.Name = "AddButtonCollapsed";
            AddButtonCollapsed.Size = new Size(49, 49);
            AddButtonCollapsed.TabIndex = 23;
            AddButtonCollapsed.UseVisualStyleBackColor = false;
            AddButtonCollapsed.Click += AddButtonCollapsed_Click;
            // 
            // AddActivityButton
            // 
            AddActivityButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddActivityButton.BackColor = Color.LightGray;
            AddActivityButton.BackgroundImage = (Image)resources.GetObject("AddActivityButton.BackgroundImage");
            AddActivityButton.BackgroundImageLayout = ImageLayout.Center;
            AddActivityButton.FlatAppearance.BorderSize = 0;
            AddActivityButton.FlatStyle = FlatStyle.Flat;
            AddActivityButton.ForeColor = Color.Transparent;
            AddActivityButton.Location = new Point(40, 307);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new Size(49, 49);
            AddActivityButton.TabIndex = 24;
            AddActivityButton.UseVisualStyleBackColor = false;
            AddActivityButton.Visible = false;
            AddActivityButton.Click += roundButton21_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddItemButton.BackColor = Color.LightGray;
            AddItemButton.BackgroundImage = (Image)resources.GetObject("AddItemButton.BackgroundImage");
            AddItemButton.BackgroundImageLayout = ImageLayout.Center;
            AddItemButton.FlatAppearance.BorderSize = 0;
            AddItemButton.FlatStyle = FlatStyle.Flat;
            AddItemButton.ForeColor = Color.Transparent;
            AddItemButton.Location = new Point(114, 307);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(49, 49);
            AddItemButton.TabIndex = 25;
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Visible = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollapseButton.BackColor = Color.LightGray;
            CollapseButton.BackgroundImage = (Image)resources.GetObject("CollapseButton.BackgroundImage");
            CollapseButton.BackgroundImageLayout = ImageLayout.Center;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.ForeColor = Color.Transparent;
            CollapseButton.Location = new Point(203, 250);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(49, 49);
            CollapseButton.TabIndex = 26;
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Visible = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // AddActivityForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(252, 384);
            Controls.Add(CollapseButton);
            Controls.Add(AddItemButton);
            Controls.Add(AddActivityButton);
            Controls.Add(AddButtonCollapsed);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddActivityForm";
            Load += AddActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
        private RoundButton2 AddButtonCollapsed;
        private RoundButton2 AddActivityButton;
        private RoundButton2 AddItemButton;
        private RoundButton2 CollapseButton;
    }
}