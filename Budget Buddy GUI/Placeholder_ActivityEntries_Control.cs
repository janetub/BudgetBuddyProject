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
    public partial class Placeholder_ActivityEntries_Control : UserControl
    {
        private HashSet<EntryActivity_Control> displayedControls = new HashSet<EntryActivity_Control>();

        public event EventHandler OnEntriesUpdated;

        public Placeholder_ActivityEntries_Control(Budget budget)
        {
            InitializeComponent();
            this.Tag = budget;
            DisplayActivities();
        }

        public void DisplayActivities()
        {
            Budget budget = (Budget)this.Tag;
            foreach (var control in displayedControls.ToList())
            {
                if (!budget.GetActivities().Any(a => a == (BudgetActivity)control.Tag))
                {
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                    OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            foreach (var activity in budget.GetActivities())
            {
                if (!displayedControls.Any(c => (BudgetActivity)c.Tag == activity))
                {
                    EntryActivity_Control act = new(activity);
                    act.OnDeleteButtonClicked += Entry_Deleted;
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Add(act);
                    displayedControls.Add(act);
                    OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                }
            }

            NoContent_label.Visible = (this.displayedControls.Count == 0);
        }

        public void Entry_Deleted(object sender, EventArgs e)
        {
            EntryActivity_Control activityEntry = (EntryActivity_Control)sender;
            BudgetActivity actEntry = (BudgetActivity)activityEntry.Tag;
            try
            {
                if (actEntry != null)
                {
                    BudgetActivity act = (BudgetActivity)this.Tag;
                    act.RemoveSubActivity(actEntry);
                    this.Tag = act;
                    OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the activity: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the activity: {ex.Message}");
            }
            finally
            {
                DisplayActivities();
            }
        }
    }
}
