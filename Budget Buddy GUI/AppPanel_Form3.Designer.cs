namespace Budget_Buddy_GUI
{
    partial class AppPanel_Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuButton = new Button();
            AppBar = new PictureBox();
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)AppBar).BeginInit();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(255, 178, 30);
            MenuButton.BackgroundImage = Properties.Resources.MenuButton_Image;
            MenuButton.BackgroundImageLayout = ImageLayout.Center;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(30, 30);
            MenuButton.TabIndex = 22;
            MenuButton.UseVisualStyleBackColor = false;
            // 
            // AppBar
            // 
            AppBar.BackColor = Color.FromArgb(255, 178, 30);
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(360, 50);
            AppBar.TabIndex = 21;
            AppBar.TabStop = false;
            // 
            // CreateBudgetInputFields_TableLayoutPanel
            // 
            CreateBudgetInputFields_TableLayoutPanel.ColumnCount = 1;
            CreateBudgetInputFields_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CreateBudgetInputFields_TableLayoutPanel.Controls.Add(Amount_Label, 0, 2);
            CreateBudgetInputFields_TableLayoutPanel.Location = new Point(0, 0);
            CreateBudgetInputFields_TableLayoutPanel.Name = "CreateBudgetInputFields_TableLayoutPanel";
            CreateBudgetInputFields_TableLayoutPanel.RowCount = 3;
            CreateBudgetInputFields_TableLayoutPanel.Size = new Size(200, 100);
            CreateBudgetInputFields_TableLayoutPanel.TabIndex = 0;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Amount_Label.Location = new Point(3, 76);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(70, 21);
            Amount_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Label.TabIndex = 33;
            Amount_Label.Values.Text = "Amount";
            // 
            // Name_Label
            // 
            Name_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Name_Label.Location = new Point(23, 3);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(54, 21);
            Name_Label.StateCommon.ShortText.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name_Label.TabIndex = 31;
            Name_Label.Values.Text = "Name";
            // 
            // CreateBudgetForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(360, 640);
            Controls.Add(MenuButton);
            Controls.Add(AppBar);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateBudgetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CreateBudgetForm_Load;
            ((System.ComponentModel.ISupportInitialize)AppBar).EndInit();
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button MenuButton;
        private PictureBox AppBar;
        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
    }
}