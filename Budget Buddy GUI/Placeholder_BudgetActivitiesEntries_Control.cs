using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public partial class Placeholder_BudgetActivitiesEntries_Control : UserControl
    {
        private HashSet<UserControl> displayedControls = new HashSet<UserControl>();

        public event EventHandler OnEntriesUpdated;
        public Placeholder_BudgetActivitiesEntries_Control(BudgetActivity activity)
        {
            InitializeComponent();
            this.Tag = activity;
            this.Display();
        }

        public void Display()
        {
            BudgetActivity activity = (BudgetActivity)this.Tag;
            foreach (var control in displayedControls.ToList())
            {
                if (!activity.GetSubActivities().Any(a => a == (BudgetActivity)control.Tag))
                {
                    this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                    OnEntriesUpdated?.Invoke(this, new EventArgs());
                }
                if (!activity.GetItems().Any(i => i == (Item)control.Tag))
                {
                    this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                    OnEntriesUpdated?.Invoke(this, new EventArgs());
                }
            }
            if(this.Tag is BudgetActivity)
            {
                foreach (var subactivity in  activity.GetSubActivities())
                {
                    if(!displayedControls.Any(c => (BudgetActivity)c.Tag == subactivity))
                    {
                        EntryActivity_Control act = new(subactivity);
                        act.OnDeleteButtonClicked -= ActivitytEntry_Deleted;
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(act);
                        displayedControls.Add(act);
                    }
                }
                foreach (var item in activity.GetItems())
                {
                    if(!displayedControls.Any(c => (Item)c.Tag == item))
                    {
                        EntryItem_Control i = new(item);
                        i.OnDeleteButtonClicked -= ItemEntry_Deleted;
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(i);
                        displayedControls.Add(i);
                    }
                }
            }

            NoContent_label.Visible = (this.displayedControls.Count == 0);
        }

        private void ItemEntry_Deleted(object sender, EventArgs e)
        {
            EntryItem_Control budgetEntry = (EntryItem_Control)sender;
            Item item = (Item)budgetEntry.Tag;
            try
            {
                if (item != null)
                {
                    BudgetActivity act = (BudgetActivity)this.Tag;
                    act.RemoveItem(item);
                    this.Tag = act;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the item: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}");
            }
            finally
            {
                Display();
            }
        }

        private void ActivitytEntry_Deleted(object sender, EventArgs e)
        {
            EntryActivity_Control activityEntry = (EntryActivity_Control)sender;
            BudgetActivity subAct = (BudgetActivity)activityEntry.Tag;
            try
            {
                if (subAct != null)
                {
                    BudgetActivity act = (BudgetActivity)this.Tag;
                    act.RemoveSubActivity(subAct);
                    this.Tag = act;
                    OnEntriesUpdated?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the sub-activity: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the sub-activity: {ex.Message}");
            }
            finally
            {
                Display();
            }
        }

        private void ActivityItemEntries_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
