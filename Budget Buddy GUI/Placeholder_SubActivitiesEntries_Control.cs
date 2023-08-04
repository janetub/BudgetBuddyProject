using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Student_Financial_Assisstance;
using UserControl = System.Windows.Forms.UserControl;

namespace Budget_Buddy_GUI
{
    public partial class Placeholder_SubActivitiesEntries_Control : UserControl
    {
        private HashSet<UserControl> displayedControls = new HashSet<UserControl>();

        public event EventHandler OnEntriesUpdated;
        public Placeholder_SubActivitiesEntries_Control(BudgetActivity activity)
        {
            InitializeComponent();

            //BudgetActivity act = new("Grocery Shopping", "Groceries for first week of April.", 1000, BudgetBuddyProject.BudgetActivityType.Expense);
            //act.AddItem(new Item("Sardines", 35, 5));
            //act.AddItem(new Item("Pancit Canton", 10, 6));
            //BudgetActivity subAct = new BudgetActivity("Dinner Ingredients", "Buy dinner ingredients from the market", 100, BudgetBuddyProject.BudgetActivityType.Expense);
            // act.AddSubActivity(subAct);
            //MessageBox.Show(subAct.Actual.ToString());
            this.Tag = activity;
            this.Display();
            this.PlaceHolder_StatusBar_Control.Controls.Add(new StatusPanel(this));
        }

        public void Display()
        {
            BudgetActivity activity = (BudgetActivity)this.Tag;
            foreach (var control in displayedControls.ToList())
            {
                try
                {
                    if (!activity.GetSubActivities().Any(a => a == (BudgetActivity)control.Tag))
                    {
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                        displayedControls.Remove(control);
                        OnEntriesUpdated?.Invoke(this, new EventArgs());
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the sub-activities: {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the sub-activities: {ex.Message}");
                }
                try
                {
                    if (!activity.GetItems().Any(i => i == (Item)control.Tag))
                    {
                        this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                        displayedControls.Remove(control);
                        OnEntriesUpdated?.Invoke(this, new EventArgs());
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred while displaying the item(s): {ex.Message}");
                    MessageBox.Show($"An error occurred while displaying the item(s): {ex.Message}");
                }

            }
            if (this.Tag is BudgetActivity)
            {
                foreach (var subactivity in activity.GetSubActivities())
                {
                    try
                    {
                        if (!displayedControls.Any(c => c.Tag is BudgetActivity && (BudgetActivity)c.Tag == subactivity))
                        {
                            EntryActivity_Control act = new(subactivity);
                            act.OnDeleteButtonClicked -= ActivitytEntry_Deleted;
                            this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(act);
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
                        if (!displayedControls.Any(c => c.Tag is Item && (Item)c.Tag == item))
                        {
                            EntryItem_Control i = new(item);
                            i.OnDeleteButtonClicked -= ItemEntry_Deleted;
                            this.ActivityItemEntriesPlaceHolder_TablePanel.Controls.Add(i);
                            displayedControls.Add(i);
                        }
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine($"An error occurred while displaying the sub-activities: {ex.Message}");
                        MessageBox.Show($"An error occurred while displaying the sub-activities: {ex.Message}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            OnEntriesUpdated?.Invoke(this, new EventArgs());
        }

        private void PlaceHolder_StatusBar_Control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
