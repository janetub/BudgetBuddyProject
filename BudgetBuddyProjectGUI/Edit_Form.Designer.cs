namespace Budget_Buddy_GUI
{
    partial class Edit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Form));
            FormCanvas_TableLayoutPanel = new TableLayoutPanel();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Amount_NumUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            FormName_Label = new Label();
            Exit_Button = new Button();
            ConfirmEdit_Button = new Button();
            AppBar = new PictureBox();
            FormCanvas_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            SuspendLayout();
            // 
            // FormCanvas_TableLayoutPanel
            // 
            FormCanvas_TableLayoutPanel.CausesValidation = false;
            FormCanvas_TableLayoutPanel.ColumnCount = 1;
            FormCanvas_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FormCanvas_TableLayoutPanel.Controls.Add(Amount_Label, 0, 0);
            FormCanvas_TableLayoutPanel.Controls.Add(Amount_NumUpDown, 0, 1);
            FormCanvas_TableLayoutPanel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormCanvas_TableLayoutPanel.Location = new Point(0, 50);
            FormCanvas_TableLayoutPanel.Margin = new Padding(0);
            FormCanvas_TableLayoutPanel.Name = "FormCanvas_TableLayoutPanel";
            FormCanvas_TableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            FormCanvas_TableLayoutPanel.RowCount = 2;
            FormCanvas_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 43.75F));
            FormCanvas_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 56.25F));
            FormCanvas_TableLayoutPanel.Size = new Size(360, 160);
            FormCanvas_TableLayoutPanel.TabIndex = 52;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(23, 46);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(52, 21);
            Amount_Label.StateCommon.ShortText.Color1 = Color.Black;
            Amount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Label.TabIndex = 33;
            // 
            // Amount_NumUpDown
            // 
            Amount_NumUpDown.AllowDecimals = true;
            Amount_NumUpDown.AlwaysActive = false;
            Amount_NumUpDown.Cursor = Cursors.IBeam;
            Amount_NumUpDown.DecimalPlaces = 2;
            Amount_NumUpDown.Location = new Point(20, 70);
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
            // 
            // FormName_Label
            // 
            FormName_Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FormName_Label.AutoSize = true;
            FormName_Label.BackColor = Color.FromArgb(255, 218, 70);
            FormName_Label.CausesValidation = false;
            FormName_Label.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormName_Label.ForeColor = Color.Black;
            FormName_Label.Location = new Point(120, 15);
            FormName_Label.Name = "FormName_Label";
            FormName_Label.Size = new Size(92, 25);
            FormName_Label.TabIndex = 58;
            FormName_Label.Text = "Edit Form";
            FormName_Label.TextAlign = ContentAlignment.MiddleCenter;
            FormName_Label.MouseDown += AppBar_MouseDown;
            FormName_Label.MouseMove += AppBar_MouseMove;
            FormName_Label.MouseUp += AppBar_MouseUp;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.FromArgb(255, 218, 70);
            Exit_Button.BackgroundImage = (Image)resources.GetObject("Exit_Button.BackgroundImage");
            Exit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Exit_Button.CausesValidation = false;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Location = new Point(318, 10);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(31, 30);
            Exit_Button.TabIndex = 56;
            Exit_Button.UseVisualStyleBackColor = false;
            // 
            // ConfirmEdit_Button
            // 
            ConfirmEdit_Button.BackColor = Color.FromArgb(255, 218, 70);
            ConfirmEdit_Button.Dock = DockStyle.Bottom;
            ConfirmEdit_Button.FlatAppearance.BorderSize = 0;
            ConfirmEdit_Button.FlatStyle = FlatStyle.Flat;
            ConfirmEdit_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmEdit_Button.ForeColor = Color.Black;
            ConfirmEdit_Button.Location = new Point(0, 210);
            ConfirmEdit_Button.Name = "ConfirmEdit_Button";
            ConfirmEdit_Button.Size = new Size(360, 50);
            ConfirmEdit_Button.TabIndex = 53;
            ConfirmEdit_Button.Text = "Confirm Edit";
            ConfirmEdit_Button.UseVisualStyleBackColor = false;
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
            AppBar.MouseDown += AppBar_MouseDown;
            AppBar.MouseMove += AppBar_MouseMove;
            AppBar.MouseUp += AppBar_MouseUp;
            // 
            // Edit_Form
            // 
            AcceptButton = ConfirmEdit_Button;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            CancelButton = Exit_Button;
            CausesValidation = false;
            ClientSize = new Size(360, 260);
            Controls.Add(FormName_Label);
            Controls.Add(Exit_Button);
            Controls.Add(ConfirmEdit_Button);
            Controls.Add(AppBar);
            Controls.Add(FormCanvas_TableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddAmount_Form";
            FormCanvas_TableLayoutPanel.ResumeLayout(false);
            FormCanvas_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel FormCanvas_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonNumericUpDown Amount_NumUpDown;
        private Label FormName_Label;
        private Button Exit_Button;
        private Button ConfirmEdit_Button;
        private PictureBox AppBar;
    }
}