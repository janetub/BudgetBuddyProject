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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder_ActivityEntries_Control));
            NoContent_label = new Label();
            ActivityEntriesPlaceHolder_TablePanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            PlaceHolder_StatusBar_Control = new Krypton.Toolkit.KryptonPanel();
            ContextMenu_Button = new Button();
            Back_Button = new Button();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            BalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonWrapLabel();
            Activity_ContextMenu = new ContextMenuStrip(components);
            Edit_toolStripMenuItem = new ToolStripMenuItem();
            AddAmount_toolStripMenuItem = new ToolStripMenuItem();
            RemoveAmount_toolStripMenuItem = new ToolStripMenuItem();
            Details_toolStripMenuItem = new ToolStripMenuItem();
            Archive_toolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).BeginInit();
            PlaceHolder_StatusBar_Control.SuspendLayout();
            ActivityFundStatus_TLPanel.SuspendLayout();
            Activity_ContextMenu.SuspendLayout();
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
            ActivityEntriesPlaceHolder_TablePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActivityEntriesPlaceHolder_TablePanel.AutoScroll = true;
            ActivityEntriesPlaceHolder_TablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("ActivityEntriesPlaceHolder_TablePanel.BackgroundImage");
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            ActivityEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ActivityEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            ActivityEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ActivityEntriesPlaceHolder_TablePanel.Location = new Point(0, 115);
            ActivityEntriesPlaceHolder_TablePanel.Name = "ActivityEntriesPlaceHolder_TablePanel";
            ActivityEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.Size = new Size(360, 475);
            ActivityEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // PlaceHolder_StatusBar_Control
            // 
            PlaceHolder_StatusBar_Control.AutoScroll = true;
            PlaceHolder_StatusBar_Control.Controls.Add(ContextMenu_Button);
            PlaceHolder_StatusBar_Control.Controls.Add(Back_Button);
            PlaceHolder_StatusBar_Control.Controls.Add(ActivityFundStatus_TLPanel);
            PlaceHolder_StatusBar_Control.Controls.Add(Name_Label);
            PlaceHolder_StatusBar_Control.Location = new Point(0, 0);
            PlaceHolder_StatusBar_Control.Name = "PlaceHolder_StatusBar_Control";
            PlaceHolder_StatusBar_Control.PaletteMode = Krypton.Toolkit.PaletteMode.Office2013White;
            PlaceHolder_StatusBar_Control.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
            PlaceHolder_StatusBar_Control.Size = new Size(360, 115);
            PlaceHolder_StatusBar_Control.StateCommon.Color1 = Color.Transparent;
            PlaceHolder_StatusBar_Control.TabIndex = 9;
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
            ContextMenu_Button.TabIndex = 58;
            ContextMenu_Button.UseVisualStyleBackColor = false;
            ContextMenu_Button.Click += ContextMenu_Button_Click;
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
            Back_Button.TabIndex = 53;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 3;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.87013F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.12987F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            ActivityFundStatus_TLPanel.Controls.Add(Balance_Label, 0, 0);
            ActivityFundStatus_TLPanel.Controls.Add(BalanceAmount_Label, 1, 0);
            ActivityFundStatus_TLPanel.Location = new Point(17, 79);
            ActivityFundStatus_TLPanel.Name = "ActivityFundStatus_TLPanel";
            ActivityFundStatus_TLPanel.RowCount = 1;
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ActivityFundStatus_TLPanel.Size = new Size(326, 32);
            ActivityFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            ActivityFundStatus_TLPanel.StateCommon.Color2 = Color.Transparent;
            ActivityFundStatus_TLPanel.TabIndex = 50;
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Right;
            Balance_Label.Enabled = false;
            Balance_Label.Location = new Point(7, 6);
            Balance_Label.MaximumSize = new Size(125, 19);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(59, 19);
            Balance_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            Balance_Label.StateCommon.ShortText.Color1 = Color.Black;
            Balance_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Balance_Label.TabIndex = 42;
            Balance_Label.Values.Text = "Balance:";
            // 
            // BalanceAmount_Label
            // 
            BalanceAmount_Label.Anchor = AnchorStyles.Right;
            BalanceAmount_Label.Enabled = false;
            BalanceAmount_Label.Location = new Point(85, 5);
            BalanceAmount_Label.Name = "BalanceAmount_Label";
            BalanceAmount_Label.Size = new Size(143, 22);
            BalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            BalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            BalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceAmount_Label.TabIndex = 40;
            BalanceAmount_Label.Values.Text = "999,999,999,999.99";
            // 
            // Name_Label
            // 
            Name_Label.AutoEllipsis = true;
            Name_Label.AutoSize = false;
            Name_Label.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.ForeColor = Color.Black;
            Name_Label.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            Name_Label.Location = new Point(0, 31);
            Name_Label.Name = "Name_Label";
            Name_Label.Padding = new Padding(5);
            Name_Label.Size = new Size(360, 48);
            Name_Label.StateCommon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.StateCommon.TextColor = Color.Black;
            Name_Label.Text = "Content length will be limited to 100 characters (including spaces)";
            Name_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Activity_ContextMenu
            // 
            Activity_ContextMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Activity_ContextMenu.ImeMode = ImeMode.NoControl;
            Activity_ContextMenu.Items.AddRange(new ToolStripItem[] { Edit_toolStripMenuItem, AddAmount_toolStripMenuItem, RemoveAmount_toolStripMenuItem, Details_toolStripMenuItem, Archive_toolStripMenuItem });
            Activity_ContextMenu.Name = "Activity_ContextMenu";
            Activity_ContextMenu.Size = new Size(169, 114);
            Activity_ContextMenu.Text = "Menu";
            // 
            // Edit_toolStripMenuItem
            // 
            Edit_toolStripMenuItem.BackColor = Color.White;
            Edit_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Edit_toolStripMenuItem.Image = (Image)resources.GetObject("Edit_toolStripMenuItem.Image");
            Edit_toolStripMenuItem.Name = "Edit_toolStripMenuItem";
            Edit_toolStripMenuItem.Size = new Size(168, 22);
            Edit_toolStripMenuItem.Text = "Edit";
            // 
            // AddAmount_toolStripMenuItem
            // 
            AddAmount_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddAmount_toolStripMenuItem.Image = (Image)resources.GetObject("AddAmount_toolStripMenuItem.Image");
            AddAmount_toolStripMenuItem.Name = "AddAmount_toolStripMenuItem";
            AddAmount_toolStripMenuItem.Size = new Size(168, 22);
            AddAmount_toolStripMenuItem.Text = "Add Amount";
            AddAmount_toolStripMenuItem.Click += AddAmount_toolStripMenuItem_Click;
            // 
            // RemoveAmount_toolStripMenuItem
            // 
            RemoveAmount_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAmount_toolStripMenuItem.Image = (Image)resources.GetObject("RemoveAmount_toolStripMenuItem.Image");
            RemoveAmount_toolStripMenuItem.Name = "RemoveAmount_toolStripMenuItem";
            RemoveAmount_toolStripMenuItem.Size = new Size(168, 22);
            RemoveAmount_toolStripMenuItem.Text = "Remove Amount";
            RemoveAmount_toolStripMenuItem.Click += RemoveAmount_toolStripMenuItem_Click;
            // 
            // Details_toolStripMenuItem
            // 
            Details_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Details_toolStripMenuItem.Image = (Image)resources.GetObject("Details_toolStripMenuItem.Image");
            Details_toolStripMenuItem.Name = "Details_toolStripMenuItem";
            Details_toolStripMenuItem.Size = new Size(168, 22);
            Details_toolStripMenuItem.Text = "Details";
            // 
            // Archive_toolStripMenuItem
            // 
            Archive_toolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Archive_toolStripMenuItem.Image = (Image)resources.GetObject("Archive_toolStripMenuItem.Image");
            Archive_toolStripMenuItem.Name = "Archive_toolStripMenuItem";
            Archive_toolStripMenuItem.Size = new Size(168, 22);
            Archive_toolStripMenuItem.Text = "Archive";
            // 
            // Placeholder_ActivityEntries_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(PlaceHolder_StatusBar_Control);
            Controls.Add(NoContent_label);
            Controls.Add(ActivityEntriesPlaceHolder_TablePanel);
            Name = "Placeholder_ActivityEntries_Control";
            Size = new Size(360, 590);
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).EndInit();
            PlaceHolder_StatusBar_Control.ResumeLayout(false);
            ActivityFundStatus_TLPanel.ResumeLayout(false);
            ActivityFundStatus_TLPanel.PerformLayout();
            Activity_ContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoContent_label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityEntriesPlaceHolder_TablePanel;
        private Krypton.Toolkit.KryptonPanel PlaceHolder_StatusBar_Control;
        private Krypton.Toolkit.KryptonTableLayoutPanel ActivityFundStatus_TLPanel;
        private Krypton.Toolkit.KryptonLabel Balance_Label;
        private Krypton.Toolkit.KryptonLabel BalanceAmount_Label;
        private Krypton.Toolkit.KryptonWrapLabel Name_Label;
        private Button Back_Button;
        private ContextMenuStrip Activity_ContextMenu;
        private ToolStripMenuItem Edit_toolStripMenuItem;
        private ToolStripMenuItem Details_toolStripMenuItem;
        private Button ContextMenu_Button;
        private ToolStripMenuItem AddAmount_toolStripMenuItem;
        private ToolStripMenuItem RemoveAmount_toolStripMenuItem;
        private ToolStripMenuItem Archive_toolStripMenuItem;
    }
}
