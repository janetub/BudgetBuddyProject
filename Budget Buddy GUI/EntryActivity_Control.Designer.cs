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
            ActivityName_Label = new Krypton.Toolkit.KryptonLabel();
            Delete_Button = new Button();
            ProjectedBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ActualBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
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
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(364, 3);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 30);
            Delete_Button.TabIndex = 39;
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // ProjectedBalanceAmount_Label
            // 
            ProjectedBalanceAmount_Label.Anchor = AnchorStyles.Left;
            ProjectedBalanceAmount_Label.Enabled = false;
            ProjectedBalanceAmount_Label.Location = new Point(244, 3);
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
            ActualBalanceAmount_Label.Enabled = false;
            ActualBalanceAmount_Label.Location = new Point(134, 3);
            ActualBalanceAmount_Label.MaximumSize = new Size(125, 19);
            ActualBalanceAmount_Label.Name = "ActualBalanceAmount_Label";
            ActualBalanceAmount_Label.Size = new Size(104, 18);
            ActualBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ActualBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActualBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActualBalanceAmount_Label.TabIndex = 40;
            ActualBalanceAmount_Label.Values.Text = "000000000.00";
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Right;
            Balance_Label.Enabled = false;
            Balance_Label.Location = new Point(66, 3);
            Balance_Label.MaximumSize = new Size(125, 19);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(59, 18);
            Balance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 42;
            Balance_Label.Values.Text = "Balance:";
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 3;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1120338F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8879662F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            ActivityFundStatus_TLPanel.Controls.Add(Balance_Label, 0, 0);
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
            // EntryActivity_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Delete_Button);
            Controls.Add(ActivityFundStatus_TLPanel);
            Controls.Add(ActivityName_Label);
            Name = "EntryActivity_Control";
            Size = new Size(393, 62);
            Load += ActivityEntry_Control_Load;
            Click += EntryActivity_Control_Click;
            ActivityFundStatus_TLPanel.ResumeLayout(false);
            ActivityFundStatus_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteBudget_Button;
        private Krypton.Toolkit.KryptonLabel ActivityName_Label;
        private Button Delete_Button;
        private Krypton.Toolkit.KryptonLabel ProjectedBalanceAmount_Label;
        private Krypton.Toolkit.KryptonLabel ActualBalanceAmount_Label;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityFundStatus_TLPanel;
    }
}
