namespace Budget_Buddy_GUI
{
    partial class EntryActivity_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryActivity_Control));
            DeleteBudget_Button = new Button();
            BudgetName_Label = new Krypton.Toolkit.KryptonLabel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetFundsStatus_Panel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            ActivityName_Label = new Krypton.Toolkit.KryptonLabel();
            Delete_Button = new Button();
            ProjectedBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ActualBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityBalance_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            BudgetFundsStatus_Panel.SuspendLayout();
            ActivityFundStatus_TLPanel.SuspendLayout();
            SuspendLayout();
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
            DeleteBudget_Button.TabIndex = 39;
            DeleteBudget_Button.UseVisualStyleBackColor = false;
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
            BudgetName_Label.TabIndex = 37;
            BudgetName_Label.Values.Text = "Budget Name";
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Balance_Label.Location = new Point(29, 78);
            Balance_Label.MaximumSize = new Size(125, 19);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(59, 19);
            Balance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 34;
            Balance_Label.Values.Text = "Balance:";
            // 
            // BudgetBalanceAmount_Label
            // 
            BudgetBalanceAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BudgetBalanceAmount_Label.Location = new Point(94, 78);
            BudgetBalanceAmount_Label.MaximumSize = new Size(125, 19);
            BudgetBalanceAmount_Label.Name = "BudgetBalanceAmount_Label";
            BudgetBalanceAmount_Label.Size = new Size(36, 19);
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
            BudgetFundsStatus_Panel.Location = new Point(0, 0);
            BudgetFundsStatus_Panel.Name = "BudgetFundsStatus_Panel";
            BudgetFundsStatus_Panel.RowCount = 1;
            BudgetFundsStatus_Panel.Size = new Size(200, 100);
            BudgetFundsStatus_Panel.TabIndex = 0;
            // 
            // ActivityName_Label
            // 
            ActivityName_Label.AutoSize = false;
            ActivityName_Label.Enabled = false;
            ActivityName_Label.Location = new Point(0, 0);
            ActivityName_Label.Name = "ActivityName_Label";
            ActivityName_Label.Size = new Size(365, 62);
            ActivityName_Label.StateCommon.Padding = new Padding(10, 0, 30, 10);
            ActivityName_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActivityName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActivityName_Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            ActivityName_Label.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ActivityName_Label.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ActivityName_Label.StateNormal.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.EllipsisCharacter;
            ActivityName_Label.TabIndex = 37;
            ActivityName_Label.Values.Text = "Activity Name";
            ActivityName_Label.Click += ActivityName_Label_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(367, 0);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 32);
            Delete_Button.TabIndex = 39;
            Delete_Button.UseVisualStyleBackColor = false;
            // 
            // ProjectedBalanceAmount_Label
            // 
            ProjectedBalanceAmount_Label.Anchor = AnchorStyles.Left;
            ProjectedBalanceAmount_Label.Location = new Point(259, 3);
            ProjectedBalanceAmount_Label.MaximumSize = new Size(125, 19);
            ProjectedBalanceAmount_Label.Name = "ProjectedBalanceAmount_Label";
            ProjectedBalanceAmount_Label.Size = new Size(113, 18);
            ProjectedBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ProjectedBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ProjectedBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectedBalanceAmount_Label.TabIndex = 41;
            ProjectedBalanceAmount_Label.Values.Text = "/ 000000000.00";
            // 
            // ActualBalanceAmount_Label
            // 
            ActualBalanceAmount_Label.Anchor = AnchorStyles.Right;
            ActualBalanceAmount_Label.Location = new Point(149, 3);
            ActualBalanceAmount_Label.MaximumSize = new Size(125, 19);
            ActualBalanceAmount_Label.Name = "ActualBalanceAmount_Label";
            ActualBalanceAmount_Label.Size = new Size(104, 18);
            ActualBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ActualBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActualBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActualBalanceAmount_Label.TabIndex = 40;
            ActualBalanceAmount_Label.Values.Text = "000000000.00";
            ActualBalanceAmount_Label.Click += kryptonLabel1_Click;
            // 
            // ActivityBalance_Label
            // 
            ActivityBalance_Label.Anchor = AnchorStyles.Right;
            ActivityBalance_Label.Location = new Point(83, 3);
            ActivityBalance_Label.MaximumSize = new Size(125, 19);
            ActivityBalance_Label.Name = "ActivityBalance_Label";
            ActivityBalance_Label.Size = new Size(59, 18);
            ActivityBalance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            ActivityBalance_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActivityBalance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ActivityBalance_Label.TabIndex = 42;
            ActivityBalance_Label.Values.Text = "Balance:";
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 3;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.640625F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.359375F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            ActivityFundStatus_TLPanel.Controls.Add(ActivityBalance_Label, 0, 0);
            ActivityFundStatus_TLPanel.Controls.Add(ActualBalanceAmount_Label, 1, 0);
            ActivityFundStatus_TLPanel.Controls.Add(ProjectedBalanceAmount_Label, 2, 0);
            ActivityFundStatus_TLPanel.Dock = DockStyle.Bottom;
            ActivityFundStatus_TLPanel.Location = new Point(0, 38);
            ActivityFundStatus_TLPanel.Name = "ActivityFundStatus_TLPanel";
            ActivityFundStatus_TLPanel.RowCount = 1;
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActivityFundStatus_TLPanel.Size = new Size(393, 24);
            ActivityFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            ActivityFundStatus_TLPanel.StateCommon.Color2 = Color.White;
            ActivityFundStatus_TLPanel.TabIndex = 45;
            // 
            // ActivityEntry_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ActivityFundStatus_TLPanel);
            Controls.Add(Delete_Button);
            Controls.Add(ActivityName_Label);
            Name = "ActivityEntry_Control";
            Size = new Size(393, 62);
            Load += ActivityEntry_Control_Load;
            BudgetFundsStatus_Panel.ResumeLayout(false);
            BudgetFundsStatus_Panel.PerformLayout();
            ActivityFundStatus_TLPanel.ResumeLayout(false);
            ActivityFundStatus_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteBudget_Button;
        private Krypton.Toolkit.KryptonLabel BudgetName_Label;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Krypton.Toolkit.KryptonLabel BudgetBalanceAmount_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel BudgetFundsStatus_Panel;
        private Krypton.Toolkit.KryptonLabel ActivityName_Label;
        private Button Delete_Button;
        private Krypton.Toolkit.KryptonLabel ProjectedBalanceAmount_Label;
        private Krypton.Toolkit.KryptonLabel ActualBalanceAmount_Label;
        private Krypton.Toolkit.KryptonLabel ActivityBalance_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityFundStatus_TLPanel;
    }
}
