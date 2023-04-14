using System.Windows.Forms;

namespace Budget_Buddy_GUI
{
    partial class AppPanel_Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppPanel_Form2));
            AppBar = new PictureBox();
            MenuButton = new Button();
            AddButton = new RoundButton();
            checkBox1 = new CheckBox();
            CollapseButton = new RoundButton();
            AddActivityButton = new RoundButton();
            AddActivityLabel = new Label();
            AddItemLabel = new Label();
            AddItemButton = new RoundButton();
            ModalOverlay = new SemiTransparentPanel();
            Exit_Button = new Button();
            Placeholder_Panel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            ModalOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).BeginInit();
            SuspendLayout();
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(359, 50);
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
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(30, 30);
            MenuButton.TabIndex = 20;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightGray;
            AddButton.BackgroundImage = (Image)resources.GetObject("AddButton.BackgroundImage");
            AddButton.BackgroundImageLayout = ImageLayout.Center;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.ForeColor = Color.Transparent;
            AddButton.Location = new Point(276, 563);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(49, 49);
            AddButton.TabIndex = 42;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.DimGray;
            checkBox1.Location = new Point(65, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 19);
            checkBox1.TabIndex = 51;
            checkBox1.Text = "checklang";
            checkBox1.UseVisualStyleBackColor = false;
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
            CollapseButton.Location = new Point(275, 513);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(49, 49);
            CollapseButton.TabIndex = 48;
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // AddActivityButton
            // 
            AddActivityButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityButton.BackColor = Color.LightGray;
            AddActivityButton.BackgroundImage = Properties.Resources.AddItemButton1_1;
            AddActivityButton.BackgroundImageLayout = ImageLayout.Center;
            AddActivityButton.FlatAppearance.BorderSize = 0;
            AddActivityButton.FlatStyle = FlatStyle.Flat;
            AddActivityButton.ForeColor = Color.Transparent;
            AddActivityButton.Location = new Point(275, 444);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new Size(39, 39);
            AddActivityButton.TabIndex = 46;
            AddActivityButton.UseVisualStyleBackColor = false;
            // 
            // AddActivityLabel
            // 
            AddActivityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityLabel.AutoSize = true;
            AddActivityLabel.BackColor = Color.DimGray;
            AddActivityLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddActivityLabel.ForeColor = Color.White;
            AddActivityLabel.Location = new Point(188, 397);
            AddActivityLabel.Name = "AddActivityLabel";
            AddActivityLabel.Size = new Size(81, 16);
            AddActivityLabel.TabIndex = 49;
            AddActivityLabel.Text = "Add activity";
            AddActivityLabel.Click += AddActivityLabel_Click;
            // 
            // AddItemLabel
            // 
            AddItemLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemLabel.AutoSize = true;
            AddItemLabel.BackColor = Color.DimGray;
            AddItemLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddItemLabel.ForeColor = Color.White;
            AddItemLabel.Location = new Point(205, 455);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(64, 16);
            AddItemLabel.TabIndex = 50;
            AddItemLabel.Text = "Add item";
            AddItemLabel.Click += AddItemLabel_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemButton.BackColor = Color.LightGray;
            AddItemButton.BackgroundImage = Properties.Resources.AddActivityButton1_1;
            AddItemButton.BackgroundImageLayout = ImageLayout.Center;
            AddItemButton.FlatAppearance.BorderSize = 0;
            AddItemButton.FlatStyle = FlatStyle.Flat;
            AddItemButton.ForeColor = Color.Transparent;
            AddItemButton.Location = new Point(275, 386);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(39, 39);
            AddItemButton.TabIndex = 47;
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ModalOverlay
            // 
            ModalOverlay.BackColor = Color.Black;
            ModalOverlay.Controls.Add(AddItemButton);
            ModalOverlay.Controls.Add(AddItemLabel);
            ModalOverlay.Controls.Add(AddActivityLabel);
            ModalOverlay.Controls.Add(AddActivityButton);
            ModalOverlay.Controls.Add(CollapseButton);
            ModalOverlay.Location = new Point(0, 50);
            ModalOverlay.Name = "ModalOverlay";
            ModalOverlay.Size = new Size(359, 590);
            ModalOverlay.TabIndex = 43;
            ModalOverlay.Visible = false;
            ModalOverlay.Click += ModalOverlay_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.FromArgb(255, 178, 30);
            Exit_Button.BackgroundImage = Properties.Resources.XButton_Image;
            Exit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Location = new Point(317, 12);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(30, 30);
            Exit_Button.TabIndex = 54;
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Placeholder_Panel
            // 
            Placeholder_Panel.Location = new Point(0, 50);
            Placeholder_Panel.Name = "Placeholder_Panel";
            Placeholder_Panel.Size = new Size(360, 590);
            Placeholder_Panel.StateCommon.Color1 = Color.White;
            Placeholder_Panel.TabIndex = 55;
            Placeholder_Panel.Visible = false;
            // 
            // AppPanel_Form2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(359, 640);
            Controls.Add(ModalOverlay);
            Controls.Add(Exit_Button);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            Controls.Add(checkBox1);
            Controls.Add(AddButton);
            Controls.Add(Placeholder_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppPanel_Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddActivityForm";
            Load += AddActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ModalOverlay.ResumeLayout(false);
            ModalOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Placeholder_Panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
        private RoundButton AddButton;
        private CheckBox checkBox1;
        private RoundButton CollapseButton;
        private RoundButton AddActivityButton;
        private Label AddActivityLabel;
        private Label AddItemLabel;
        private RoundButton AddItemButton;
        private SemiTransparentPanel ModalOverlay;
        private Button Exit_Button;
        private Krypton.Toolkit.KryptonPanel Placeholder_Panel;
    }
}