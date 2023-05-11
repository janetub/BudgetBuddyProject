namespace Budget_Buddy_GUI
{
    partial class Placeholder_SubActivitiesEntries_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder_SubActivitiesEntries_Control));
            NoContent_label = new Label();
            ActivityItemEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            button1 = new Button();
            PlaceHolder_StatusBar_Control = new Krypton.Toolkit.KryptonPanel();
            ActivityItemEntriesPlaceHolder_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).BeginInit();
            SuspendLayout();
            // 
            // NoContent_label
            // 
            NoContent_label.Anchor = AnchorStyles.None;
            NoContent_label.AutoSize = true;
            NoContent_label.BackColor = SystemColors.Control;
            NoContent_label.Enabled = false;
            NoContent_label.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            NoContent_label.ForeColor = Color.Gray;
            NoContent_label.Location = new Point(119, 292);
            NoContent_label.Name = "NoContent_label";
            NoContent_label.Size = new Size(126, 16);
            NoContent_label.TabIndex = 3;
            NoContent_label.Text = "No activities / items.";
            // 
            // ActivityItemEntriesPlaceHolder_TablePanel
            // 
            ActivityItemEntriesPlaceHolder_TablePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ActivityItemEntriesPlaceHolder_TablePanel.AutoScroll = true;
            ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImage");
            ActivityItemEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            ActivityItemEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ActivityItemEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            ActivityItemEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(button1, 0, 1);
            ActivityItemEntriesPlaceHolder_TablePanel.Location = new Point(0, 141);
            ActivityItemEntriesPlaceHolder_TablePanel.Name = "ActivityItemEntriesPlaceHolder_TablePanel";
            ActivityItemEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.Size = new Size(360, 449);
            ActivityItemEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityItemEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityItemEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(4, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PlaceHolder_StatusBar_Control
            // 
            PlaceHolder_StatusBar_Control.Location = new Point(0, 0);
            PlaceHolder_StatusBar_Control.Name = "PlaceHolder_StatusBar_Control";
            PlaceHolder_StatusBar_Control.Size = new Size(360, 141);
            PlaceHolder_StatusBar_Control.StateCommon.Color1 = Color.Transparent;
            PlaceHolder_StatusBar_Control.TabIndex = 8;
            // 
            // Placeholder_BudgetActivitiesEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(PlaceHolder_StatusBar_Control);
            Controls.Add(NoContent_label);
            Controls.Add(ActivityItemEntriesPlaceHolder_TablePanel);
            Name = "Placeholder_BudgetActivitiesEntries_Control";
            Size = new Size(360, 590);
            Load += ActivityItemEntries_Control_Load;
            ActivityItemEntriesPlaceHolder_TablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoContent_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityItemEntriesPlaceHolder_TablePanel;
        private Krypton.Toolkit.KryptonPanel PlaceHolder_StatusBar_Control;
        private Button button1;
    }
}
