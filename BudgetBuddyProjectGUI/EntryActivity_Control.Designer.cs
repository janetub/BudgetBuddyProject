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
            Delete_Button = new Button();
            ProjectedBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            ActualBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetActivityType_Label = new Krypton.Toolkit.KryptonLabel();
            ActivityName_Label = new Krypton.Toolkit.KryptonWrapLabel();
            ActivityFundStatus_TLPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(321, 3);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 30);
            Delete_Button.TabIndex = 39;
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // ProjectedBalanceAmount_Label
            // 
            ProjectedBalanceAmount_Label.Anchor = AnchorStyles.Left;
            ProjectedBalanceAmount_Label.Location = new Point(229, 4);
            ProjectedBalanceAmount_Label.Margin = new Padding(0);
            ProjectedBalanceAmount_Label.Name = "ProjectedBalanceAmount_Label";
            ProjectedBalanceAmount_Label.Size = new Size(121, 20);
            ProjectedBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ProjectedBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ProjectedBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectedBalanceAmount_Label.TabIndex = 41;
            ProjectedBalanceAmount_Label.Values.Text = "till 9,999,999,999.99";
            ProjectedBalanceAmount_Label.Click += EntryActivity_Control_Click;
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Right;
            Balance_Label.AutoSize = false;
            Balance_Label.Location = new Point(17, 4);
            Balance_Label.Margin = new Padding(0);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(71, 19);
            Balance_Label.StateCommon.Padding = new Padding(0);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 42;
            Balance_Label.Values.Text = "Balance:";
            Balance_Label.Click += EntryActivity_Control_Click;
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 4;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.61904764F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9523811F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.42857F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            ActivityFundStatus_TLPanel.Controls.Add(ActualBalanceAmount_Label, 2, 0);
            ActivityFundStatus_TLPanel.Controls.Add(BudgetActivityType_Label, 0, 0);
            ActivityFundStatus_TLPanel.Controls.Add(Balance_Label, 1, 0);
            ActivityFundStatus_TLPanel.Controls.Add(ProjectedBalanceAmount_Label, 3, 0);
            ActivityFundStatus_TLPanel.Dock = DockStyle.Bottom;
            ActivityFundStatus_TLPanel.Location = new Point(0, 52);
            ActivityFundStatus_TLPanel.Name = "ActivityFundStatus_TLPanel";
            ActivityFundStatus_TLPanel.RowCount = 1;
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ActivityFundStatus_TLPanel.Size = new Size(350, 28);
            ActivityFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            ActivityFundStatus_TLPanel.StateCommon.Color2 = Color.White;
            ActivityFundStatus_TLPanel.TabIndex = 45;
            ActivityFundStatus_TLPanel.Click += EntryActivity_Control_Click;
            // 
            // ActualBalanceAmount_Label
            // 
            ActualBalanceAmount_Label.Anchor = AnchorStyles.Right;
            ActualBalanceAmount_Label.Location = new Point(103, 4);
            ActualBalanceAmount_Label.Margin = new Padding(0);
            ActualBalanceAmount_Label.Name = "ActualBalanceAmount_Label";
            ActualBalanceAmount_Label.Size = new Size(126, 19);
            ActualBalanceAmount_Label.StateCommon.Padding = new Padding(0);
            ActualBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActualBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActualBalanceAmount_Label.TabIndex = 46;
            ActualBalanceAmount_Label.Values.Text = "9,999,999,999.99";
            ActualBalanceAmount_Label.Click += EntryActivity_Control_Click;
            // 
            // BudgetActivityType_Label
            // 
            BudgetActivityType_Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BudgetActivityType_Label.AutoSize = false;
            BudgetActivityType_Label.Location = new Point(3, 4);
            BudgetActivityType_Label.MaximumSize = new Size(125, 19);
            BudgetActivityType_Label.Name = "BudgetActivityType_Label";
            BudgetActivityType_Label.Size = new Size(11, 19);
            BudgetActivityType_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            BudgetActivityType_Label.StateCommon.ShortText.Color1 = Color.Gray;
            BudgetActivityType_Label.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BudgetActivityType_Label.TabIndex = 46;
            BudgetActivityType_Label.Values.Text = "Expense";
            BudgetActivityType_Label.Click += EntryActivity_Control_Click;
            // 
            // ActivityName_Label
            // 
            ActivityName_Label.AutoEllipsis = true;
            ActivityName_Label.AutoSize = false;
            ActivityName_Label.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActivityName_Label.ForeColor = Color.Black;
            ActivityName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            ActivityName_Label.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            ActivityName_Label.Location = new Point(0, 0);
            ActivityName_Label.Margin = new Padding(3, 0, 0, 0);
            ActivityName_Label.Name = "ActivityName_Label";
            ActivityName_Label.Padding = new Padding(5, 10, 0, 0);
            ActivityName_Label.Size = new Size(297, 49);
            ActivityName_Label.StateCommon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActivityName_Label.StateCommon.TextColor = Color.Black;
            ActivityName_Label.Text = "Content length will be limited to 100 characters (including spaces)";
            ActivityName_Label.TextAlign = ContentAlignment.MiddleLeft;
            ActivityName_Label.Click += EntryActivity_Control_Click;
            // 
            // EntryActivity_Control
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(ActivityName_Label);
            Controls.Add(Delete_Button);
            Controls.Add(ActivityFundStatus_TLPanel);
            Name = "EntryActivity_Control";
            Size = new Size(350, 80);
            Load += ActivityEntry_Control_Load;
            SizeChanged += EntryActivity_Control_SizeChanged;
            Click += EntryActivity_Control_Click;
            ActivityFundStatus_TLPanel.ResumeLayout(false);
            ActivityFundStatus_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Delete_Button;
        private Krypton.Toolkit.KryptonLabel ProjectedBalanceAmount_Label;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityFundStatus_TLPanel;
        private Krypton.Toolkit.KryptonLabel BudgetActivityType_Label;
        private Krypton.Toolkit.KryptonLabel ActualBalanceAmount_Label;
        private Krypton.Toolkit.KryptonWrapLabel ActivityName_Label;
    }
}
