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
            PlaceHolder_StatusBar_Control = new Krypton.Toolkit.KryptonPanel();
            ActivityFundStatus_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            Balance_Label = new Krypton.Toolkit.KryptonLabel();
            BalanceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Edit_Button = new Button();
            Name_Label = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)PlaceHolder_StatusBar_Control).BeginInit();
            PlaceHolder_StatusBar_Control.SuspendLayout();
            ActivityFundStatus_TLPanel.SuspendLayout();
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
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImage = (Image)resources.GetObject("ActivityEntriesPlaceHolder_TablePanel.BackgroundImage");
            ActivityEntriesPlaceHolder_TablePanel.BackgroundImageLayout = ImageLayout.None;
            ActivityEntriesPlaceHolder_TablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ActivityEntriesPlaceHolder_TablePanel.ColumnCount = 1;
            ActivityEntriesPlaceHolder_TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ActivityEntriesPlaceHolder_TablePanel.Location = new Point(0, 80);
            ActivityEntriesPlaceHolder_TablePanel.Name = "ActivityEntriesPlaceHolder_TablePanel";
            ActivityEntriesPlaceHolder_TablePanel.RowCount = 2;
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.RowStyles.Add(new RowStyle());
            ActivityEntriesPlaceHolder_TablePanel.Size = new Size(360, 510);
            ActivityEntriesPlaceHolder_TablePanel.StateCommon.Draw = Krypton.Toolkit.InheritBool.False;
            ActivityEntriesPlaceHolder_TablePanel.StateNormal.Color1 = Color.White;
            ActivityEntriesPlaceHolder_TablePanel.TabIndex = 5;
            // 
            // PlaceHolder_StatusBar_Control
            // 
            PlaceHolder_StatusBar_Control.Controls.Add(ActivityFundStatus_TLPanel);
            PlaceHolder_StatusBar_Control.Controls.Add(Name_Label);
            PlaceHolder_StatusBar_Control.Location = new Point(0, 0);
            PlaceHolder_StatusBar_Control.Name = "PlaceHolder_StatusBar_Control";
            PlaceHolder_StatusBar_Control.Size = new Size(360, 80);
            PlaceHolder_StatusBar_Control.StateCommon.Color1 = Color.Transparent;
            PlaceHolder_StatusBar_Control.TabIndex = 9;
            // 
            // ActivityFundStatus_TLPanel
            // 
            ActivityFundStatus_TLPanel.BackgroundImage = (Image)resources.GetObject("ActivityFundStatus_TLPanel.BackgroundImage");
            ActivityFundStatus_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ActivityFundStatus_TLPanel.ColumnCount = 3;
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            ActivityFundStatus_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            ActivityFundStatus_TLPanel.Controls.Add(Balance_Label, 0, 0);
            ActivityFundStatus_TLPanel.Controls.Add(BalanceAmount_Label, 1, 0);
            ActivityFundStatus_TLPanel.Controls.Add(Edit_Button, 2, 0);
            ActivityFundStatus_TLPanel.Location = new Point(17, 48);
            ActivityFundStatus_TLPanel.Name = "ActivityFundStatus_TLPanel";
            ActivityFundStatus_TLPanel.RowCount = 1;
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActivityFundStatus_TLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ActivityFundStatus_TLPanel.Size = new Size(326, 32);
            ActivityFundStatus_TLPanel.StateCommon.Color1 = Color.White;
            ActivityFundStatus_TLPanel.StateCommon.Color2 = Color.White;
            ActivityFundStatus_TLPanel.TabIndex = 50;
            // 
            // Balance_Label
            // 
            Balance_Label.Anchor = AnchorStyles.Left;
            Balance_Label.Enabled = false;
            Balance_Label.Location = new Point(3, 6);
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
            BalanceAmount_Label.Location = new Point(100, 6);
            BalanceAmount_Label.MaximumSize = new Size(125, 19);
            BalanceAmount_Label.Name = "BalanceAmount_Label";
            BalanceAmount_Label.Size = new Size(104, 19);
            BalanceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            BalanceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            BalanceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceAmount_Label.TabIndex = 40;
            BalanceAmount_Label.Values.Text = "000000000.00";
            // 
            // Edit_Button
            // 
            Edit_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit_Button.BackColor = Color.Transparent;
            Edit_Button.BackgroundImage = (Image)resources.GetObject("Edit_Button.BackgroundImage");
            Edit_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Edit_Button.FlatAppearance.BorderSize = 0;
            Edit_Button.FlatStyle = FlatStyle.Flat;
            Edit_Button.Location = new Point(293, 3);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(30, 26);
            Edit_Button.TabIndex = 43;
            Edit_Button.UseVisualStyleBackColor = false;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Name_Label
            // 
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
        private Button Edit_Button;
    }
}
