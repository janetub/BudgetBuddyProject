using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy_GUI
{
    public partial class ExpandingButtonControl : UserControl
    {
        public ExpandingButtonControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }
        // transparent background
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;  // WS_EX_TRANSPARENT
                return cp;
            }
        }
        
        // background elements become clickable
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTTRANSPARENT = (-1);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
                return;
            }

            base.WndProc(ref m);
        }
        private async void Animate(Control control1, int endX1, int endY1, Control control2, int endX2, int endY2, int duration)
        {
            control1.Visible = control2.Visible = true;
            // Calculate the distance to move for control1
            int startX1 = control1.Location.X;
            int startY1 = control1.Location.Y;
            int deltaX1 = endX1 - startX1;
            int deltaY1 = endY1 - startY1;

            // Calculate the distance to move for control2
            int startX2 = control2.Location.X;
            int startY2 = control2.Location.Y;
            int deltaX2 = endX2 - startX2;
            int deltaY2 = endY2 - startY2;

            // Calculate the step size for each frame for control1
            double stepX1 = (double)deltaX1 / duration;
            double stepY1 = (double)deltaY1 / duration;

            // Calculate the step size for each frame for control2
            double stepX2 = (double)deltaX2 / duration;
            double stepY2 = (double)deltaY2 / duration;

            // Get the current time
            DateTime startTime = DateTime.Now;

            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < duration)
            {
                // Calculate the position for this frame for control1
                int newX1 = (int)(startX1 + (stepX1 * DateTime.Now.Subtract(startTime).TotalMilliseconds));
                int newY1 = (int)(startY1 + (stepY1 * DateTime.Now.Subtract(startTime).TotalMilliseconds));

                // Calculate the position for this frame for control2
                int newX2 = (int)(startX2 + (stepX2 * DateTime.Now.Subtract(startTime).TotalMilliseconds));
                int newY2 = (int)(startY2 + (stepY2 * DateTime.Now.Subtract(startTime).TotalMilliseconds));

                // Move the controls to the new position
                control1.Location = new Point(newX1, newY1);
                control2.Location = new Point(newX2, newY2);

                // Wait for the next frame
                await Task.Delay(10);
            }

            // Move the controls to the final position
            control1.Location = new Point(endX1, endY1);
            control2.Location = new Point(endX2, endY2);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.AddButton.Visible = false;

            this.CollapseButton.Location = this.AddActivityButton.Location = this.AddItemButton.Location = this.AddButton.Location;

            this.ModalOverlay.Visible = true;

            this.CollapseButton.Visible = true;

            Animate(this.AddItemButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y - 70, this.AddActivityButton, this.CollapseButton.Location.X, this.AddItemButton.Location.Y - 136, 50);

            this.AddActivityLabel.Visible = this.AddItemLabel.Visible = true;
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            Animate(this.AddItemButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y, this.AddActivityButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y, 50);

            this.AddItemButton.Visible = this.AddActivityButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible =
                this.CollapseButton.Visible = false;

            this.ModalOverlay.Visible = false;
            this.ModalOverlay.SendToBack();

            this.AddButton.Visible = true;
        }

    }
}
