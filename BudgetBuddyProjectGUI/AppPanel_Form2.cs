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
using MessageBox = System.Windows.Forms.MessageBox;
using Student_Financial_Assisstance;
using BudgetBuddyProject;

namespace Budget_Buddy_GUI
{
    public partial class AppPanel_Form2 : Form
    {
        public AppPanel_Form2(BudgetActivity activity)
        {
            InitializeComponent();
            //Placeholder_BudgetActivitiesEntries_Control placeholder_BudgetActivitiesEntries_Control = new();

            //placeholder_BudgetActivitiesEntries_Control.SendToBack();
            //this.Placeholder_Panel.Controls.Add(placeholder_BudgetActivitiesEntries_Control);
            //placeholder_BudgetActivitiesEntries_Control.Controls.Add(new CreateBudgetActivity_Control(true));
            //this.Placeholder_Panel.Controls.Add(new CreateBudgetActivity_Control(true));
            // Create and add the ActivityEntriesPlaceholder_Control to the Placeholder_Panel
            /*Placeholder_ActivityEntries_Control activityEntriesControl = new Placeholder_ActivityEntries_Control(activity);
            Placeholder_Panel.Controls.Add(activityEntriesControl);*/

            // Add event handlers for the BudgetEntryAdded and BudgetEntryDeleted events of the ActivityEntriesPlaceholder_Control
            /*activityEntriesControl.BudgetEntryAdded += ActivityEntriesControl_BudgetEntryAdded;
            activityEntriesControl.BudgetEntryDeleted += ActivityEntriesControl_BudgetEntryDeleted;*/

            // Show the AddButton
            AddButton.Visible = true;
        }
        /*
                // Event handler for the BudgetEntryAdded event of the ActivityEntriesPlaceholder_Control
                private void ActivityEntriesControl_BudgetEntryAdded(object sender, BudgetEntryEventArgs e)
                {
                    // Add the new BudgetEntry to the Budget
                    budget.AddEntry(e.Entry);

                    // Refresh the UI to show the updated Budget
                    RefreshUI();
                }

                // Event handler for the BudgetEntryDeleted event of the ActivityEntriesPlaceholder_Control
                private void ActivityEntriesControl_BudgetEntryDeleted(object sender, BudgetEntryEventArgs e)
                {
                    // Remove the BudgetEntry from the Budget
                    budget.RemoveEntry(e.Entry);

                    // Refresh the UI to show the updated Budget
                    RefreshUI();
                }*/

        private void RefreshUI()
        {
            // Refresh the UI to show the updated Budget
            // For example, you could update labels or other controls to show the current state of the Budget
        }


        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            new AppPanel_Form(DataBase.Budgets.ToHashSet());
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

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            Animate(this.AddItemButton, this.Collapse_Button.Location.X, this.Collapse_Button.Location.Y, this.AddActivityButton, this.Collapse_Button.Location.X, this.Collapse_Button.Location.Y, 20);

            this.AddItemButton.Visible = this.AddActivityButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible =
                this.Collapse_Button.Visible = this.ModalOverlay.Visible = false;

            this.AddButton.Visible = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Placeholder_Panel.SendToBack();
            this.AddButton.Visible = false;

            Point point = this.AddButton.Location;

            this.Collapse_Button.Location = this.AddActivityButton.Location = this.AddItemButton.Location = new Point(276, 513);

            this.ModalOverlay.Visible = this.Collapse_Button.Visible = true;

            Animate(this.AddItemButton, this.Collapse_Button.Location.X, this.Collapse_Button.Location.Y - 70, this.AddActivityButton, this.Collapse_Button.Location.X, this.AddItemButton.Location.Y - 130, 20);

            this.AddActivityLabel.Visible = this.AddItemLabel.Visible = true;
            //MessageBox.Show($"x = {CollapseButton.Location.X}\ty  = {CollapseButton.Location.Y}");
        }

        private void ModalOverlay_Click(object sender, EventArgs e)
        {
            this.Collapse_Button.PerformClick();
        }

        private void AddActivityLabel_Click(object sender, EventArgs e)
        {
            this.AddActivityButton.PerformClick();
        }

        private void AddItemLabel_Click(object sender, EventArgs e)
        {
            this.AddItemButton.PerformClick();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            this.Placeholder_Panel.Visible = false;
        }
    }
}
