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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppPanel_Form3));
            CreateBudgetInputFields_TableLayoutPanel = new TableLayoutPanel();
            Amount_Label = new Krypton.Toolkit.KryptonLabel();
            Name_Label = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Start_Button = new Button();
            CreateBudgetInputFields_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 258);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(179, 179, 179);
            label3.Location = new Point(54, 384);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 63);
            label3.TabIndex = 26;
            label3.Text = "YOUR MONEY-SAVING\r\nSIDEKICK";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(236, 154, 119);
            label2.Location = new Point(54, 216);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 40);
            label2.TabIndex = 25;
            label2.Text = "Budget Buddy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(179, 179, 179);
            label1.Location = new Point(54, 193);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Size = new Size(252, 21);
            label1.TabIndex = 24;
            label1.Text = "WELCOME TO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Start_Button
            // 
            Start_Button.BackColor = Color.FromArgb(255, 198, 50);
            Start_Button.Dock = DockStyle.Bottom;
            Start_Button.FlatAppearance.BorderSize = 0;
            Start_Button.FlatStyle = FlatStyle.Flat;
            Start_Button.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Start_Button.ForeColor = Color.Black;
            Start_Button.Location = new Point(0, 590);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(360, 50);
            Start_Button.TabIndex = 27;
            Start_Button.Text = "Tap here to start";
            Start_Button.UseVisualStyleBackColor = false;
            Start_Button.Click += Start_Button_Click;
            // 
            // AppPanel_Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(360, 640);
            Controls.Add(Start_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppPanel_Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CreateBudgetForm_Load;
            CreateBudgetInputFields_TableLayoutPanel.ResumeLayout(false);
            CreateBudgetInputFields_TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel CreateBudgetInputFields_TableLayoutPanel;
        private Krypton.Toolkit.KryptonLabel Amount_Label;
        private Krypton.Toolkit.KryptonLabel Name_Label;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Start_Button;
    }
}