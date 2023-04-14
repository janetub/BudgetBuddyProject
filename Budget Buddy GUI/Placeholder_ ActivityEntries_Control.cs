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
        private Budget budget;

        private HashSet<EntryActivity_Control> displayedControls = new HashSet<EntryActivity_Control>();

        public ActivityEntriesPlaceholder_Control(BudgetActivity activity)
        {
            InitializeComponent();
            this.budget = budget;
            DisplayActivities();
        }

        public HashSet<BudgetActivity> Activities
        {
            get
            {
                return new HashSet<BudgetActivity>(budget.Activities);
            }
        }

        public void DisplayActivities()
        {
            // Remove any controls that are no longer needed
            foreach (var control in displayedControls.ToList())
            {
                if (!budget.Activities.Contains((BudgetActivity)control.Tag))
                {
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                }
            }

            // Add any new controls that are needed
            foreach (var activity in budget.Activities)
            {
                if (!displayedControls.Any(c => (BudgetActivity)c.Tag == activity))
                {
                    EntryActivity_Control entry = new EntryActivity_Control(activity);
                    entry.ActivityClicked += ActivityEntry_ActivitytClicked;
                    entry.DeleteButtonClicked += ActivityEntry_ActivityDeleted;
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                    displayedControls.Add(entry);
                }
            }

            // Show or hide the "No activities." label as needed
            this.NoBudget_label.Visible = (budget.Activities.Count == 0);
        }
    }
}
