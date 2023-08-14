using Krypton.Toolkit;
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
    // TODO item controls can be added
    // TODO restrictions on number of characters or digits, limit to whats visible or add ellipses

    /// <summary>
    /// 
    /// </summary>
    public partial class Placeholder_ActivityEntries_Control : UserControl
    {
        private HashSet<EntryActivity_Control> displayedControls = new HashSet<EntryActivity_Control>();

        public event EventHandler? OnEntriesUpdated;
        public event EventHandler? OnEditBudgetClicked;
        public event EventHandler? OnAddAmountClicked;
        public event EventHandler? OnRemoveAmountClicked;
        public event EventHandler? OnBackButtonClicked;
        public event EventHandler? OnEntryClicked;

        public Placeholder_ActivityEntries_Control(Budget budget)
        {
            InitializeComponent();
            this.Tag = budget;
            DisplayStatus();
            DisplayActivities();
        }

        public void DisplayStatus()
        {
            if (this.Tag != null && this.Tag is Budget)
            {
                this.Name_Label.Text = ((Budget)Tag).Name.ToString();
                this.BalanceAmount_Label.Text = ((Budget)Tag).Amount.ToString("N2");
                ToolTip nameLabel_toolTip = new ToolTip();
                nameLabel_toolTip.SetToolTip(Name_Label, Name_Label.Text);
                /*ToolTip editButton_toolTip = new ToolTip();
                editButton_toolTip.SetToolTip(this.Edit_Button, "Edit Budget");*/
                ToolTip amount_toolTip = new ToolTip();
                amount_toolTip.SetToolTip(this.BalanceAmount_Label, "Remaining Budget funds");
            }
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
                    act.OnControlClicked += Act_OnControlClicked;
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.Add(act);
                    this.ActivityEntriesPlaceHolder_TablePanel.Controls.SetChildIndex(act, 0);
                    displayedControls.Add(act);
                    OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            NoContent_label.Visible = (this.displayedControls.Count == 0);
            if (!NoContent_label.Visible)
            {
                Panel spacer = new();
                spacer.Height = 80;
                this.ActivityEntriesPlaceHolder_TablePanel.Controls.Add(spacer);
            }
        }

        private void Act_OnControlClicked(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                OnEntryClicked?.Invoke(sender, e);
            }
        }

        public void Entry_Deleted(object? sender, EventArgs e)
        {
            try
            {
                EntryActivity_Control activityEntry = (EntryActivity_Control)sender!;
                BudgetActivity actEntry = (BudgetActivity)activityEntry.Tag;
                if (actEntry != null)
                {
                    Budget budget = (Budget)this.Tag;
                    if (!budget.RemoveActivity(actEntry))
                    {
                        if (actEntry.ActivityType == BudgetBuddyProject.BudgetActivityType.Savings)
                        {
                            MessageBox.Show("This savings have yet to reach its target amount. Please check the contributions and try again.", "Cannot Delete Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Please check for remaining balance or ongoing subactivity(ies) within the activity and try again.", "Cannot Delete Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    this.Tag = budget;
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

        /*public void Entry_DeletedAndTransfer(object? sender, EventArgs e)
        {
            try
            {
                EntryActivity_Control activityEntry = (EntryActivity_Control)sender!;
                BudgetActivity actEntry = (BudgetActivity)activityEntry.Tag;
                if (actEntry != null)
                {
                    Budget budget = (Budget)this.Tag;
                    if (!budget.RemoveActivity(actEntry))
                    {
                        MessageBox.Show("Please check for ongoing subactivity(ies) within the activity and try again.", "Cannot Delete Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    budget.AddBudgetAmount(actEntry.Projected);
                    this.Tag = budget;
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
        }*/

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            OnEditBudgetClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void ContextMenu_Button_Click(object sender, EventArgs e)
        {
            this.Activity_ContextMenu.Show(this.ContextMenu_Button, this.ContextMenu_Button.Width, this.ContextMenu_Button.Height);
        }

        private void AddAmount_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OnAddAmountClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void RemoveAmount_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OnRemoveAmountClicked?.Invoke(sender, EventArgs.Empty);
        }
    }
}
