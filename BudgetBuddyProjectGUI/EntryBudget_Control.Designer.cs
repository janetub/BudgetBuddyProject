namespace Budget_Buddy_GUI
{
    partial class EntryBudget_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryBudget_Control));
            BudgetBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            BudgetFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            Delete_Button = new Button();
            BudgetName_Label = new Krypton.Toolkit.KryptonWrapLabel();
            BudgetFundStatus_TLPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BudgetBalanceAmount_Label
            // 
            BudgetBalanceAmount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BudgetBalanceAmount_Label.Enabled = false;
            BudgetBalanceAmount_Label.Location = new Point(70, 3);
            BudgetBalanceAmount_Label.MaximumSize = new Size(170, 19);
            BudgetBalanceAmount_Label.Name = "BudgetBalanceAmount_Label";
            BudgetBalanceAmount_Label.Size = new Size(163, 19);
            BudgetBalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 20, 3);
            BudgetBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            BudgetBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BudgetBalanceAmount_Label.TabIndex = 33;
            BudgetBalanceAmount_Label.Values.Text = "999,999,999,999.99";
            BudgetBalanceAmount_Label.Click += BudgetEntry_Control_Click;
            // 
            // BudgetFundStatus_TLPanel
            // 
            BudgetFundStatus_TLPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BudgetFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("BudgetFundStatus_TLPanel.BackgroundImage");
            BudgetFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            BudgetFundStatus_TLPanel.ColumnCount = 2;
            BudgetFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle());
            BudgetFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle());
            BudgetFundStatus_TLPanel.Controls.Add(Balance_Label, 0, 0);
            BudgetFundStatus_TLPanel.Controls.Add(BudgetBalanceAmount_Label, 1, 0);
            BudgetFundStatus_TLPanel.Enabled = false;
            BudgetFundStatus_TLPanel.Location = new Point(114, 55);
            BudgetFundStatus_TLPanel.Name = "BudgetFundStatus_TLPanel";
            BudgetFundStatus_TLPanel.RowCount = 1;
            BudgetFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BudgetFundStatus_TLPanel.Size = new Size(236, 25);
            BudgetFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            BudgetFundStatus_TLPanel.TabIndex = 34;
            BudgetFundStatus_TLPanel.Click += BudgetEntry_Control_Click;
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Balance_Label.Enabled = false;
            Balance_Label.Location = new Point(3, 3);
            Balance_Label.MaximumSize = new Size(125, 19);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(59, 19);
            Balance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 34;
            Balance_Label.Values.Text = "Balance:";
            Balance_Label.Click += BudgetEntry_Control_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(321, 3);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 30);
            Delete_Button.TabIndex = 40;
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += DeleteBudget_Button_Click;
            // 
            // BudgetName_Label
            // 
            BudgetName_Label.AutoEllipsis = true;
            BudgetName_Label.AutoSize = false;
            BudgetName_Label.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BudgetName_Label.ForeColor = Color.Black;
            BudgetName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            BudgetName_Label.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            BudgetName_Label.Location = new Point(0, 0);
            BudgetName_Label.Margin = new Padding(0);
            BudgetName_Label.Name = "BudgetName_Label";
            BudgetName_Label.Padding = new Padding(5, 15, 0, 0);
            BudgetName_Label.Size = new Size(318, 55);
            BudgetName_Label.StateCommon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BudgetName_Label.StateCommon.TextColor = Color.Black;
            BudgetName_Label.Text = "Content length will be limited to 100 characters (including spaces)";
            BudgetName_Label.TextAlign = ContentAlignment.MiddleLeft;
            BudgetName_Label.Click += BudgetEntry_Control_Click;
            // 
            // EntryBudget_Control
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(Delete_Button);
            Controls.Add(BudgetFundStatus_TLPanel);
            Controls.Add(BudgetName_Label);
            Name = "EntryBudget_Control";
            Size = new Size(350, 80);
            Click += BudgetEntry_Control_Click;
            BudgetFundStatus_TLPanel.ResumeLayout(false);
            BudgetFundStatus_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonLabel BudgetBalanceAmount_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel BudgetFundStatus_TLPanel;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Button Delete_Button;
        private Krypton.Toolkit.KryptonWrapLabel BudgetName_Label;
    }
}
