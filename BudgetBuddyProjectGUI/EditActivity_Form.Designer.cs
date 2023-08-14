namespace Budget_Buddy_GUI
{
    partial class EditActivity_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditActivity_Form));
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            Name_TextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            Description_Label = new Krypton.Toolkit.KryptonLabel();
            Description_RTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            Back_Button = new Button();
            RequiredName_Label = new Krypton.Toolkit.KryptonLabel();
            ConfirmEdit_Button = new Button();
            AppBar = new PictureBox();
            PageName_Label = new Label();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            SuspendLayout();
            // 
            // CreateBudgetInputFields_TableLayoutPanel
            // 
            CreateBudgetInputFields_TableLayoutPanel.CausesValidation = false;
            CreateBudgetInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateBudgetInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_Label, 0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Name_TextBox, 0, 1);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Description_Label, 0, 2);
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Description_RTextBox, 0, 3);
            CreateBudgetInputFields_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBudgetInputFields_TableLayoutPanel.Location = new Point(0, 50);
            CreateBudgetInputFields_TableLayoutPanel.Margin = new Padding(0);
            CreateBudgetInputFields_TableLayoutPanel.Name = "CreateBudgetInputFields_TableLayoutPanel";
            CreateBudgetInputFields_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            CreateBudgetInputFields_TableLayoutPanel.RowCount = 5;
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.8846169F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.1153831F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateBudgetInputFields_TableLayoutPanel.Size = new Size(360, 278);
            CreateBudgetInputFields_TableLayoutPanel.TabIndex = 52;
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.CausesValidation = false;
            Name_Label.Location = new Point(23, 29);
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
            Name_TextBox.Hint = "Enter activity name here";
            Name_TextBox.Location = new Point(23, 56);
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
            Name_TextBox.Validating += Name_TextBox_Validating;
            // 
            // Description_Label
            // 
            Description_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Description_Label.CausesValidation = false;
            Description_Label.Location = new Point(23, 123);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(96, 21);
            Description_Label.StateCommon.ShortText.Color1 = Color.Black;
            Description_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Description_Label.TabIndex = 36;
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
            Description_RTextBox.Location = new Point(23, 150);
            Description_RTextBox.Name = "Description_RTextBox";
            Description_RTextBox.Size = new Size(314, 93);
            Description_RTextBox.StateActive.Back.Color1 = Color.WhiteSmoke;
            Description_RTextBox.StateActive.Border.Color1 = Color.Black;
            Description_RTextBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            Description_RTextBox.StateCommon.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description_RTextBox.StateCommon.Content.Padding = new Padding(0);
            Description_RTextBox.TabIndex = 35;
            Description_RTextBox.Text = "";
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.FromArgb(255, 218, 70);
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Back_Button.CausesValidation = false;
            Back_Button.DialogResult = DialogResult.Cancel;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Location = new Point(318, 10);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(31, 30);
            Back_Button.TabIndex = 56;
            Back_Button.UseVisualStyleBackColor = false;
            // 
            // RequiredName_Label
            // 
            RequiredName_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequiredName_Label.CausesValidation = false;
            RequiredName_Label.Location = new Point(68, 81);
            RequiredName_Label.Name = "RequiredName_Label";
            RequiredName_Label.Size = new Size(18, 21);
            RequiredName_Label.StateCommon.ShortText.Color1 = Color.Red;
            RequiredName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequiredName_Label.TabIndex = 55;
            RequiredName_Label.Values.Text = "*";
            RequiredName_Label.Visible = false;
            // 
            // ConfirmEdit_Button
            // 
            ConfirmEdit_Button.BackColor = Color.FromArgb(255, 218, 70);
            ConfirmEdit_Button.Dock = DockStyle.Bottom;
            ConfirmEdit_Button.FlatAppearance.BorderSize = 0;
            ConfirmEdit_Button.FlatStyle = FlatStyle.Flat;
            ConfirmEdit_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmEdit_Button.ForeColor = Color.Black;
            ConfirmEdit_Button.Location = new Point(0, 331);
            ConfirmEdit_Button.Name = "ConfirmEdit_Button";
            ConfirmEdit_Button.Size = new Size(360, 50);
            ConfirmEdit_Button.TabIndex = 53;
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
            AppBar.TabIndex = 57;
            AppBar.TabStop = false;
            // 
            // PageName_Label
            // 
            PageName_Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageName_Label.AutoSize = true;
            PageName_Label.BackColor = Color.FromArgb(255, 218, 70);
            PageName_Label.CausesValidation = false;
            PageName_Label.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            PageName_Label.ForeColor = Color.Black;
            PageName_Label.Location = new Point(125, 12);
            PageName_Label.Name = "PageName_Label";
            PageName_Label.Size = new Size(111, 25);
            PageName_Label.TabIndex = 58;
            PageName_Label.Text = "Edit Activity";
            PageName_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditActivity_Form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(360, 381);
            Controls.Add(PageName_Label);
            Controls.Add(Back_Button);
            Controls.Add(RequiredName_Label);
            Controls.Add(ConfirmEdit_Button);
            Controls.Add(AppBar);
            Controls.Add(CreateBudgetInputFields_TableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditActivity_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditActivity_Form";
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private Krypton.Toolkit.KryptonMaskedTextBox Name_TextBox;
        private Button Back_Button;
        private Krypton.Toolkit.KryptonLabel RequiredName_Label;
        private Button ConfirmEdit_Button;
        private PictureBox AppBar;
        private Krypton.Toolkit.KryptonLabel Description_Label;
        private Krypton.Toolkit.KryptonRichTextBox Description_RTextBox;
        private Label PageName_Label;
    }
}