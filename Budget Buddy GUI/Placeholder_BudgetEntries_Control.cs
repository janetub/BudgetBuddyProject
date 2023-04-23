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

        public event EventHandler OnControlClicked;
        public event EventHandler OnControlUpdated;

        public Placeholder_BudgetEntries_Control(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.Tag = budgets;
            DisplayBudgets();
            StatusBar statusBar = new StatusBar();
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
                    entry.OnControlClicked += BudgetEntry_Clicked;
                    BudgetEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                    displayedControls.Add(entry);
                }
            }

            NoBudget_label.Visible = (budgets.Count == 0);
        }

        private void BudgetEntry_Clicked(object sender, EventArgs e)
        {
            OnControlClicked?.Invoke(sender, e);
        }

        private void BudgetEntry_Deleted(object sender, EventArgs e)
        {
            HashSet<Budget> budgets = (HashSet<Budget>)this.Tag;
            EntryBudget_Control budgetEntry = (EntryBudget_Control)sender;
            Budget budget = (Budget)budgetEntry.Tag;
            try
            {
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
