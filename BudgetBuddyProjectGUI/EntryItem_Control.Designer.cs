namespace Budget_Buddy_GUI
{
    partial class EntryItem_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryItem_Control));
            ItemDetails_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            BudgetActivityType_Label = new Krypton.Toolkit.KryptonLabel();
            ItemQuantity_Label = new Krypton.Toolkit.KryptonLabel();
            ItemPrice_Label = new Krypton.Toolkit.KryptonLabel();
            ItemPriceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Delete_Button = new Button();
            ItemName_Tooltip = new ToolTip(components);
            ItemName_Label = new Krypton.Toolkit.KryptonWrapLabel();
            ItemDetails_TLPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemDetails_TLPanel
            // 
            ItemDetails_TLPanel.BackgroundImage = (Image)resources.GetObject("ItemDetails_TLPanel.BackgroundImage");
            ItemDetails_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ItemDetails_TLPanel.ColumnCount = 4;
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7142859F));
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8571434F));
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.43F));
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            ItemDetails_TLPanel.Controls.Add(BudgetActivityType_Label, 0, 0);
            ItemDetails_TLPanel.Controls.Add(ItemQuantity_Label, 3, 0);
            ItemDetails_TLPanel.Controls.Add(ItemPrice_Label, 1, 0);
            ItemDetails_TLPanel.Controls.Add(ItemPriceAmount_Label, 2, 0);
            ItemDetails_TLPanel.Dock = DockStyle.Bottom;
            ItemDetails_TLPanel.Enabled = false;
            ItemDetails_TLPanel.Location = new Point(0, 52);
            ItemDetails_TLPanel.Name = "ItemDetails_TLPanel";
            ItemDetails_TLPanel.Padding = new Padding(0, 0, 0, 3);
            ItemDetails_TLPanel.RowCount = 1;
            ItemDetails_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemDetails_TLPanel.Size = new Size(330, 28);
            ItemDetails_TLPanel.StateCommon.Color1 = Color.White;
            ItemDetails_TLPanel.StateCommon.Color2 = Color.White;
            ItemDetails_TLPanel.TabIndex = 47;
            ItemDetails_TLPanel.Click += Entry_Control_Click;
            // 
            // BudgetActivityType_Label
            // 
            BudgetActivityType_Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BudgetActivityType_Label.Enabled = false;
            BudgetActivityType_Label.Location = new Point(3, 3);
            BudgetActivityType_Label.MaximumSize = new Size(125, 19);
            BudgetActivityType_Label.Name = "BudgetActivityType_Label";
            BudgetActivityType_Label.Size = new Size(27, 19);
            BudgetActivityType_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            BudgetActivityType_Label.StateCommon.ShortText.Color1 = Color.Gray;
            BudgetActivityType_Label.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BudgetActivityType_Label.TabIndex = 48;
            BudgetActivityType_Label.Values.Text = "Item";
            BudgetActivityType_Label.Click += Entry_Control_Click;
            // 
            // ItemQuantity_Label
            // 
            ItemQuantity_Label.Anchor = AnchorStyles.Left;
            ItemQuantity_Label.AutoSize = false;
            ItemQuantity_Label.Enabled = false;
            ItemQuantity_Label.Location = new Point(213, 3);
            ItemQuantity_Label.Name = "ItemQuantity_Label";
            ItemQuantity_Label.Size = new Size(114, 18);
            ItemQuantity_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            ItemQuantity_Label.StateCommon.ShortText.Color1 = Color.DimGray;
            ItemQuantity_Label.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemQuantity_Label.TabIndex = 42;
            ItemQuantity_Label.Values.Text = "999,999.99x9,999qty";
            ItemQuantity_Label.Click += Entry_Control_Click;
            // 
            // ItemPrice_Label
            // 
            ItemPrice_Label.Anchor = AnchorStyles.Right;
            ItemPrice_Label.Enabled = false;
            ItemPrice_Label.Location = new Point(36, 3);
            ItemPrice_Label.MaximumSize = new Size(125, 19);
            ItemPrice_Label.Name = "ItemPrice_Label";
            ItemPrice_Label.Size = new Size(42, 19);
            ItemPrice_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ItemPrice_Label.StateCommon.ShortText.Color1 = Color.Black;
            ItemPrice_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ItemPrice_Label.TabIndex = 40;
            ItemPrice_Label.Values.Text = "Cost:";
            ItemPrice_Label.Click += Entry_Control_Click;
            // 
            // ItemPriceAmount_Label
            // 
            ItemPriceAmount_Label.Anchor = AnchorStyles.Right;
            ItemPriceAmount_Label.Enabled = false;
            ItemPriceAmount_Label.Location = new Point(84, 3);
            ItemPriceAmount_Label.Margin = new Padding(3, 3, 0, 3);
            ItemPriceAmount_Label.Name = "ItemPriceAmount_Label";
            ItemPriceAmount_Label.Size = new Size(126, 19);
            ItemPriceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ItemPriceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ItemPriceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPriceAmount_Label.TabIndex = 49;
            ItemPriceAmount_Label.Values.Text = "9,999,999,999.99";
            ItemPriceAmount_Label.Click += Entry_Control_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(301, 3);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 30);
            Delete_Button.TabIndex = 48;
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // ItemName_Label
            // 
            ItemName_Label.AutoEllipsis = true;
            ItemName_Label.AutoSize = false;
            ItemName_Label.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemName_Label.ForeColor = Color.Black;
            ItemName_Label.ImageAlign = ContentAlignment.MiddleLeft;
            ItemName_Label.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            ItemName_Label.Location = new Point(0, 0);
            ItemName_Label.Margin = new Padding(3, 0, 0, 0);
            ItemName_Label.Name = "ItemName_Label";
            ItemName_Label.Padding = new Padding(5, 10, 0, 0);
            ItemName_Label.Size = new Size(298, 52);
            ItemName_Label.StateCommon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemName_Label.StateCommon.TextColor = Color.Black;
            ItemName_Label.Text = "Content length will be limited to 100 characters (including spaces)";
            ItemName_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EntryItem_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Delete_Button);
            Controls.Add(ItemDetails_TLPanel);
            Controls.Add(ItemName_Label);
            Name = "EntryItem_Control";
            Size = new Size(330, 80);
            Click += Entry_Control_Click;
            ItemDetails_TLPanel.ResumeLayout(false);
            ItemDetails_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonTableLayoutPanel ItemDetails_TLPanel;
        private Krypton.Toolkit.KryptonLabel ItemQuantity_Label;
        private Krypton.Toolkit.KryptonLabel ItemPrice_Label;
        private Button Delete_Button;
        private Krypton.Toolkit.KryptonLabel BudgetActivityType_Label;
        private Krypton.Toolkit.KryptonLabel ItemPriceAmount_Label;
        private ToolTip ItemName_Tooltip;
        private Krypton.Toolkit.KryptonWrapLabel ItemName_Label;
    }
}
