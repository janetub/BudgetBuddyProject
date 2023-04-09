namespace Budget_Buddy_GUI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label1 = new Label();
            panel2 = new Panel();
            menuButton = new PictureBox();
            Menu = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Menu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(86, 51);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 9;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 178, 30);
            panel2.Controls.Add(menuButton);
            panel2.Controls.Add(Menu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 30);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.FromArgb(255, 178, 30);
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(8, 7);
            menuButton.Margin = new Padding(2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(24, 24);
            menuButton.SizeMode = PictureBoxSizeMode.AutoSize;
            menuButton.TabIndex = 15;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(255, 178, 30);
            Menu.Location = new Point(8, 7);
            Menu.Margin = new Padding(2);
            Menu.Name = "Menu";
            Menu.Size = new Size(24, 24);
            Menu.SizeMode = PictureBoxSizeMode.AutoSize;
            Menu.TabIndex = 8;
            Menu.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 178, 30);
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 99);
            button1.Name = "button1";
            button1.Size = new Size(252, 41);
            button1.TabIndex = 12;
            button1.Text = "Create Budget";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 178, 30);
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 178);
            button2.Name = "button2";
            button2.Size = new Size(252, 41);
            button2.TabIndex = 13;
            button2.Text = "Analytics";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 178, 30);
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 139);
            button3.Name = "button3";
            button3.Size = new Size(252, 41);
            button3.TabIndex = 14;
            button3.Text = "Budget Created";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 384);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeClick";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private PictureBox Menu;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox menuButton;
    }
}