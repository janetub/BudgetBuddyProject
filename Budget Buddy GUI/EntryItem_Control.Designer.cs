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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryItem_Control));
            ItemName_Label = new Krypton.Toolkit.KryptonLabel();
            ItemDetails_TLPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            ItemPrice_Label = new Krypton.Toolkit.KryptonLabel();
            ItemQuantity_Label = new Krypton.Toolkit.KryptonLabel();
            ItemPriceAmount_Label = new Krypton.Toolkit.KryptonLabel();
            Delete_Button = new Button();
            ItemDetails_TLPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemName_Label
            // 
            ItemName_Label.AutoSize = false;
            ItemName_Label.Enabled = false;
            ItemName_Label.Location = new Point(0, 0);
            ItemName_Label.Name = "ItemName_Label";
            ItemName_Label.Size = new Size(365, 62);
            ItemName_Label.StateCommon.Padding = new Padding(10, 0, 30, 10);
            ItemName_Label.StateCommon.ShortText.Color1 = Color.Black;
            ItemName_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemName_Label.StateNormal.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            ItemName_Label.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ItemName_Label.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ItemName_Label.StateNormal.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.EllipsisCharacter;
            ItemName_Label.TabIndex = 37;
            ItemName_Label.Values.Text = "Item name";
            // 
            // ItemDetails_TLPanel
            // 
            ItemDetails_TLPanel.BackgroundImage = (Image)resources.GetObject("ItemDetails_TLPanel.BackgroundImage");
            ItemDetails_TLPanel.BackgroundImageLayout = ImageLayout.None;
            ItemDetails_TLPanel.ColumnCount = 3;
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1120338F));
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8879662F));
            ItemDetails_TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            ItemDetails_TLPanel.Controls.Add(ItemPrice_Label, 0, 0);
            ItemDetails_TLPanel.Controls.Add(ItemQuantity_Label, 2, 0);
            ItemDetails_TLPanel.Controls.Add(ItemPriceAmount_Label, 1, 0);
            ItemDetails_TLPanel.Dock = DockStyle.Bottom;
            ItemDetails_TLPanel.Enabled = false;
            ItemDetails_TLPanel.Location = new Point(0, 38);
            ItemDetails_TLPanel.Name = "ItemDetails_TLPanel";
            ItemDetails_TLPanel.RowCount = 1;
            ItemDetails_TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemDetails_TLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ItemDetails_TLPanel.Size = new Size(393, 24);
            ItemDetails_TLPanel.StateCommon.Color1 = Color.White;
            ItemDetails_TLPanel.StateCommon.Color2 = Color.White;
            ItemDetails_TLPanel.TabIndex = 47;
            // 
            // ItemPrice_Label
            // 
            ItemPrice_Label.Anchor = AnchorStyles.Right;
            ItemPrice_Label.Enabled = false;
            ItemPrice_Label.Location = new Point(80, 3);
            ItemPrice_Label.MaximumSize = new Size(125, 19);
            ItemPrice_Label.Name = "ItemPrice_Label";
            ItemPrice_Label.Size = new Size(45, 18);
            ItemPrice_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ItemPrice_Label.StateCommon.ShortText.Color1 = Color.Black;
            ItemPrice_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ItemPrice_Label.TabIndex = 40;
            ItemPrice_Label.Values.Text = "Price:";
            // 
            // ItemQuantity_Label
            // 
            ItemQuantity_Label.Anchor = AnchorStyles.Left;
            ItemQuantity_Label.Enabled = false;
            ItemQuantity_Label.Location = new Point(244, 3);
            ItemQuantity_Label.Name = "ItemQuantity_Label";
            ItemQuantity_Label.Size = new Size(145, 18);
            ItemQuantity_Label.StateCommon.Padding = new Padding(0, 0, -7, 3);
            ItemQuantity_Label.StateCommon.ShortText.Color1 = Color.DimGray;
            ItemQuantity_Label.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemQuantity_Label.TabIndex = 42;
            ItemQuantity_Label.Values.Text = "999999999.99x999999999";
            ItemQuantity_Label.Click += ItemQuantity_Label_Click;
            // 
            // ItemPriceAmount_Label
            // 
            ItemPriceAmount_Label.Anchor = AnchorStyles.Left;
            ItemPriceAmount_Label.Enabled = false;
            ItemPriceAmount_Label.Location = new Point(131, 3);
            ItemPriceAmount_Label.MaximumSize = new Size(125, 19);
            ItemPriceAmount_Label.Name = "ItemPriceAmount_Label";
            ItemPriceAmount_Label.Size = new Size(104, 18);
            ItemPriceAmount_Label.StateCommon.Padding = new Padding(0, 0, 0, 3);
            ItemPriceAmount_Label.StateCommon.ShortText.Color1 = Color.Black;
            ItemPriceAmount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPriceAmount_Label.TabIndex = 41;
            ItemPriceAmount_Label.Values.Text = "000000000.00";
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.BackColor = Color.Transparent;
            Delete_Button.BackgroundImage = Properties.Resources.delete3;
            Delete_Button.BackgroundImageLayout = ImageLayout.Center;
            Delete_Button.FlatAppearance.BorderSize = 0;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Location = new Point(364, 3);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(26, 30);
            Delete_Button.TabIndex = 48;
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
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
            Size = new Size(393, 62);
            Click += Entry_Control_Click;
            ItemDetails_TLPanel.ResumeLayout(false);
            ItemDetails_TLPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel ItemName_Label;
        private Krypton.Toolkit.KryptonTableLayoutPanel ItemDetails_TLPanel;
        private Krypton.Toolkit.KryptonLabel ItemQuantity_Label;
        private Krypton.Toolkit.KryptonLabel ItemPrice_Label;
        private Krypton.Toolkit.KryptonLabel ItemPriceAmount_Label;
        private Button Delete_Button;
    }
}
