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
            PlaceHolder_StatusBar_Control = new Krypton.Toolkit.KryptonPanel();
            Back_Button = new Button();
            Edit_Button = new Button();
            Information_Button = new Button();
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
            ActivityItemEntriesPlaceHolder_TablePanel.Location = new Point(0, 168);
            ActivityItemEntriesPlaceHolder_TablePanel.Name = "ActivityItemEntriesPlaceHolder_TablePanel";
            ActivityItemEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityItemEntriesPlaceHolder_TablePanel.Size = new Size(360, 422);
            ActivityItemEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityItemEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityItemEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // PlaceHolder_StatusBar_Control
            // 
            PlaceHolder_StatusBar_Control.Location = new Point(0, 27);
            PlaceHolder_StatusBar_Control.Name = "PlaceHolder_StatusBar_Control";
            PlaceHolder_StatusBar_Control.Size = new Size(360, 141);
            PlaceHolder_StatusBar_Control.StateCommon.Color1 = Color.Transparent;
            PlaceHolder_StatusBar_Control.TabIndex = 8;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.Transparent;
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Center;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Location = new Point(12, 7);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(31, 28);
            Back_Button.TabIndex = 54;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // Edit_Button
            // 
            Edit_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit_Button.BackColor = Color.Transparent;
            Edit_Button.BackgroundImage = (Image)resources.GetObject("Edit_Button.BackgroundImage");
            Edit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Edit_Button.FlatAppearance.BorderSize = 0;
            Edit_Button.FlatStyle = FlatStyle.Flat;
            Edit_Button.Location = new Point(318, 7);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(30, 26);
            Edit_Button.TabIndex = 55;
            Edit_Button.UseVisualStyleBackColor = false;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Information_Button
            // 
            Information_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Information_Button.BackColor = Color.Transparent;
            Information_Button.BackgroundImage = (Image)resources.GetObject("Information_Button.BackgroundImage");
            Information_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Information_Button.FlatAppearance.BorderSize = 0;
            Information_Button.FlatStyle = FlatStyle.Flat;
            Information_Button.Location = new Point(282, 7);
            Information_Button.Name = "Information_Button";
            Information_Button.Size = new Size(30, 26);
            Information_Button.TabIndex = 56;
            Information_Button.UseVisualStyleBackColor = false;
            Information_Button.Click += Information_Button_Click;
            // 
            // Placeholder_SubActivitiesEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Information_Button);
            Controls.Add(Edit_Button);
            Controls.Add(Back_Button);
            Controls.Add(PlaceHolder_StatusBar_Control);
            Controls.Add(NoContent_label);
            Controls.Add(ActivityItemEntriesPlaceHolder_TablePanel);
            Name = "Placeholder_SubActivitiesEntries_Control";
            Size = new Size(360, 590);
            Load += ActivityItemEntries_Control_Load;
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoContent_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityItemEntriesPlaceHolder_TablePanel;
        private Krypton.Toolkit.KryptonPanel PlaceHolder_StatusBar_Control;
        private Button button1;
        private Button Back_Button;
        private Button Edit_Button;
        private Button Information_Button;
    }
}
