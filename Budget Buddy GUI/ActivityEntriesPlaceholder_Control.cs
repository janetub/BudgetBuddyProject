using Student_Financial_Assisstance;
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
    public partial class ActivityEntriesPlaceholder_Control : UserControl
    {
        private HashSet<BudgetActivity> activities = new HashSet<BudgetActivity>();

        private HashSet<ActivityEntry_Control> displayedControls = new HashSet<ActivityEntry_Control>();

        public ActivityEntriesPlaceholder_Control(HashSet<BudgetActivity> activity)
        {
            InitializeComponent();
            this.activities = activity;
            DisplayActivities();
        }
        
        public void DisplayActivities()
        {
            // Remove any controls that are no longer needed
            foreach (var control in displayedControls.ToList())
            {
                if (!activities.Contains((BudgetActivity)control.Tag))
                {
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                }
            }

            // Add any new controls that are needed
            foreach (var activity in activities)
            {
                if (!displayedControls.Any(c => (BudgetActivity)c.Tag == activity))
                {
                    ActivityEntry_Control entry = new ActivityEntry_Control(activity);
                    entry.ActivityClicked += ActivityEntry_ActivitytClicked;
                    entry.DeleteButtonClicked += ActivityEntry_ActivityDeleted;
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                    displayedControls.Add(entry);
                }
            }

            // Show or hide the "No activities." label as needed
            this.NoBudget_label.Visible = (activities.Count == 0);
        }

        private void ActivityEntry_ActivitytClicked(object sender, EventArgs e)
        {
            ActivityEntry_Control activityEntry = (ActivityEntry_Control)sender;
            BudgetActivity activity = (BudgetActivity)activityEntry.Tag;
            this.Tag = activity;
        }

        private void ActivityEntry_ActivityDeleted(object sender, EventArgs e)
        {
            ActivityEntry_Control budgetEntry = (ActivityEntry_Control)sender;
            BudgetActivity budget = (BudgetActivity)budgetEntry.Tag;
            try
            {
                if (budget != null)
                {
                    this.activities.Remove(budget);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the budget activity: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the budget activity: {ex.Message}");
            }
            finally
            {
                DisplayActivities();
            }
        }
    }
}
