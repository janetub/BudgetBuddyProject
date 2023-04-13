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
    public partial class BudgetEntriesPlaceholder_Control : UserControl
    {
        private HashSet<Budget> budgets = new HashSet<Budget>();

        //selected budget is in tag

        public BudgetEntriesPlaceholder_Control(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            DisplayBudgets();
        }
        /*public void DisplayBudgets()
        {
            this.BudgetEntryPlaceHolder_TablePanel.Controls.Clear();
            if (this.budgets.Count < 1)
                this.NoBudget_label.Visible = true;
            else
            {
                this.NoBudget_label.Visible = false;
                foreach (var budget in this.budgets)
                {
                    BudgetEntry_Control entry = new BudgetEntry_Control(budget);
                    entry.BudgetClicked += BudgetEntry_BudgetClicked;
                    entry.DeleteButtonClicked += BudgetEntry_BudgetDeleted;
                    this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(entry);
                }
            }
        }*/

        private HashSet<BudgetEntry_Control> displayedControls = new HashSet<BudgetEntry_Control>();

        public void DisplayBudgets()
        {
            // Remove any controls that are no longer needed
            foreach (var control in displayedControls.ToList())
            {
                if (!budgets.Contains((Budget)control.Tag))
                {
                    BudgetEntriesPlaceHolder_TablePanel.Controls.Remove(control);
                    displayedControls.Remove(control);
                }
            }

            // Add any new controls that are needed
            foreach (var budget in budgets)
            {
                if (!displayedControls.Any(c => (Budget)c.Tag == budget))
                {
                    BudgetEntry_Control entry = new BudgetEntry_Control(budget);
                    entry.BudgetClicked += BudgetEntry_BudgetClicked;
                    entry.DeleteButtonClicked += BudgetEntry_BudgetDeleted;
                    BudgetEntriesPlaceHolder_TablePanel.Controls.Add(entry);
                    displayedControls.Add(entry);
                }
            }

            // Show or hide the "No budgets" label as needed
            NoBudget_label.Visible = (budgets.Count == 0);
        }

        private void BudgetEntry_BudgetClicked(object sender, EventArgs e)
        {
            BudgetEntry_Control budgetEntry = (BudgetEntry_Control)sender;
            Budget budget = (Budget)budgetEntry.Tag;
            this.Tag = budget;
        }

        private void BudgetEntry_BudgetDeleted(object sender, EventArgs e)
        {
            BudgetEntry_Control budgetEntry = (BudgetEntry_Control)sender;
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
                MessageBox.Show("An error occurred while deleting the budget: {ex.Message}");
            }
            finally
            {
                DisplayBudgets();
            }
        }
    }
}
