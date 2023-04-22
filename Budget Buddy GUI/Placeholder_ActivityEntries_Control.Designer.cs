namespace Budget_Buddy_GUI
{
    partial class Placeholder_ActivityEntries_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder_ActivityEntries_Control));
            NoContent_label = new Label();
            ActivityEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            SuspendLayout();
            // 
            // NoContent_label
            // 
            NoContent_label.AutoSize = true;
            NoContent_label.BackColor = SystemColors.Control;
            NoContent_label.Enabled = false;
            NoContent_label.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            NoContent_label.ForeColor = Color.Gray;
            NoContent_label.Location = new Point(145, 287);
            NoContent_label.Name = "NoContent_label";
            NoContent_label.Size = new Size(82, 16);
            NoContent_label.TabIndex = 3;
            NoContent_label.Text = "No activities.";
            NoContent_label.Visible = false;
            // 
            // ActivityEntriesPlaceHolder_TablePanel
            // 
            ActivityEntriesPlaceHolder_TablePanel.AutoScroll = true;
            ActivityEntriesPlaceHolder_TablePanel.AutoSize = true;
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("ActivityEntriesPlaceHolder_TablePanel.BackgroundImage");
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            ActivityEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ActivityEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            ActivityEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ActivityEntriesPlaceHolder_TablePanel.Dock = DockStyle.Fill;
            ActivityEntriesPlaceHolder_TablePanel.Location = new Point(0, 0);
            ActivityEntriesPlaceHolder_TablePanel.Name = "ActivityEntriesPlaceHolder_TablePanel";
            ActivityEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.Size = new Size(360, 590);
            ActivityEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // Placeholder_ActivityEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(NoContent_label);
            Controls.Add(ActivityEntriesPlaceHolder_TablePanel);
            Name = "Placeholder_ActivityEntries_Control";
            Size = new Size(360, 590);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoContent_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityEntriesPlaceHolder_TablePanel;
    }
}
