namespace Budget_Buddy_GUI
{
    partial class CreateBudgetActivity_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBudgetActivity_Control));
            CreateActivity_Button = new Button();
            RequiredProjectedAmount_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            CreateActivityInputFields_TableLayoutPanel = new TableLayoutPanel();
            ActivityType_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityType_ComboBox = new Krypton.Toolkit.KryptonComboBox();
            ProjectedAmount_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            Description_Label = new Krypton.Toolkit.KryptonLabel();
            Description_RTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            ProjectedAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredActivityType_Label = new Krypton.Toolkit.KryptonLabel();
            Back_Button = new Button();
            CreateActivityInputFields_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActivityType_ComboBox).BeginInit();
            SuspendLayout();
            // 
            // CreateActivity_Button
            // 
            CreateActivity_Button.BackColor = Color.FromArgb(255, 198, 50);
            CreateActivity_Button.Dock = DockStyle.Bottom;
            CreateActivity_Button.FlatAppearance.BorderSize = 0;
            CreateActivity_Button.FlatStyle = FlatStyle.Flat;
            CreateActivity_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateActivity_Button.ForeColor = Color.Black;
            CreateActivity_Button.Location = new Point(0, 540);
            CreateActivity_Button.Name = "CreateActivity_Button";
            CreateActivity_Button.Size = new Size(360, 50);
            CreateActivity_Button.TabIndex = 5;
            CreateActivity_Button.Text = "Create Activity";
            CreateActivity_Button.UseVisualStyleBackColor = false;
            CreateActivity_Button.Click += CreateActivity_Button_Click;
            // 
            // RequiredProjectedAmount_Label
            // 
            RequiredProjectedAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredProjectedAmount_Label.Enabled = false;
            RequiredProjectedAmount_Label.Location = new Point(155, 244);
            RequiredProjectedAmount_Label.Name = "RequiredProjectedAmount_Label";
            RequiredProjectedAmount_Label.Size = new Size(18, 21);
            RequiredProjectedAmount_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredProjectedAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredProjectedAmount_Label.TabIndex = 41;
            RequiredProjectedAmount_Label.Values.Text = "*";
            RequiredProjectedAmount_Label.Visible = false;
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.Enabled = false;
            RequiredName_Label.Location = new Point(68, 137);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 42;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // CreateActivityInputFields_TableLayoutPanel
            // 
            CreateActivityInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateActivityInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(ActivityType_Label, 0, 0);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(ActivityType_ComboBox, 0, 1);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(ProjectedAmount_NumUpDown, 0, 5);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(Description_Label, 0, 6);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(Description_RTextBox, 0, 7);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(Name_TextBox, 0, 3);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(ProjectedAmount_Label, 0, 4);
            CreateActivityInputFields_TableLayoutPanel.Controls.Add(Name_Label, 0, 2);
            CreateActivityInputFields_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateActivityInputFields_TableLayoutPanel.Location = new Point(0, 0);
            CreateActivityInputFields_TableLayoutPanel.Margin = new Padding(0);
            CreateActivityInputFields_TableLayoutPanel.Name = "CreateActivityInputFields_TableLayoutPanel";
            CreateActivityInputFields_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            CreateActivityInputFields_TableLayoutPanel.RowCount = 8;
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 43.47826F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 56.52174F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateActivityInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateActivityInputFields_TableLayoutPanel.Size = new Size(360, 540);
            CreateActivityInputFields_TableLayoutPanel.TabIndex = 43;
            // 
            // ActivityType_Label
            // 
            ActivityType_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ActivityType_Label.Location = new Point(23, 46);
            ActivityType_Label.Name = "ActivityType_Label";
            ActivityType_Label.Size = new Size(108, 21);
            ActivityType_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActivityType_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActivityType_Label.TabIndex = 44;
            ActivityType_Label.Values.Text = "Activity Type";
            // 
            // ActivityType_ComboBox
            // 
            ActivityType_ComboBox.AlwaysActive = false;
            ActivityType_ComboBox.CornerRoundingRadius = -1F;
            ActivityType_ComboBox.CueHint.Color1 = Color.DimGray;
            ActivityType_ComboBox.CueHint.CueHintText = "Select activity type";
            ActivityType_ComboBox.CueHint.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ActivityType_ComboBox.CueHint.Padding = new Padding(0);
            ActivityType_ComboBox.Cursor = Cursors.IBeam;
            ActivityType_ComboBox.DropButtonStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            ActivityType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ActivityType_ComboBox.DropDownWidth = 121;
            ActivityType_ComboBox.IntegralHeight = false;
            ActivityType_ComboBox.ItemStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            ActivityType_ComboBox.Location = new Point(23, 73);
            ActivityType_ComboBox.Name = "ActivityType_ComboBox";
            ActivityType_ComboBox.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            ActivityType_ComboBox.Size = new Size(314, 22);
            ActivityType_ComboBox.StateActive.ComboBox.Back.Color1 = Color.WhiteSmoke;
            ActivityType_ComboBox.StateCommon.ComboBox.Border.Color1 = Color.Black;
            ActivityType_ComboBox.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ActivityType_ComboBox.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            ActivityType_ComboBox.StateCommon.ComboBox.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ActivityType_ComboBox.StateCommon.ComboBox.Content.Padding = new Padding(0);
            ActivityType_ComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ActivityType_ComboBox.TabIndex = 1;
            ActivityType_ComboBox.KeyDown += ValidateField_KeyDown;
            ActivityType_ComboBox.Validating += ActivityType_ComboBox_Validating;
            // 
            // ProjectedAmount_NumUpDown
            // 
            ProjectedAmount_NumUpDown.AllowDecimals = true;
            ProjectedAmount_NumUpDown.AlwaysActive = false;
            ProjectedAmount_NumUpDown.Cursor = Cursors.IBeam;
            ProjectedAmount_NumUpDown.DecimalPlaces = 2;
            ProjectedAmount_NumUpDown.Location = new Point(20, 265);
            ProjectedAmount_NumUpDown.Margin = new Padding(0);
            ProjectedAmount_NumUpDown.Maximum = new decimal(new int[] { -727379969, 232, 0, 131072 });
            ProjectedAmount_NumUpDown.Name = "ProjectedAmount_NumUpDown";
            ProjectedAmount_NumUpDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            ProjectedAmount_NumUpDown.Size = new Size(317, 23);
            ProjectedAmount_NumUpDown.StateActive.Back.Color1 = Color.WhiteSmoke;
            ProjectedAmount_NumUpDown.StateActive.Content.Color1 = Color.Black;
            ProjectedAmount_NumUpDown.StateActive.Content.Padding = new Padding(0);
            ProjectedAmount_NumUpDown.StateCommon.Back.Color1 = Color.White;
            ProjectedAmount_NumUpDown.StateCommon.Border.Color1 = Color.Black;
            ProjectedAmount_NumUpDown.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            ProjectedAmount_NumUpDown.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectedAmount_NumUpDown.StateCommon.Content.Padding = new Padding(5);
            ProjectedAmount_NumUpDown.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ProjectedAmount_NumUpDown.TabIndex = 3;
            ProjectedAmount_NumUpDown.ThousandsSeparator = true;
            ProjectedAmount_NumUpDown.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            ProjectedAmount_NumUpDown.UseMnemonic = false;
            ProjectedAmount_NumUpDown.ValueChanged += ProjectedAmount_NumUpDown_ValueChanged;
            ProjectedAmount_NumUpDown.KeyDown += ValidateField_KeyDown;
            // 
            // Description_Label
            // 
            Description_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Description_Label.Location = new Point(23, 327);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(96, 21);
            Description_Label.StateCommon.ShortText.Color1 = Color.Black;
            Description_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Description_Label.TabIndex = 34;
            Description_Label.Target = Description_Label;
            Description_Label.Values.Text = "Description";
            // 
            // Description_RTextBox
            // 
            Description_RTextBox.AlwaysActive = false;
            Description_RTextBox.CueHint.Color1 = Color.DimGray;
            Description_RTextBox.CueHint.CueHintText = "Enter description here";
            Description_RTextBox.CueHint.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description_RTextBox.CueHint.Padding = new Padding(5);
            Description_RTextBox.Location = new Point(23, 354);
            Description_RTextBox.Name = "Description_RTextBox";
            Description_RTextBox.Size = new Size(314, 108);
            Description_RTextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Description_RTextBox.StateActive.Border.Color1 = Color.Black;
            Description_RTextBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Description_RTextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description_RTextBox.StateCommon.Content.Padding = new Padding(0);
            Description_RTextBox.TabIndex = 4;
            Description_RTextBox.Text = "";
            Description_RTextBox.KeyDown += ValidateField_KeyDown;
            // 
            // Name_TextBox
            // 
            Name_TextBox.AlwaysActive = false;
            Name_TextBox.AsciiOnly = true;
            Name_TextBox.Cursor = Cursors.IBeam;
            Name_TextBox.Hint = "Enter activity name here";
            Name_TextBox.Location = new Point(23, 162);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(314, 29);
            Name_TextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Name_TextBox.StateActive.Content.Color1 = Color.Black;
            Name_TextBox.StateCommon.Back.Color1 = Color.White;
            Name_TextBox.StateCommon.Border.Color1 = Color.Black;
            Name_TextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Name_TextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name_TextBox.StateCommon.Content.Padding = new Padding(5);
            Name_TextBox.TabIndex = 2;
            Name_TextBox.KeyDown += ValidateField_KeyDown;
            Name_TextBox.Validating += Name_TextBox_Validating;
            // 
            // ProjectedAmount_Label
            // 
            ProjectedAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ProjectedAmount_Label.Location = new Point(23, 241);
            ProjectedAmount_Label.Name = "ProjectedAmount_Label";
            ProjectedAmount_Label.Size = new Size(145, 21);
            ProjectedAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ProjectedAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectedAmount_Label.TabIndex = 33;
            ProjectedAmount_Label.Target = ProjectedAmount_NumUpDown;
            ProjectedAmount_Label.Values.Text = "Projected Amount";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(23, 135);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(54, 21);
            Name_Label.StateCommon.ShortText.Color1 = Color.Black;
            Name_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.TabIndex = 0;
            Name_Label.Values.Text = "Name";
            // 
            // RequiredActivityType_Label
            // 
            RequiredActivityType_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredActivityType_Label.Enabled = false;
            RequiredActivityType_Label.Location = new Point(120, 49);
            RequiredActivityType_Label.Name = "RequiredActivityType_Label";
            RequiredActivityType_Label.Size = new Size(18, 21);
            RequiredActivityType_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredActivityType_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredActivityType_Label.TabIndex = 44;
            RequiredActivityType_Label.Values.Text = "*";
            RequiredActivityType_Label.Visible = false;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.Transparent;
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Center;
            Back_Button.CausesValidation = false;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Location = new Point(12, 7);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(31, 30);
            Back_Button.TabIndex = 45;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // CreateBudgetActivity_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Back_Button);
            Controls.Add(RequiredActivityType_Label);
            Controls.Add(RequiredName_Label);
            Controls.Add(RequiredProjectedAmount_Label);
            Controls.Add(CreateActivity_Button);
            Controls.Add(CreateActivityInputFields_TableLayoutPanel);
            Name = "CreateBudgetActivity_Control";
            Size = new Size(360, 590);
            CreateActivityInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateActivityInputFields_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ActivityType_ComboBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateActivity_Button;
        private Krypton.Toolkit.KryptonLabel RequiredProjectedAmount_Label;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private TableLayoutPanel CreateActivityInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonNumericUpDown ProjectedAmount_NumUpDown;
        private Krypton.Toolkit.KryptonLabel Description_Label;
        private Krypton.Toolkit.KryptonRichTextBox Description_RTextBox;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Krypton.Toolkit.KryptonLabel ProjectedAmount_Label;
        private Krypton.Toolkit.KryptonComboBox ActivityType_ComboBox;
        private Krypton.Toolkit.KryptonLabel ActivityType_Label;
        private Krypton.Toolkit.KryptonLabel RequiredActivityType_Label;
        private Button Back_Button;
    }
}
