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
        public Budget SelectedBudget { get; private set; }

        public BudgetEntriesPlaceholder_Control(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            DisplayBudgets();
        }
        public void DisplayBudgets()
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
                    entry.HashCode = budget.GetHashCode();
                }
            }
        }

        private void BudgetEntry_BudgetClicked(object sender, EventArgs e)
        {
            // Set the SelectedBudget property to the Budget object corresponding to the BudgetEntry control that was clicked
            BudgetEntry_Control budgetEntry = (BudgetEntry_Control)sender;
            SelectedBudget = budgetEntry.Budget;
            this.BudgetEntryPlaceHolder_TablePanel.Controls.Clear();
            ActivityEntriesPlaceholder_Control act = new ActivityEntriesPlaceholder_Control();
this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(act);
        }

        private void BudgetEntry_BudgetDeleted(object sender, EventArgs e)
        {
            BudgetEntry_Control budgetEntry = (BudgetEntry_Control)sender;
            int hashCode = budgetEntry.HashCode;
            Budget budget = budgets.FirstOrDefault(b => b.GetHashCode() == hashCode);
            if (budget != null)
            {
                this.budgets.Remove(budget);
            }
            DisplayBudgets();
        }
    }
}
