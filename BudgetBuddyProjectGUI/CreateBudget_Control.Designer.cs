namespace Budget_Buddy_GUI
{
    partial class CreateBudget_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBudget_Control));
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            Amount_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            CreateBudgetButton = new Button();
            RequiredAmount_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            Back_Button = new Button();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateBudgetInputFields_TableLayoutPanel
            // 
            CreateBudgetInputFields_TableLayoutPanel.Anchor = AnchorStyles.None;
            CreateBudgetInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateBudgetInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Amount_Label, 0, 2);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_Label, 0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_TextBox, 0, 1);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Amount_NumUpDown, 0, 3);
            CreateBudgetInputFields_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetInputFields_TableLayoutPanel.Location = new Point(0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Margin = new Padding(0);
            CreateBudgetInputFields_TableLayoutPanel.Name = "CreateBudgetInputFields_TableLayoutPanel";
            CreateBudgetInputFields_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            CreateBudgetInputFields_TableLayoutPanel.RowCount = 4;
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 345F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.Size = new Size(360, 540);
            CreateBudgetInputFields_TableLayoutPanel.TabIndex = 0;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(23, 170);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(70, 21);
            Amount_Label.StateCommon.ShortText.Color1 = Color.Black;
            Amount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Label.TabIndex = 33;
            Amount_Label.Values.Text = "Amount";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(23, 48);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(54, 21);
            Name_Label.StateCommon.ShortText.Color1 = Color.Black;
            Name_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.TabIndex = 0;
            Name_Label.Values.Text = "Name";
            // 
            // Name_TextBox
            // 
            Name_TextBox.AlwaysActive = false;
            Name_TextBox.AsciiOnly = true;
            Name_TextBox.Cursor = Cursors.IBeam;
            Name_TextBox.Hint = "Enter budget name here";
            Name_TextBox.Location = new Point(23, 75);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(314, 29);
            Name_TextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Name_TextBox.StateActive.Content.Color1 = Color.Black;
            Name_TextBox.StateCommon.Back.Color1 = Color.White;
            Name_TextBox.StateCommon.Border.Color1 = Color.Black;
            Name_TextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Name_TextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name_TextBox.StateCommon.Content.Padding = new Padding(5);
            Name_TextBox.TabIndex = 1;
            Name_TextBox.PreviewKeyDown += Name_TextBox_PreviewKeyDown;
            Name_TextBox.Validating += Name_TextBox_Validating;
            // 
            // Amount_NumUpDown
            // 
            Amount_NumUpDown.AllowDecimals = true;
            Amount_NumUpDown.AlwaysActive = false;
            Amount_NumUpDown.Cursor = Cursors.IBeam;
            Amount_NumUpDown.DecimalPlaces = 2;
            Amount_NumUpDown.Location = new Point(20, 194);
            Amount_NumUpDown.Margin = new Padding(0);
            Amount_NumUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 131072 });
            Amount_NumUpDown.Name = "Amount_NumUpDown";
            Amount_NumUpDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Amount_NumUpDown.Size = new Size(317, 23);
            Amount_NumUpDown.StateActive.Back.Color1 = Color.WhiteSmoke;
            Amount_NumUpDown.StateActive.Content.Color1 = Color.Black;
            Amount_NumUpDown.StateActive.Content.Padding = new Padding(0);
            Amount_NumUpDown.StateCommon.Back.Color1 = Color.White;
            Amount_NumUpDown.StateCommon.Border.Color1 = Color.Black;
            Amount_NumUpDown.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Amount_NumUpDown.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Amount_NumUpDown.StateCommon.Content.Padding = new Padding(5);
            Amount_NumUpDown.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Amount_NumUpDown.TabIndex = 2;
            Amount_NumUpDown.ThousandsSeparator = true;
            Amount_NumUpDown.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            Amount_NumUpDown.UseMnemonic = false;
            Amount_NumUpDown.KeyDown += Amount_NumUpDown_KeyDown;
            Amount_NumUpDown.Validating += Amount_NumUpDown_Validating;
            // 
            // CreateBudgetButton
            // 
            CreateBudgetButton.BackColor = Color.FromArgb(255, 198, 50);
            CreateBudgetButton.Dock = DockStyle.Bottom;
            CreateBudgetButton.FlatAppearance.BorderSize = 0;
            CreateBudgetButton.FlatStyle = FlatStyle.Flat;
            CreateBudgetButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetButton.ForeColor = Color.Black;
            CreateBudgetButton.Location = new Point(0, 540);
            CreateBudgetButton.Name = "CreateBudgetButton";
            CreateBudgetButton.Size = new Size(360, 50);
            CreateBudgetButton.TabIndex = 0;
            CreateBudgetButton.Text = "Create Budget";
            CreateBudgetButton.UseVisualStyleBackColor = false;
            CreateBudgetButton.Click += CreateBudgetButton_Click;
            // 
            // RequiredAmount_Label
            // 
            RequiredAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredAmount_Label.Location = new Point(84, 170);
            RequiredAmount_Label.Name = "RequiredAmount_Label";
            RequiredAmount_Label.Size = new Size(18, 21);
            RequiredAmount_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredAmount_Label.TabIndex = 40;
            RequiredAmount_Label.Values.Text = "*";
            RequiredAmount_Label.Visible = false;
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.Location = new Point(68, 49);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 39;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.Transparent;
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Center;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Location = new Point(12, 7);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(31, 30);
            Back_Button.TabIndex = 42;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // CreateBudget_Control
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(Back_Button);
            Controls.Add(RequiredAmount_Label);
            Controls.Add(RequiredName_Label);
            Controls.Add(CreateBudgetButton);
            Controls.Add(CreateBudgetInputFields_TableLayoutPanel);
            ForeColor = Color.Transparent;
            Name = "CreateBudget_Control";
            Size = new Size(360, 590);
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Button CreateBudgetButton;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel RequiredAmount_Label;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private Krypton.Toolkit.KryptonNumericUpDown Amount_NumUpDown;
        private Button Back_Button;
    }
}
