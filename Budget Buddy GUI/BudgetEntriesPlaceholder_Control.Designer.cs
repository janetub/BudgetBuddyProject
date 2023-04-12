namespace Budget_Buddy_GUI
{
    partial class BudgetEntriesPlaceholder_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetEntriesPlaceholder_Control));
            BudgetEntryPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            NoBudget_label = new Label();
            SuspendLayout();
            // 
            // BudgetEntryPlaceHolder_TablePanel
            // 
            BudgetEntryPlaceHolder_TablePanel.AutoScroll = true;
            BudgetEntryPlaceHolder_TablePanel.AutoSize = true;
            BudgetEntryPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("BudgetEntryPlaceHolder_TablePanel.BackgroundImage");
            BudgetEntryPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            BudgetEntryPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            BudgetEntryPlaceHolder_TablePanel.ColumnCount = 1;
            BudgetEntryPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BudgetEntryPlaceHolder_TablePanel.Dock = DockStyle.Fill;
            BudgetEntryPlaceHolder_TablePanel.Location = new Point(0, 0);
            BudgetEntryPlaceHolder_TablePanel.Name = "BudgetEntryPlaceHolder_TablePanel";
            BudgetEntryPlaceHolder_TablePanel.RowCount = 2;
            BudgetEntryPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            BudgetEntryPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            BudgetEntryPlaceHolder_TablePanel.Size = new Size(360, 590);
            BudgetEntryPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            BudgetEntryPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            BudgetEntryPlaceHolder_TablePanel.TabIndex = 0;
            // 
            // NoBudget_label
            // 
            NoBudget_label.AutoSize = true;
            NoBudget_label.BackColor = SystemColors.Control;
            NoBudget_label.Enabled = false;
            NoBudget_label.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            NoBudget_label.ForeColor = Color.Gray;
            NoBudget_label.Location = new Point(144, 304);
            NoBudget_label.Name = "NoBudget_label";
            NoBudget_label.Size = new Size(71, 16);
            NoBudget_label.TabIndex = 2;
            NoBudget_label.Text = "No budget.";
            NoBudget_label.Visible = false;
            // 
            // BudgetEntriesPlaceholder_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(NoBudget_label);
            Controls.Add(BudgetEntryPlaceHolder_TablePanel);
            ForeColor = Color.White;
            Name = "BudgetEntriesPlaceholder_Control";
            Size = new Size(360, 590);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel BudgetEntryPlaceHolder_TablePanel;
        private Label NoBudget_label;
    }
}
