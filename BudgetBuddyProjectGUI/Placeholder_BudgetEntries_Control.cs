using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public partial class Placeholder_BudgetEntries_Control : UserControl
    {
        private HashSet<EntryBudget_Control> displayedControls = new HashSet<EntryBudget_Control>();

        public event EventHandler? OnControlClicked;
        public event EventHandler? OnControlUpdated;

        public Placeholder_BudgetEntries_Control(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.Tag = budgets;
            DisplayBudgets();
            BudgetEntriesPlaceHolder_TablePanel.AutoScrollMargin = new Size(0, SystemInformation.VerticalScrollBarWidth);
        }

        public void DisplayBudgets()
        {
            HashSet<Budget> budgets = (HashSet<Budget>)this.Tag;
            foreach (var control in displayedControls.ToList())
            {
                if (!budgets.Contains((Budget)control.Tag))
                {
                    BudgetEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                    OnControlUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            foreach (var budget in budgets)
            {
                if (!displayedControls.Any(c => (Budget)c.Tag == budget))
                {
                    EntryBudget_Control entry = new EntryBudget_Control(budget);
                    entry.OnDeleteButtonClicked += BudgetEntry_Deleted;
                    entry.OnEntryClicked += BudgetEntry_Clicked;
                    BudgetEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                    BudgetEntriesPlaceHolder_TablePanel.Controls.SetChildIndex(entry, 0);
                    displayedControls.Add(entry);
                    OnControlUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            NoBudget_label.Visible = (budgets.Count == 0);
            if (!NoBudget_label.Visible)
            {
                Panel spacer = new();
                spacer.Height = 80;
                spacer.BackColor = Color.Transparent;
                this.BudgetEntriesPlaceHolder_TablePanel.Controls.Add(spacer);
            }
        }

        private void BudgetEntry_Clicked(object? sender, EventArgs e)
        {
            OnControlClicked?.Invoke(sender, e);
        }

        private void BudgetEntry_Deleted(object? sender, EventArgs e)
        {
            try
            {
                HashSet<Budget> budgets = (HashSet<Budget>)this.Tag;
                EntryBudget_Control budgetEntry = (EntryBudget_Control)sender!;
                Budget budget = (Budget)budgetEntry.Tag;
                if (budget != null)
                {
                    budgets.Remove(budget);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the budget: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the budget: {ex.Message}");
            }
            finally
            {
                DisplayBudgets();
            }
        }
    }
}
