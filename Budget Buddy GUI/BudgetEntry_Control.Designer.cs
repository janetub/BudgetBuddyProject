namespace Budget_Buddy_GUI
{
    partial class BudgetEntry_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetEntry_Control));
            BudgetName_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetFundsStatus_Panel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            DeleteBudget_Button = new Button();
            BudgetFundsStatus_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // BudgetName_Label
            // 
            BudgetName_Label.Dock = DockStyle.Fill;
            BudgetName_Label.Enabled = false;
            BudgetName_Label.Location = new Point(0, 0);
            BudgetName_Label.Name = "BudgetName_Label";
            BudgetName_Label.Size = new Size(393, 62);
            BudgetName_Label.StateCommon.Padding = new Padding(10, 0, 30, 10);
            BudgetName_Label.StateCommon.ShortText.Color1 = Color.Black;
            BudgetName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BudgetName_Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BudgetName_Label.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BudgetName_Label.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            BudgetName_Label.StateNormal.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.EllipsisCharacter;
            BudgetName_Label.TabIndex = 32;
            BudgetName_Label.Values.Text = "Budget Name";
            // 
            // BudgetBalanceAmount_Label
            // 
            BudgetBalanceAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BudgetBalanceAmount_Label.Location = new Point(94, 3);
            BudgetBalanceAmount_Label.MaximumSize = new Size(125, 19);
            BudgetBalanceAmount_Label.Name = "BudgetBalanceAmount_Label";
            BudgetBalanceAmount_Label.Size = new Size(36, 18);
            BudgetBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            BudgetBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            BudgetBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BudgetBalanceAmount_Label.TabIndex = 33;
            BudgetBalanceAmount_Label.Values.Text = "0.00";
            // 
            // BudgetFundsStatus_Panel
            // 
            BudgetFundsStatus_Panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BudgetFundsStatus_Panel.BackgroundImage = (Image)resources.GetObject("BudgetFundsStatus_Panel.BackgroundImage");
            BudgetFundsStatus_Panel.BackgroundImageLayout = ImageLayout.None;
            BudgetFundsStatus_Panel.ColumnCount = 2;
            BudgetFundsStatus_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5F));
            BudgetFundsStatus_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5F));
            BudgetFundsStatus_Panel.Controls.Add(Balance_Label, 0, 0);
            BudgetFundsStatus_Panel.Controls.Add(BudgetBalanceAmount_Label, 1, 0);
            BudgetFundsStatus_Panel.Enabled = false;
            BudgetFundsStatus_Panel.Location = new Point(193, 38);
            BudgetFundsStatus_Panel.Name = "BudgetFundsStatus_Panel";
            BudgetFundsStatus_Panel.RowCount = 1;
            BudgetFundsStatus_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BudgetFundsStatus_Panel.Size = new Size(200, 24);
            BudgetFundsStatus_Panel.StateCommon.Color1 = Color.White;
            BudgetFundsStatus_Panel.TabIndex = 34;
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Balance_Label.Location = new Point(29, 3);
            Balance_Label.MaximumSize = new Size(125, 19);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(59, 18);
            Balance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 34;
            Balance_Label.Values.Text = "Balance:";
            // 
            // DeleteBudget_Button
            // 
            DeleteBudget_Button.BackColor = Color.Transparent;
            DeleteBudget_Button.BackgroundImage = Properties.Resources.delete3;
            DeleteBudget_Button.BackgroundImageLayout = ImageLayout.Center;
            DeleteBudget_Button.Dock = DockStyle.Right;
            DeleteBudget_Button.FlatAppearance.BorderSize = 0;
            DeleteBudget_Button.FlatStyle = FlatStyle.Flat;
            DeleteBudget_Button.Location = new Point(367, 0);
            DeleteBudget_Button.Name = "DeleteBudget_Button";
            DeleteBudget_Button.Size = new Size(26, 62);
            DeleteBudget_Button.TabIndex = 36;
            DeleteBudget_Button.UseVisualStyleBackColor = false;
            DeleteBudget_Button.Click += DeleteBudget_Button_Click;
            // 
            // BudgetEntry_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(BudgetFundsStatus_Panel);
            Controls.Add(DeleteBudget_Button);
            Controls.Add(BudgetName_Label);
            Name = "BudgetEntry_Control";
            Size = new Size(393, 62);
            Click += BudgetEntry_Control_Click;
            BudgetFundsStatus_Panel.ResumeLayout(false);
            BudgetFundsStatus_Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel BudgetName_Label;
        private Krypton.Toolkit.KryptonLabel BudgetBalanceAmount_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel BudgetFundsStatus_Panel;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Button DeleteBudget_Button;
    }
}
