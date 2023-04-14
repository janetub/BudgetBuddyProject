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
        private HashSet<Budget> budgets = new HashSet<Budget>();
        private HashSet<EntryBudget_Control> displayedControls = new HashSet<EntryBudget_Control>();

        public event EventHandler<EntryBudget_Control> Deleted;
        public event EventHandler<EntryBudget_Control> Added;


        public Placeholder_BudgetEntries_Control(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            DisplayBudgets();
        }
        
        public void DisplayBudgets()
        {

        foreach (var control in displayedControls.ToList())
        {
            if (!this.budgets.Contains((Budget)control.Tag))
            {
                BudgetEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                displayedControls.Remove(control);

                Deleted?.Invoke(this, control);
            }
        }

        foreach (var budget in this.budgets)
        {
            if (!displayedControls.Any(c => (Budget)c.Tag == budget))
            {
                EntryBudget_Control entry = new EntryBudget_Control(budget);
                entry.BudgetClicked += BudgetEntry_BudgetClicked;
                entry.DeleteButtonClicked += BudgetEntry_BudgetDeleted;
                BudgetEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                displayedControls.Add(entry);

                Added?.Invoke(this, entry);
            }
        }

        NoBudget_label.Visible = (budgets.Count == 0);
        }

        private void BudgetEntry_BudgetClicked(object sender, EventArgs e)
        {
            EntryBudget_Control budgetEntry = (EntryBudget_Control)sender;
            Budget budget = (Budget)budgetEntry.Tag;
            this.Tag = budget;
        }

        private void BudgetEntry_BudgetDeleted(object sender, EventArgs e)
        {
            EntryBudget_Control budgetEntry = (EntryBudget_Control)sender;
            Budget budget = (Budget)budgetEntry.Tag;
            try
            {
                if (budget != null)
                {
                    this.budgets.Remove(budget);
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
