﻿using Student_Financial_Assisstance;
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

    /// <summary>
    /// 
    /// </summary>
    public partial class Placeholder_ActivityEntries_Control : UserControl
    {
        private HashSet<EntryActivity_Control> displayedControls = new HashSet<EntryActivity_Control>();

        public event EventHandler? OnEntriesUpdated;
        public event EventHandler? OnEditBudgetClicked;
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
                this.BalanceAmount_Label.Text = ((Budget)Tag).Amount.ToString();
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
                    displayedControls.Add(act);
                    OnEntriesUpdated?.Invoke(this, EventArgs.Empty);
                }
            }

            NoContent_label.Visible = (this.displayedControls.Count == 0);
        }

        private void Act_OnControlClicked(object? sender, EventArgs e)
        {
            if(sender != null)
            {
                OnEntryClicked?.Invoke(sender, e);
            }
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

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            OnEditBudgetClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
