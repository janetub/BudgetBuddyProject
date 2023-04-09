using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using Control = System.Windows.Forms.Control;
using Point = System.Drawing.Point;
using Timer = System.Windows.Forms.Timer;
using System.Windows.Media.TextFormatting;

namespace Budget_Buddy_GUI
{
    public partial class AddActivityForm : Form
    {
        public AddActivityForm()
        {
            InitializeComponent();
        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private async void Animate(Control control, int endX, int endY, int duration)
        {
            // Calculate the distance to move
            int startX = control.Location.X;
            int startY = control.Location.Y;
            int deltaX = endX - startX;
            int deltaY = endY - startY;

            // Calculate the step size for each frame
            double stepX = (double)deltaX / duration;
            double stepY = (double)deltaY / duration;

            // Get the current time
            DateTime startTime = DateTime.Now;

            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < duration)
            {
                // Calculate the position for this frame
                int newX = (int)(startX + (stepX * DateTime.Now.Subtract(startTime).TotalMilliseconds));
                int newY = (int)(startY + (stepY * DateTime.Now.Subtract(startTime).TotalMilliseconds));

                // Move the control to the new position
                control.Location = new Point(newX, newY);

                // Wait for the next frame
                await Task.Delay(10);
            }

            // Move the control to the final position
            control.Location = new Point(endX, endY);
        }




        private void AddButtonCollapsed_Click(object sender, EventArgs e)
        {
            this.CollapseButton.Location = this.AddActivityButton.Location = this.AddItemButton.Location = this.AddButtonCollapsed.Location;
            this.AddButtonCollapsed.Visible = false;
            this.CollapseButton.Visible = true;
            this.AddItemButton.Visible = true;
            Animate(this.AddItemButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y - 70, 50);
            this.AddActivityButton.Visible = true;
            Animate(this.AddActivityButton, this.CollapseButton.Location.X, this.AddItemButton.Location.Y - 136, 50);
        }

        private void roundButton21_Click(object sender, EventArgs e)
        {

        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.AddButtonCollapsed.Visible = true;
            Animate(this.AddItemButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y, 50);
            Animate(this.AddActivityButton, this.CollapseButton.Location.X, this.CollapseButton.Location.Y, 50);
            this.CollapseButton.Visible = this.AddItemButton.Visible = this.AddActivityButton.Visible = false;

        }
    }
}
