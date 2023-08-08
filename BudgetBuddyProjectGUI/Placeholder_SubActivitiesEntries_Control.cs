using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Student_Financial_Assisstance;
using Label = System.Windows.Forms.Label;
using UserControl = System.Windows.Forms.UserControl;

namespace Budget_Buddy_GUI
{
    public partial class Placeholder_SubActivitiesEntries_Control : UserControl
    {
        private HashSet<UserControl> displayedControls = new HashSet<UserControl>();

        public event EventHandler? OnEntriesUpdated;
        public event EventHandler? OnEditButtonClicked;
        public event EventHandler? OnBackButtonClicked;
        public event EventHandler? OnEntryClicked;

        public Placeholder_SubActivitiesEntries_Control(BudgetActivity activity)
        {
            InitializeComponent();
            this.Tag = activity;
            this.Display();
            ReloadStatusPanel();
        }

        public void ReloadStatusPanel()
        {
            BudgetActivity act = (BudgetActivity)this.Tag;
            this.PlaceHolder_StatusBar_Control.Controls.Clear();
            this.PlaceHolder_StatusBar_Control.Controls.Add(new StatusPanel(act));
        }

        public void Display()
        {
            BudgetActivity activity = (BudgetActivity)this.Tag;
            foreach (var control in displayedControls.ToList())
            {
                try
                {
                    if(control.Tag is BudgetActivity)
                    {
                        if (!activity.GetSubActivities().Any(a => a == (BudgetActivity)control.Tag))
                        {
                            this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                            displayedControls.Remove(control);
                            ReloadStatusPanel();
                            OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                        }
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the sub-activities: {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the sub-activities: {ex.Message}");
                }
                try
                {
                    if(control.Tag is Item)
                    {
                        if (!activity.GetItems().Any(i => i == (Item)control.Tag))
                        {
                            this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                            displayedControls.Remove(control);
                            ReloadStatusPanel();
                            OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                        }
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the item(s): {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the item(s): {ex.Message}");
                }

            }
            foreach (var subactivity in activity.GetSubActivities())
            {
                try
                {
                    if (!displayedControls.Any(c => c.Tag is BudgetActivity activity1 && activity1 == subactivity))
                    {
                        EntryActivity_Control act = new(subactivity);
                        act.OnDeleteButtonClicked += ActivitytEntry_Deleted;
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(act);
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.SetChildIndex(act, 0);
                        displayedControls.Add(act);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the item(s): {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the item(s): {ex.Message}");
                }
            }
            foreach (var item in activity.GetItems())
            {
                try
                {
                    if (!displayedControls.Any(c => c.Tag is Item item1 && item1 == item))
                    {
                        EntryItem_Control i = new(item);
                        i.OnDeleteButtonClicked += ItemEntry_Deleted;
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(i);
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.SetChildIndex(i, 0);
                        displayedControls.Add(i);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the sub-activities: {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the sub-activities: {ex.Message}");
                }
            }
            NoContent_label.Visible = (this.displayedControls.Count == 0);
        }

        private void ItemEntry_Deleted(object? sender, EventArgs e)
        {
            try
            {
                EntryItem_Control budgetEntry = (EntryItem_Control)sender!;
                Item item = (Item)budgetEntry.Tag;
                BudgetActivity act = (BudgetActivity)this.Tag;
                if (!act.RemoveItem(item))
                {
                    MessageBox.Show("An error occurred while deleting the item entry. Please try again.\n", "Error");
                }
                this.Tag = act;
                ReloadStatusPanel();
                OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while deleting the Item entry. Please try again.\n" + ex.Message, "Error");
            }
            finally
            {
                Display();
            }
        }

        private void ActivitytEntry_Deleted(object? sender, EventArgs e)
        {
            try
            {
                EntryActivity_Control activityEntry = (EntryActivity_Control)sender!;
                BudgetActivity subAct = (BudgetActivity)activityEntry.Tag;
                BudgetActivity act = (BudgetActivity)this.Tag;
                if (!act.RemoveSubActivity(subAct))
                {
                    MessageBox.Show("Please check for remaining balance or ongoing subactivity(ies) within the activity and try again.", "Cannot Delete Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Tag = act;
                ReloadStatusPanel();
                OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while deleting the Subativity entry. Please try again.\n" + ex.Message, "Error");
            }
            finally
            {
                Display();
            }
        }

        private void ActivityItemEntries_Control_Load(object sender, EventArgs e)
        {

        }

        private void PlaceHolder_StatusBar_Control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            OnEditButtonClicked?.Invoke(this, new EventArgs());
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, new EventArgs());
        }

        private void Information_Button_Click(object sender, EventArgs e)
        {
            ReloadStatusPanel();
            BudgetActivity activity = (BudgetActivity)this.Tag;
            // Create a new instance of the Form class
            Form detailsForm = new Form();

            // Set the form title to the activity name
            detailsForm.Text = activity.Name;

            // Create labels to display the activity details
            Label nameLabel = new Label();
            nameLabel.Text = "Name: " + activity.Name;
            nameLabel.Location = new Point(10, 10);
            detailsForm.Controls.Add(nameLabel);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Description: " + activity.Description;
            descriptionLabel.Location = new Point(10, 30);
            detailsForm.Controls.Add(descriptionLabel);

            Label projectedLabel = new Label();
            projectedLabel.Text = "Projected: " + activity.Projected;
            projectedLabel.Location = new Point(10, 50);
            detailsForm.Controls.Add(projectedLabel);

            Label actualLabel = new Label();
            actualLabel.Text = "Actual: " + activity.Actual;
            actualLabel.Location = new Point(10, 70);
            detailsForm.Controls.Add(actualLabel);

            Label activeStatus = new Label();
            activeStatus.Text = "Status: " + (activity.IsActive ? "Active" : "Inactive");
            activeStatus.Location = new Point(10, 90);
            detailsForm.Controls.Add(activeStatus);

            Label type = new Label();
            type.Text = "Type: " + (activity.ActivityType == BudgetBuddyProject.BudgetActivityType.Savings ? "Savings" : "Expense");
            type.Location = new Point(10, 110);
            detailsForm.Controls.Add(type);

            Label itemCount = new Label();
            itemCount.Text = "Item count: " + activity.Items.Count;
            itemCount.Location = new Point(10, 130);
            detailsForm.Controls.Add(itemCount);

            Label subActCount = new Label();
            subActCount.Text = "Subact count: " + activity.SubActivities.Count;
            subActCount.Location = new Point(10, 150);
            detailsForm.Controls.Add(subActCount);

            Label dateAdded = new Label();
            dateAdded.Text = "Date added: " + activity.DateAdded;
            dateAdded.Location = new Point(10, 170);
            detailsForm.Controls.Add(dateAdded);

            Label deadline = new Label();
            deadline.Text = "Deadline: " + activity.DeadLine;
            deadline.Location = new Point(10, 190);
            detailsForm.Controls.Add(deadline);

            detailsForm.StartPosition = FormStartPosition.CenterParent;

            // Show the form as a dialog box
            detailsForm.ShowDialog();
        }
    }
}
