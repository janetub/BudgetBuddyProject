namespace Budget_Buddy_GUI
{
    partial class PlaceholderBudgetEntries_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceholderBudgetEntries_Control));
            BudgetEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            NoBudget_label = new Label();
            SuspendLayout();
            // 
            // BudgetEntriesPlaceHolder_TablePanel
            // 
            BudgetEntriesPlaceHolder_TablePanel.AutoScroll = true;
            BudgetEntriesPlaceHolder_TablePanel.AutoSize = true;
            BudgetEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("BudgetEntriesPlaceHolder_TablePanel.BackgroundImage");
            BudgetEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            BudgetEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            BudgetEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            BudgetEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BudgetEntriesPlaceHolder_TablePanel.Dock = DockStyle.Fill;
            BudgetEntriesPlaceHolder_TablePanel.Location = new Point(0, 0);
            BudgetEntriesPlaceHolder_TablePanel.Name = "BudgetEntriesPlaceHolder_TablePanel";
            BudgetEntriesPlaceHolder_TablePanel.RowCount = 2;
            BudgetEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            BudgetEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            BudgetEntriesPlaceHolder_TablePanel.Size = new Size(360, 590);
            BudgetEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            BudgetEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            BudgetEntriesPlaceHolder_TablePanel.TabIndex = 0;
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
            NoBudget_label.Size = new Size(78, 16);
            NoBudget_label.TabIndex = 2;
            NoBudget_label.Text = "No budgets.";
            NoBudget_label.Visible = false;
            // 
            // BudgetEntriesPlaceholder_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(NoBudget_label);
            Controls.Add(BudgetEntriesPlaceHolder_TablePanel);
            ForeColor = Color.White;
            Name = "BudgetEntriesPlaceholder_Control";
            Size = new Size(360, 590);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel BudgetEntriesPlaceHolder_TablePanel;
        private Label NoBudget_label;
    }
}
