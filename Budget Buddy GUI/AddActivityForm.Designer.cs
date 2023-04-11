using System.Windows.Forms;

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
            AddButton = new RoundButton();
            ModalOverlay = new SemiTransparentPanel();
            AddItemButton = new RoundButton();
            AddItemLabel = new Label();
            AddActivityLabel = new Label();
            AddActivityButton = new RoundButton();
            CollapseButton = new RoundButton();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            ModalOverlay.SuspendLayout();
            SuspendLayout();
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
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
            // ModalOverlay
            // 
            ModalOverlay.BackColor = Color.Black;
            ModalOverlay.Controls.Add(AddItemButton);
            ModalOverlay.Controls.Add(AddItemLabel);
            ModalOverlay.Controls.Add(AddActivityLabel);
            ModalOverlay.Controls.Add(AddActivityButton);
            ModalOverlay.Controls.Add(CollapseButton);
            ModalOverlay.Dock = DockStyle.Fill;
            ModalOverlay.Location = new Point(0, 0);
            ModalOverlay.Name = "ModalOverlay";
            ModalOverlay.Size = new Size(360, 640);
            ModalOverlay.TabIndex = 43;
            ModalOverlay.Visible = false;
            ModalOverlay.Click += ModalOverlay_Click;
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
            AddItemButton.Location = new Point(276, 438);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(39, 39);
            AddItemButton.TabIndex = 47;
            AddItemButton.UseVisualStyleBackColor = false;
            // 
            // AddItemLabel
            // 
            AddItemLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemLabel.AutoSize = true;
            AddItemLabel.BackColor = Color.DimGray;
            AddItemLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddItemLabel.ForeColor = Color.White;
            AddItemLabel.Location = new Point(206, 505);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(64, 16);
            AddItemLabel.TabIndex = 50;
            AddItemLabel.Text = "Add item";
            // 
            // AddActivityLabel
            // 
            AddActivityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityLabel.AutoSize = true;
            AddActivityLabel.BackColor = Color.DimGray;
            AddActivityLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddActivityLabel.ForeColor = Color.White;
            AddActivityLabel.Location = new Point(189, 447);
            AddActivityLabel.Name = "AddActivityLabel";
            AddActivityLabel.Size = new Size(81, 16);
            AddActivityLabel.TabIndex = 49;
            AddActivityLabel.Text = "Add activity";
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
            AddActivityButton.Location = new Point(276, 496);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new Size(39, 39);
            AddActivityButton.TabIndex = 46;
            AddActivityButton.UseVisualStyleBackColor = false;
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
            CollapseButton.TabIndex = 48;
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
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
            // AddActivityForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(360, 640);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            Controls.Add(ModalOverlay);
            Controls.Add(checkBox1);
            Controls.Add(AddButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddActivityForm";
            Load += AddActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ModalOverlay.ResumeLayout(false);
            ModalOverlay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AppBar;
        private Button MenuButton;
        private RoundButton AddButton;
        private SemiTransparentPanel ModalOverlay;
        private RoundButton AddItemButton;
        private Label AddItemLabel;
        private Label AddActivityLabel;
        private RoundButton AddActivityButton;
        private RoundButton CollapseButton;
        private CheckBox checkBox1;
    }
}