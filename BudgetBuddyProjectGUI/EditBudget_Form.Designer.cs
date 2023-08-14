namespace Budget_Buddy_GUI
{
    partial class EditBudget_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBudget_Form));
            Amount_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            Back_Button = new Button();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            RequiredAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ConfirmEdit_Button = new Button();
            AppBar = new PictureBox();
            PageName_Label = new Label();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            SuspendLayout();
            // 
            // Amount_NumUpDown
            // 
            Amount_NumUpDown.AllowDecimals = true;
            Amount_NumUpDown.AlwaysActive = false;
            Amount_NumUpDown.Cursor = Cursors.IBeam;
            Amount_NumUpDown.DecimalPlaces = 2;
            Amount_NumUpDown.Location = new Point(20, 121);
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
            Amount_NumUpDown.KeyDown += Confirm_KeyDown;
            // 
            // CreateBudgetInputFields_TableLayoutPanel
            // 
            CreateBudgetInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateBudgetInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Amount_Label, 0, 2);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_Label, 0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_TextBox, 0, 1);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Amount_NumUpDown, 0, 3);
            CreateBudgetInputFields_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetInputFields_TableLayoutPanel.Location = new Point(0, 50);
            CreateBudgetInputFields_TableLayoutPanel.Margin = new Padding(0);
            CreateBudgetInputFields_TableLayoutPanel.Name = "CreateBudgetInputFields_TableLayoutPanel";
            CreateBudgetInputFields_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            CreateBudgetInputFields_TableLayoutPanel.RowCount = 4;
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55.8441544F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1558456F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.Size = new Size(360, 167);
            CreateBudgetInputFields_TableLayoutPanel.TabIndex = 43;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(23, 97);
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
            Name_Label.Location = new Point(23, 20);
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
            Name_TextBox.Location = new Point(23, 47);
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
            Name_TextBox.KeyDown += Confirm_KeyDown;
            Name_TextBox.Validating += Name_TextBox_Validating;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.FromArgb(255, 218, 70);
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Back_Button.DialogResult = DialogResult.Cancel;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Location = new Point(318, 10);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(31, 30);
            Back_Button.TabIndex = 47;
            Back_Button.UseVisualStyleBackColor = false;
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.Location = new Point(68, 68);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 46;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // RequiredAmount_Label
            // 
            RequiredAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredAmount_Label.Location = new Point(84, 146);
            RequiredAmount_Label.Name = "RequiredAmount_Label";
            RequiredAmount_Label.Size = new Size(18, 21);
            RequiredAmount_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredAmount_Label.TabIndex = 45;
            RequiredAmount_Label.Values.Text = "*";
            RequiredAmount_Label.Visible = false;
            // 
            // ConfirmEdit_Button
            // 
            ConfirmEdit_Button.BackColor = Color.FromArgb(255, 218, 70);
            ConfirmEdit_Button.Dock = DockStyle.Bottom;
            ConfirmEdit_Button.FlatAppearance.BorderSize = 0;
            ConfirmEdit_Button.FlatStyle = FlatStyle.Flat;
            ConfirmEdit_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmEdit_Button.ForeColor = Color.Black;
            ConfirmEdit_Button.Location = new Point(0, 222);
            ConfirmEdit_Button.Name = "ConfirmEdit_Button";
            ConfirmEdit_Button.Size = new Size(360, 50);
            ConfirmEdit_Button.TabIndex = 44;
            ConfirmEdit_Button.Text = "Confirm Edit";
            ConfirmEdit_Button.UseVisualStyleBackColor = false;
            ConfirmEdit_Button.Click += ConfirmEdit_Button_Click;
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 218, 70);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 50;
            AppBar.TabStop = false;
            AppBar.MouseDown += AppBar_MouseDown;
            AppBar.MouseMove += AppBar_MouseMove;
            AppBar.MouseUp += AppBar_MouseUp;
            // 
            // PageName_Label
            // 
            PageName_Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageName_Label.AutoSize = true;
            PageName_Label.BackColor = Color.FromArgb(255, 218, 70);
            PageName_Label.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            PageName_Label.ForeColor = Color.Black;
            PageName_Label.Location = new Point(125, 12);
            PageName_Label.Name = "PageName_Label";
            PageName_Label.Size = new Size(110, 25);
            PageName_Label.TabIndex = 51;
            PageName_Label.Text = "Edit Budget";
            PageName_Label.TextAlign = ContentAlignment.MiddleCenter;
            PageName_Label.MouseDown += AppBar_MouseDown;
            PageName_Label.MouseMove += AppBar_MouseMove;
            PageName_Label.MouseUp += AppBar_MouseUp;
            // 
            // EditBudget_Form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 272);
            Controls.Add(PageName_Label);
            Controls.Add(Back_Button);
            Controls.Add(RequiredName_Label);
            Controls.Add(RequiredAmount_Label);
            Controls.Add(ConfirmEdit_Button);
            Controls.Add(CreateBudgetInputFields_TableLayoutPanel);
            Controls.Add(AppBar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBudget_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditBudget_Form";
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonNumericUpDown Amount_NumUpDown;
        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Button Back_Button;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private Krypton.Toolkit.KryptonLabel RequiredAmount_Label;
        private Button ConfirmEdit_Button;
        private PictureBox AppBar;
        private Label PageName_Label;
    }
}