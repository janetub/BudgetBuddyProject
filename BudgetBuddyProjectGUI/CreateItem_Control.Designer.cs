namespace Budget_Buddy_GUI
{
    partial class CreateItem_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateItem_Control));
            AddItem_Button = new Button();
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Tags_Label = new Krypton.Toolkit.KryptonLabel();
            Cost_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            Cost_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            Quantity_Label = new Krypton.Toolkit.KryptonLabel();
            Quantity_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            Tags_ComboBox = new Krypton.Toolkit.KryptonComboBox();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredCost_Label = new Krypton.Toolkit.KryptonLabel();
            Back_Button = new Button();
            RequiredQuantity_Label = new Krypton.Toolkit.KryptonLabel();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tags_ComboBox).BeginInit();
            SuspendLayout();
            // 
            // AddItem_Button
            // 
            AddItem_Button.BackColor = Color.FromArgb(255, 198, 50);
            AddItem_Button.Dock = DockStyle.Bottom;
            AddItem_Button.FlatAppearance.BorderSize = 0;
            AddItem_Button.FlatStyle = FlatStyle.Flat;
            AddItem_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddItem_Button.ForeColor = Color.Black;
            AddItem_Button.Location = new Point(0, 540);
            AddItem_Button.Name = "AddItem_Button";
            AddItem_Button.Size = new Size(360, 50);
            AddItem_Button.TabIndex = 1;
            AddItem_Button.Text = "Add Item";
            AddItem_Button.UseVisualStyleBackColor = false;
            AddItem_Button.Click += AddItem_Button_Click;
            // 
            // CreateBudgetInputFields_TableLayoutPanel
            // 
            CreateBudgetInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateBudgetInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Tags_Label, 0, 7);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Cost_Label, 0, 2);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_Label, 0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_TextBox, 0, 1);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Cost_NumUpDown, 0, 3);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Quantity_Label, 0, 4);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Quantity_NumUpDown, 0, 5);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Tags_ComboBox, 0, 8);
            CreateBudgetInputFields_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetInputFields_TableLayoutPanel.Location = new Point(0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Margin = new Padding(0);
            CreateBudgetInputFields_TableLayoutPanel.Name = "CreateBudgetInputFields_TableLayoutPanel";
            CreateBudgetInputFields_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            CreateBudgetInputFields_TableLayoutPanel.RowCount = 9;
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3055573F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6944427F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.Size = new Size(360, 540);
            CreateBudgetInputFields_TableLayoutPanel.TabIndex = 2;
            // 
            // Tags_Label
            // 
            Tags_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Tags_Label.Location = new Point(23, 378);
            Tags_Label.Name = "Tags_Label";
            Tags_Label.Size = new Size(48, 21);
            Tags_Label.StateCommon.ShortText.Color1 = Color.Black;
            Tags_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Tags_Label.TabIndex = 37;
            Tags_Label.Values.Text = "Tags";
            // 
            // Cost_Label
            // 
            Cost_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Cost_Label.Location = new Point(23, 168);
            Cost_Label.Name = "Cost_Label";
            Cost_Label.Size = new Size(46, 21);
            Cost_Label.StateCommon.ShortText.Color1 = Color.Black;
            Cost_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cost_Label.TabIndex = 33;
            Cost_Label.Values.Text = "Cost";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(23, 47);
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
            Name_TextBox.Hint = "Enter item name here";
            Name_TextBox.Location = new Point(23, 74);
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
            Name_TextBox.KeyDown += ValidateField_KeyDown;
            Name_TextBox.Validating += Name_TextBox_Validating;
            // 
            // Cost_NumUpDown
            // 
            Cost_NumUpDown.AllowDecimals = true;
            Cost_NumUpDown.AlwaysActive = false;
            Cost_NumUpDown.Cursor = Cursors.IBeam;
            Cost_NumUpDown.DecimalPlaces = 2;
            Cost_NumUpDown.Location = new Point(20, 192);
            Cost_NumUpDown.Margin = new Padding(0);
            Cost_NumUpDown.Maximum = new decimal(new int[] { 99999999, 0, 0, 131072 });
            Cost_NumUpDown.Name = "Cost_NumUpDown";
            Cost_NumUpDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Cost_NumUpDown.Size = new Size(317, 23);
            Cost_NumUpDown.StateActive.Back.Color1 = Color.WhiteSmoke;
            Cost_NumUpDown.StateActive.Content.Color1 = Color.Black;
            Cost_NumUpDown.StateActive.Content.Padding = new Padding(0);
            Cost_NumUpDown.StateCommon.Back.Color1 = Color.White;
            Cost_NumUpDown.StateCommon.Border.Color1 = Color.Black;
            Cost_NumUpDown.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Cost_NumUpDown.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cost_NumUpDown.StateCommon.Content.Padding = new Padding(5);
            Cost_NumUpDown.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Cost_NumUpDown.TabIndex = 2;
            Cost_NumUpDown.ThousandsSeparator = true;
            Cost_NumUpDown.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            Cost_NumUpDown.UseMnemonic = false;
            Cost_NumUpDown.KeyDown += ValidateField_KeyDown;
            // 
            // Quantity_Label
            // 
            Quantity_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Quantity_Label.Location = new Point(23, 272);
            Quantity_Label.Name = "Quantity_Label";
            Quantity_Label.Size = new Size(74, 21);
            Quantity_Label.StateCommon.ShortText.Color1 = Color.Black;
            Quantity_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_Label.TabIndex = 35;
            Quantity_Label.Values.Text = "Quantity";
            // 
            // Quantity_NumUpDown
            // 
            Quantity_NumUpDown.AlwaysActive = false;
            Quantity_NumUpDown.Cursor = Cursors.IBeam;
            Quantity_NumUpDown.Location = new Point(20, 296);
            Quantity_NumUpDown.Margin = new Padding(0);
            Quantity_NumUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            Quantity_NumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Quantity_NumUpDown.Name = "Quantity_NumUpDown";
            Quantity_NumUpDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Quantity_NumUpDown.Size = new Size(317, 23);
            Quantity_NumUpDown.StateActive.Back.Color1 = Color.WhiteSmoke;
            Quantity_NumUpDown.StateActive.Content.Color1 = Color.Black;
            Quantity_NumUpDown.StateActive.Content.Padding = new Padding(0);
            Quantity_NumUpDown.StateCommon.Back.Color1 = Color.White;
            Quantity_NumUpDown.StateCommon.Border.Color1 = Color.Black;
            Quantity_NumUpDown.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Quantity_NumUpDown.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity_NumUpDown.StateCommon.Content.Padding = new Padding(5);
            Quantity_NumUpDown.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Quantity_NumUpDown.TabIndex = 3;
            Quantity_NumUpDown.ThousandsSeparator = true;
            Quantity_NumUpDown.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            Quantity_NumUpDown.UseMnemonic = false;
            Quantity_NumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Quantity_NumUpDown.KeyDown += ValidateField_KeyDown;
            // 
            // Tags_ComboBox
            // 
            Tags_ComboBox.AlwaysActive = false;
            Tags_ComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Tags_ComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            Tags_ComboBox.CornerRoundingRadius = -1F;
            Tags_ComboBox.CueHint.Color1 = Color.DimGray;
            Tags_ComboBox.CueHint.CueHintText = "Enter tags here";
            Tags_ComboBox.CueHint.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Tags_ComboBox.CueHint.Padding = new Padding(0);
            Tags_ComboBox.Cursor = Cursors.IBeam;
            Tags_ComboBox.DropDownWidth = 121;
            Tags_ComboBox.IntegralHeight = false;
            Tags_ComboBox.ItemStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            Tags_ComboBox.Location = new Point(23, 405);
            Tags_ComboBox.MaxDropDownItems = 6;
            Tags_ComboBox.Name = "Tags_ComboBox";
            Tags_ComboBox.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Tags_ComboBox.Size = new Size(314, 22);
            Tags_ComboBox.StateActive.ComboBox.Back.Color1 = Color.WhiteSmoke;
            Tags_ComboBox.StateCommon.ComboBox.Border.Color1 = Color.Black;
            Tags_ComboBox.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            Tags_ComboBox.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Tags_ComboBox.StateCommon.ComboBox.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Tags_ComboBox.StateCommon.ComboBox.Content.Padding = new Padding(0);
            Tags_ComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Tags_ComboBox.TabIndex = 4;
            Tags_ComboBox.KeyDown += Tags_ComboBox_KeyDown;
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.Location = new Point(68, 49);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 44;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // RequiredCost_Label
            // 
            RequiredCost_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredCost_Label.Location = new Point(64, 170);
            RequiredCost_Label.Name = "RequiredCost_Label";
            RequiredCost_Label.Size = new Size(18, 21);
            RequiredCost_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredCost_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredCost_Label.TabIndex = 45;
            RequiredCost_Label.Values.Text = "*";
            RequiredCost_Label.Visible = false;
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
            Back_Button.TabIndex = 46;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // RequiredQuantity_Label
            // 
            RequiredQuantity_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredQuantity_Label.Location = new Point(88, 272);
            RequiredQuantity_Label.Name = "RequiredQuantity_Label";
            RequiredQuantity_Label.Size = new Size(18, 21);
            RequiredQuantity_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredQuantity_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredQuantity_Label.TabIndex = 47;
            RequiredQuantity_Label.Values.Text = "*";
            RequiredQuantity_Label.Visible = false;
            // 
            // CreateItem_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(RequiredQuantity_Label);
            Controls.Add(Back_Button);
            Controls.Add(RequiredCost_Label);
            Controls.Add(RequiredName_Label);
            Controls.Add(CreateBudgetInputFields_TableLayoutPanel);
            Controls.Add(AddItem_Button);
            Name = "CreateItem_Control";
            Size = new Size(360, 590);
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tags_ComboBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddItem_Button;
        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Cost_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Krypton.Toolkit.KryptonNumericUpDown Cost_NumUpDown;
        private Krypton.Toolkit.KryptonLabel Tags_Label;
        private Krypton.Toolkit.KryptonLabel Quantity_Label;
        private Krypton.Toolkit.KryptonNumericUpDown Quantity_NumUpDown;
        private Krypton.Toolkit.KryptonComboBox Tags_ComboBox;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private Krypton.Toolkit.KryptonLabel RequiredCost_Label;
        private Button Back_Button;
        private Krypton.Toolkit.KryptonLabel RequiredQuantity_Label;
    }
}
