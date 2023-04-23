namespace Budget_Buddy_GUI
{
    partial class StatusBar
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
            Name_Label = new Krypton.Toolkit.KryptonWrapLabel();
            SuspendLayout();
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
            // StatusBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Name_Label);
            Name = "StatusBar";
            Size = new Size(360, 124);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonWrapLabel Name_Label;
    }
}
