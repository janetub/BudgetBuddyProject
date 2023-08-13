namespace Budget_Buddy_GUI
{
    partial class StatusPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusPanel));
            Name_Label = new Krypton.Toolkit.KryptonWrapLabel();
            StatusBar_PicBox = new PictureBox();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Projected_Label = new Krypton.Toolkit.KryptonLabel();
            Actual_Label = new Krypton.Toolkit.KryptonLabel();
            AllocatedAmount_Label1 = new Krypton.Toolkit.KryptonLabel();
            AllocatedAmount_Label2 = new Krypton.Toolkit.KryptonLabel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ActualBalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ProjectedAmount_Label = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)StatusBar_PicBox).BeginInit();
            ActivityFundStatus_TLPanel.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Name_Label
            // 
            Name_Label.AutoEllipsis = true;
            Name_Label.AutoSize = false;
            Name_Label.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.ForeColor = Color.Black;
            Name_Label.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            Name_Label.Location = new Point(0, 0);
            Name_Label.Name = "Name_Label";
            Name_Label.Padding = new Padding(5);
            Name_Label.Size = new Size(360, 48);
            Name_Label.StateCommon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.StateCommon.TextColor = Color.Black;
            Name_Label.Text = "Content length will be limited to 100 characters (including spaces)";
            Name_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBar_PicBox
            // 
            StatusBar_PicBox.BorderStyle = BorderStyle.FixedSingle;
            StatusBar_PicBox.Location = new Point(10, 55);
            StatusBar_PicBox.Name = "StatusBar_PicBox";
            StatusBar_PicBox.Size = new Size(340, 28);
            StatusBar_PicBox.TabIndex = 3;
            StatusBar_PicBox.TabStop = false;
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 3;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.636364F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.363636F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            ActivityFundStatus_TLPanel.Controls.Add(ProjectedAmount_Label, 1, 1);
            ActivityFundStatus_TLPanel.Controls.Add(ActualBalanceAmount_Label, 1, 0);
            ActivityFundStatus_TLPanel.Controls.Add(Projected_Label, 0, 1);
            ActivityFundStatus_TLPanel.Controls.Add(Actual_Label, 0, 0);
            ActivityFundStatus_TLPanel.Controls.Add(AllocatedAmount_Label1, 2, 0);
            ActivityFundStatus_TLPanel.Controls.Add(AllocatedAmount_Label2, 2, 1);
            ActivityFundStatus_TLPanel.Location = new Point(10, 83);
            ActivityFundStatus_TLPanel.Name = "ActivityFundStatus_TLPanel";
            ActivityFundStatus_TLPanel.RowCount = 2;
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ActivityFundStatus_TLPanel.Size = new Size(340, 55);
            ActivityFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            ActivityFundStatus_TLPanel.StateCommon.Color2 = Color.White;
            ActivityFundStatus_TLPanel.TabIndex = 47;
            // 
            // Projected_Label
            // 
            Projected_Label.Anchor = AnchorStyles.Left;
            Projected_Label.Enabled = false;
            Projected_Label.Location = new Point(3, 34);
            Projected_Label.MaximumSize = new Size(125, 19);
            Projected_Label.Name = "Projected_Label";
            Projected_Label.Size = new Size(77, 18);
            Projected_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Projected_Label.StateCommon.ShortText.Color1 = Color.Black;
            Projected_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Projected_Label.TabIndex = 49;
            Projected_Label.Values.Text = "[P]rojected:";
            // 
            // Actual_Label
            // 
            Actual_Label.Anchor = AnchorStyles.Left;
            Actual_Label.Enabled = false;
            Actual_Label.Location = new Point(3, 6);
            Actual_Label.MaximumSize = new Size(125, 19);
            Actual_Label.Name = "Actual_Label";
            Actual_Label.Size = new Size(54, 19);
            Actual_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Actual_Label.StateCommon.ShortText.Color1 = Color.Black;
            Actual_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Actual_Label.TabIndex = 42;
            Actual_Label.Values.Text = "[A]ctual:";
            // 
            // AllocatedAmount_Label1
            // 
            AllocatedAmount_Label1.Anchor = AnchorStyles.Left;
            AllocatedAmount_Label1.AutoSize = false;
            AllocatedAmount_Label1.Enabled = false;
            AllocatedAmount_Label1.Location = new Point(223, 6);
            AllocatedAmount_Label1.Name = "AllocatedAmount_Label1";
            AllocatedAmount_Label1.Size = new Size(114, 19);
            AllocatedAmount_Label1.StateCommon.Padding = new Padding(0, 0, 0, 3);
            AllocatedAmount_Label1.StateCommon.ShortText.Color1 = Color.Black;
            AllocatedAmount_Label1.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AllocatedAmount_Label1.TabIndex = 41;
            AllocatedAmount_Label1.Values.Text = "/9,999,999,999.99";
            // 
            // AllocatedAmount_Label2
            // 
            AllocatedAmount_Label2.Anchor = AnchorStyles.Left;
            AllocatedAmount_Label2.AutoSize = false;
            AllocatedAmount_Label2.Enabled = false;
            AllocatedAmount_Label2.Location = new Point(223, 34);
            AllocatedAmount_Label2.Name = "AllocatedAmount_Label2";
            AllocatedAmount_Label2.Size = new Size(114, 18);
            AllocatedAmount_Label2.StateCommon.Padding = new Padding(0, 0, 0, 3);
            AllocatedAmount_Label2.StateCommon.ShortText.Color1 = Color.Black;
            AllocatedAmount_Label2.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AllocatedAmount_Label2.TabIndex = 51;
            AllocatedAmount_Label2.Values.Text = "/9,999,999,999.99";
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 3;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            kryptonTableLayoutPanel1.Controls.Add(kryptonLabel1, 0, 0);
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 1;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            kryptonTableLayoutPanel1.Size = new Size(200, 100);
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Left;
            kryptonLabel1.Enabled = false;
            kryptonLabel1.Location = new Point(3, 40);
            kryptonLabel1.MaximumSize = new Size(125, 19);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(6, 19);
            kryptonLabel1.StateCommon.Padding = new Padding(0, 0, -7, 3);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 42;
            kryptonLabel1.Values.Text = "Actual:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Left;
            kryptonLabel2.Enabled = false;
            kryptonLabel2.Location = new Point(15, 40);
            kryptonLabel2.MaximumSize = new Size(125, 19);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(30, 19);
            kryptonLabel2.StateCommon.Padding = new Padding(0, 0, 0, 3);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 40;
            kryptonLabel2.Values.Text = "000000000.00";
            // 
            // ActualBalanceAmount_Label
            // 
            ActualBalanceAmount_Label.Anchor = AnchorStyles.Right;
            ActualBalanceAmount_Label.Location = new Point(94, 6);
            ActualBalanceAmount_Label.Margin = new Padding(0);
            ActualBalanceAmount_Label.Name = "ActualBalanceAmount_Label";
            ActualBalanceAmount_Label.Size = new Size(126, 19);
            ActualBalanceAmount_Label.StateCommon.Padding = new Padding(0);
            ActualBalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ActualBalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ActualBalanceAmount_Label.TabIndex = 49;
            ActualBalanceAmount_Label.Values.Text = "9,999,999,999.99";
            // 
            // ProjectedAmount_Label
            // 
            ProjectedAmount_Label.Anchor = AnchorStyles.Right;
            ProjectedAmount_Label.Location = new Point(94, 33);
            ProjectedAmount_Label.Margin = new Padding(0);
            ProjectedAmount_Label.Name = "ProjectedAmount_Label";
            ProjectedAmount_Label.Size = new Size(126, 19);
            ProjectedAmount_Label.StateCommon.Padding = new Padding(0);
            ProjectedAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ProjectedAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectedAmount_Label.TabIndex = 52;
            ProjectedAmount_Label.Values.Text = "9,999,999,999.99";
            // 
            // StatusPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ActivityFundStatus_TLPanel);
            Controls.Add(StatusBar_PicBox);
            Controls.Add(Name_Label);
            Name = "StatusPanel";
            Size = new Size(360, 141);
            ((System.ComponentModel.ISupportInitialize)StatusBar_PicBox).EndInit();
            ActivityFundStatus_TLPanel.ResumeLayout(false);
            ActivityFundStatus_TLPanel.PerformLayout();
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonWrapLabel Name_Label;
        private PictureBox StatusBar_PicBox;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityFundStatus_TLPanel;
        private Krypton.Toolkit.KryptonLabel Projected_Label;
        private Krypton.Toolkit.KryptonLabel Actual_Label;
        private Krypton.Toolkit.KryptonLabel AllocatedAmount_Label1;
        private Krypton.Toolkit.KryptonLabel AllocatedAmount_Label2;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel ProjectedAmount_Label;
        private Krypton.Toolkit.KryptonLabel ActualBalanceAmount_Label;
    }
}
