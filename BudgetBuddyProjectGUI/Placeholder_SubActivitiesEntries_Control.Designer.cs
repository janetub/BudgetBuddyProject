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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder_SubActivitiesEntries_Control));
            NoContent_label = new Label();
            ActivityItemEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            PlaceHolder_StatusBar_Control = new Krypton.Toolkit.KryptonPanel();
            Back_Button = new Button();
            ContextMenu_Button = new Button();
            Activity_ContextMenu = new ContextMenuStrip(components);
            Edit_toolStripMenuItem = new ToolStripMenuItem();
            Details_toolStripMenuItem = new ToolStripMenuItem();
            Transfer_toolStripMenuItem = new ToolStripMenuItem();
            ToBudget_ToolStripMenuItem = new ToolStripMenuItem();
            ToSavings_ToolStripMenuItem = new ToolStripMenuItem();
            Archive_toolStripMenuItem = new ToolStripMenuItem();
            CancelSavings_ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).BeginInit();
            Activity_ContextMenu.SuspendLayout();
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
            PlaceHolder_StatusBar_Control.PaletteMode = Krypton.Toolkit.PaletteMode.Office2013White;
            PlaceHolder_StatusBar_Control.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
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
            // ContextMenu_Button
            // 
            ContextMenu_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContextMenu_Button.BackColor = Color.Transparent;
            ContextMenu_Button.BackgroundImage = (Image)resources.GetObject("ContextMenu_Button.BackgroundImage");
            ContextMenu_Button.BackgroundImageLayout = ImageLayout.Center;
            ContextMenu_Button.FlatAppearance.BorderSize = 0;
            ContextMenu_Button.FlatStyle = FlatStyle.Flat;
            ContextMenu_Button.Location = new Point(318, 7);
            ContextMenu_Button.Name = "ContextMenu_Button";
            ContextMenu_Button.Size = new Size(30, 28);
            ContextMenu_Button.TabIndex = 57;
            ContextMenu_Button.UseVisualStyleBackColor = false;
            ContextMenu_Button.Click += ContextMenu_Button_Click;
            // 
            // Activity_ContextMenu
            // 
            Activity_ContextMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Activity_ContextMenu.ImeMode = ImeMode.NoControl;
            Activity_ContextMenu.Items.AddRange(new ToolStripItem[] { Edit_toolStripMenuItem, Details_toolStripMenuItem, Transfer_toolStripMenuItem, Archive_toolStripMenuItem, CancelSavings_ToolStripMenuItem });
            Activity_ContextMenu.Name = "Activity_ContextMenu";
            Activity_ContextMenu.Size = new Size(172, 114);
            Activity_ContextMenu.Text = "Menu";
            // 
            // Edit_toolStripMenuItem
            // 
            Edit_toolStripMenuItem.BackColor = Color.White;
            Edit_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Edit_toolStripMenuItem.Image = (Image)resources.GetObject("Edit_toolStripMenuItem.Image");
            Edit_toolStripMenuItem.Name = "Edit_toolStripMenuItem";
            Edit_toolStripMenuItem.Size = new Size(171, 22);
            Edit_toolStripMenuItem.Text = "Edit";
            Edit_toolStripMenuItem.Click += Edit_Button_Click;
            // 
            // Details_toolStripMenuItem
            // 
            Details_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Details_toolStripMenuItem.Image = (Image)resources.GetObject("Details_toolStripMenuItem.Image");
            Details_toolStripMenuItem.Name = "Details_toolStripMenuItem";
            Details_toolStripMenuItem.Size = new Size(171, 22);
            Details_toolStripMenuItem.Text = "Details";
            // 
            // Transfer_toolStripMenuItem
            // 
            Transfer_toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToBudget_ToolStripMenuItem, ToSavings_ToolStripMenuItem });
            Transfer_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Transfer_toolStripMenuItem.Image = (Image)resources.GetObject("Transfer_toolStripMenuItem.Image");
            Transfer_toolStripMenuItem.Name = "Transfer_toolStripMenuItem";
            Transfer_toolStripMenuItem.Size = new Size(171, 22);
            Transfer_toolStripMenuItem.Text = "Transfer Balance";
            // 
            // ToBudget_ToolStripMenuItem
            // 
            ToBudget_ToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToBudget_ToolStripMenuItem.Name = "ToBudget_ToolStripMenuItem";
            ToBudget_ToolStripMenuItem.Size = new Size(134, 22);
            ToBudget_ToolStripMenuItem.Text = "To Budget";
            // 
            // ToSavings_ToolStripMenuItem
            // 
            ToSavings_ToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToSavings_ToolStripMenuItem.Name = "ToSavings_ToolStripMenuItem";
            ToSavings_ToolStripMenuItem.Size = new Size(134, 22);
            ToSavings_ToolStripMenuItem.Text = "To Savings";
            // 
            // Archive_toolStripMenuItem
            // 
            Archive_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Archive_toolStripMenuItem.Image = (Image)resources.GetObject("Archive_toolStripMenuItem.Image");
            Archive_toolStripMenuItem.Name = "Archive_toolStripMenuItem";
            Archive_toolStripMenuItem.Size = new Size(171, 22);
            Archive_toolStripMenuItem.Text = "Archive";
            // 
            // CancelSavings_ToolStripMenuItem
            // 
            CancelSavings_ToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CancelSavings_ToolStripMenuItem.Image = (Image)resources.GetObject("CancelSavings_ToolStripMenuItem.Image");
            CancelSavings_ToolStripMenuItem.Name = "CancelSavings_ToolStripMenuItem";
            CancelSavings_ToolStripMenuItem.Size = new Size(171, 22);
            CancelSavings_ToolStripMenuItem.Text = "Cancel Savings";
            CancelSavings_ToolStripMenuItem.Visible = false;
            CancelSavings_ToolStripMenuItem.Click += CancelSavings_ToolStripMenuItem_Click;
            // 
            // Placeholder_SubActivitiesEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ContextMenu_Button);
            Controls.Add(Back_Button);
            Controls.Add(PlaceHolder_StatusBar_Control);
            Controls.Add(NoContent_label);
            Controls.Add(ActivityItemEntriesPlaceHolder_TablePanel);
            Name = "Placeholder_SubActivitiesEntries_Control";
            Size = new Size(360, 590);
            Load += ActivityItemEntries_Control_Load;
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).EndInit();
            Activity_ContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoContent_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityItemEntriesPlaceHolder_TablePanel;
        private Krypton.Toolkit.KryptonPanel PlaceHolder_StatusBar_Control;
        private Button Back_Button;
        private Button ContextMenu_Button;
        private ContextMenuStrip Activity_ContextMenu;
        private ToolStripMenuItem Edit_toolStripMenuItem;
        private ToolStripMenuItem Details_toolStripMenuItem;
        private ToolStripMenuItem Archive_toolStripMenuItem;
        private ToolStripMenuItem Transfer_toolStripMenuItem;
        private ToolStripMenuItem CancelSavings_ToolStripMenuItem;
        private ToolStripMenuItem ToBudget_ToolStripMenuItem;
        private ToolStripMenuItem ToSavings_ToolStripMenuItem;
    }
}
