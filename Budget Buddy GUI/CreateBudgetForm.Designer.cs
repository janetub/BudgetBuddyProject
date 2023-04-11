namespace Budget_Buddy_GUI
{
    partial class CreateBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBudgetForm));
            MenuButton = new Button();
            AppBar = new PictureBox();
            CreateBudgetButton = new Button();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            InputFields_Panel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Amount_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            InputFields_Panel.SuspendLayout();
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
            MenuButton.TabIndex = 22;
            MenuButton.UseVisualStyleBackColor = false;
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 21;
            AppBar.TabStop = false;
            // 
            // CreateBudgetButton
            // 
            CreateBudgetButton.BackColor = Color.FromArgb(255, 178, 30);
            CreateBudgetButton.FlatAppearance.BorderSize = 0;
            CreateBudgetButton.FlatStyle = FlatStyle.Flat;
            CreateBudgetButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetButton.Location = new Point(0, 590);
            CreateBudgetButton.Name = "CreateBudgetButton";
            CreateBudgetButton.Size = new Size(360, 50);
            CreateBudgetButton.TabIndex = 25;
            CreateBudgetButton.Text = "Create Budget";
            CreateBudgetButton.UseVisualStyleBackColor = false;
            CreateBudgetButton.Click += CreateBudgetButton_Click;
            // 
            // Name_TextBox
            // 
            Name_TextBox.AlwaysActive = false;
            Name_TextBox.AsciiOnly = true;
            Name_TextBox.Cursor = Cursors.IBeam;
            Name_TextBox.Hint = "Enter budget name here";
            Name_TextBox.Location = new Point(3, 84);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(332, 29);
            Name_TextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Name_TextBox.StateCommon.Back.Color1 = Color.White;
            Name_TextBox.StateCommon.Border.Color1 = Color.Black;
            Name_TextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Name_TextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name_TextBox.StateCommon.Content.Padding = new Padding(5);
            Name_TextBox.TabIndex = 29;
            Name_TextBox.Validating += BudgetNameTextBox_Validating;
            // 
            // InputFields_Panel
            // 
            InputFields_Panel.BackgroundImage = (Image)resources.GetObject("InputFields_Panel.BackgroundImage");
            InputFields_Panel.BackgroundImageLayout = ImageLayout.None;
            InputFields_Panel.ColumnCount = 1;
            InputFields_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            InputFields_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            InputFields_Panel.Controls.Add(Amount_TextBox, 0, 3);
            InputFields_Panel.Controls.Add(Name_TextBox, 0, 1);
            InputFields_Panel.Controls.Add(Amount_Label, 0, 2);
            InputFields_Panel.Controls.Add(Name_Label, 0, 0);
            InputFields_Panel.Location = new Point(10, 56);
            InputFields_Panel.Name = "InputFields_Panel";
            InputFields_Panel.RowCount = 4;
            InputFields_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            InputFields_Panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            InputFields_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            InputFields_Panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 345F));
            InputFields_Panel.Size = new Size(338, 528);
            InputFields_Panel.StateCommon.Color1 = Color.White;
            InputFields_Panel.TabIndex = 37;
            // 
            // Amount_TextBox
            // 
            Amount_TextBox.AlwaysActive = false;
            Amount_TextBox.AsciiOnly = true;
            Amount_TextBox.Cursor = Cursors.IBeam;
            Amount_TextBox.Hint = "Enter budget amount here";
            Amount_TextBox.Location = new Point(3, 185);
            Amount_TextBox.Name = "Amount_TextBox";
            Amount_TextBox.Size = new Size(332, 29);
            Amount_TextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Amount_TextBox.StateCommon.Back.Color1 = Color.White;
            Amount_TextBox.StateCommon.Border.Color1 = Color.Black;
            Amount_TextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Amount_TextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Amount_TextBox.StateCommon.Content.Padding = new Padding(5);
            Amount_TextBox.TabIndex = 32;
            Amount_TextBox.Validating += Amount_TextBox_Validating;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(3, 158);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(70, 21);
            Amount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Label.TabIndex = 31;
            Amount_Label.Values.Text = "Amount";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(3, 57);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(54, 21);
            Name_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.TabIndex = 30;
            Name_Label.Values.Text = "Name";
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.Location = new Point(58, 113);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 33;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // RequiredAmount_Label
            // 
            RequiredAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredAmount_Label.Location = new Point(76, 213);
            RequiredAmount_Label.Name = "RequiredAmount_Label";
            RequiredAmount_Label.Size = new Size(18, 21);
            RequiredAmount_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredAmount_Label.TabIndex = 38;
            RequiredAmount_Label.Values.Text = "*";
            RequiredAmount_Label.Visible = false;
            // 
            // CreateBudgetForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(360, 640);
            Controls.Add(RequiredAmount_Label);
            Controls.Add(RequiredName_Label);
            Controls.Add(InputFields_Panel);
            Controls.Add(CreateBudgetButton);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateBudgetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CreateBudgetForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            InputFields_Panel.ResumeLayout(false);
            InputFields_Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuButton;
        private PictureBox AppBar;
        private Button CreateBudgetButton;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Krypton.Toolkit.KryptonTableLayoutPanel InputFields_Panel;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Amount_TextBox;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private Krypton.Toolkit.KryptonLabel RequiredAmount_Label;
    }
}