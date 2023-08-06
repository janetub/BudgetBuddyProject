namespace Budget_Buddy_GUI
{
    partial class ExpandingButtonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpandingButtonControl));
            AddButton = new RoundButton();
            ModalOverlay = new SemiTransparentPanel();
            AddActivityButton = new RoundButton();
            AddItemButton = new RoundButton();
            CollapseButton = new RoundButton();
            AddItemLabel = new Label();
            AddActivityLabel = new Label();
            ModalOverlay.SuspendLayout();
            SuspendLayout();
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
            AddButton.TabIndex = 40;
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
            ModalOverlay.Location = new Point(0, 0);
            ModalOverlay.Name = "ModalOverlay";
            ModalOverlay.Size = new Size(360, 640);
            ModalOverlay.TabIndex = 41;
            ModalOverlay.Visible = false;
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
            AddActivityButton.Location = new Point(276, 504);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new Size(39, 39);
            AddActivityButton.TabIndex = 41;
            AddActivityButton.UseVisualStyleBackColor = false;
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
            AddItemButton.Location = new Point(276, 459);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(39, 39);
            AddItemButton.TabIndex = 42;
            AddItemButton.UseVisualStyleBackColor = false;
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
            CollapseButton.Location = new Point(276, 563);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(49, 49);
            CollapseButton.TabIndex = 43;
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // AddItemLabel
            // 
            AddItemLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemLabel.AutoSize = true;
            AddItemLabel.BackColor = Color.DimGray;
            AddItemLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddItemLabel.ForeColor = Color.White;
            AddItemLabel.Location = new Point(206, 518);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(64, 16);
            AddItemLabel.TabIndex = 45;
            AddItemLabel.Text = "Add item";
            // 
            // AddActivityLabel
            // 
            AddActivityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddActivityLabel.AutoSize = true;
            AddActivityLabel.BackColor = Color.DimGray;
            AddActivityLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddActivityLabel.ForeColor = Color.White;
            AddActivityLabel.Location = new Point(189, 470);
            AddActivityLabel.Name = "AddActivityLabel";
            AddActivityLabel.Size = new Size(81, 16);
            AddActivityLabel.TabIndex = 44;
            AddActivityLabel.Text = "Add activity";
            // 
            // ExpandingButtonControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(ModalOverlay);
            Controls.Add(AddButton);
            ForeColor = Color.Transparent;
            Name = "ExpandingButtonControl";
            Size = new Size(360, 640);
            ModalOverlay.ResumeLayout(false);
            ModalOverlay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundButton AddButton;
        private SemiTransparentPanel ModalOverlay;
        private RoundButton AddItemButton;
        private Label AddItemLabel;
        private Label AddActivityLabel;
        private RoundButton AddActivityButton;
        private RoundButton CollapseButton;
    }
}
