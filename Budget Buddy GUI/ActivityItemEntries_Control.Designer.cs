namespace Budget_Buddy_GUI
{
    partial class ActivityItemEntries_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityItemEntries_Control));
            NoBudget_label = new Label();
            ActivityItemEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            SuspendLayout();
            // 
            // NoBudget_label
            // 
            NoBudget_label.Anchor = AnchorStyles.None;
            NoBudget_label.AutoSize = true;
            NoBudget_label.BackColor = Color.White;
            NoBudget_label.Enabled = false;
            NoBudget_label.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            NoBudget_label.ForeColor = Color.Gray;
            NoBudget_label.Location = new Point(119, 292);
            NoBudget_label.Name = "NoBudget_label";
            NoBudget_label.Size = new Size(126, 16);
            NoBudget_label.TabIndex = 3;
            NoBudget_label.Text = "No activities / items.";
            NoBudget_label.Visible = false;
            NoBudget_label.Click += NoBudget_label_Click;
            // 
            // ActivityItemEntriesPlaceHolder_TablePanel
            // 
            ActivityItemEntriesPlaceHolder_TablePanel.AutoScroll = true;
            ActivityItemEntriesPlaceHolder_TablePanel.AutoSize = true;
            ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImage");
            ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            ActivityItemEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ActivityItemEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            ActivityItemEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ActivityItemEntriesPlaceHolder_TablePanel.Dock = DockStyle.Fill;
            ActivityItemEntriesPlaceHolder_TablePanel.Location = new Point(0, 0);
            ActivityItemEntriesPlaceHolder_TablePanel.Name = "ActivityItemEntriesPlaceHolder_TablePanel";
            ActivityItemEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.Size = new Size(360, 590);
            ActivityItemEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityItemEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityItemEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // ActivityItemEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(NoBudget_label);
            Controls.Add(ActivityItemEntriesPlaceHolder_TablePanel);
            Name = "ActivityItemEntries_Control";
            Size = new Size(360, 590);
            Load += ActivityItemEntries_Control_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoBudget_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityItemEntriesPlaceHolder_TablePanel;
    }
}
