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
<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1b193d40ef3835605b5ca55803473616f667b7da
                                    this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(entry);
                    this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(entry);
<<<<<<< HEAD
                    this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(entry);
=======
>>>>>>> c4a5d01 (added forms and user controls for ceating a budget)
=======
                    this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(entry);
>>>>>>> c4a5d0191eb69cd43b9f678fe9a1be19856814fc
>>>>>>> 1b193d40ef3835605b5ca55803473616f667b7da
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1b193d40ef3835605b5ca55803473616f667b7da
            ActivityEntriesPlaceholder_Control act = new ActivityEntriesPlaceholder_Control();
this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(act);
            this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(new ActivityEntriesPlaceholder_Control());
<<<<<<< HEAD
            this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(new ActivityEntriesPlaceholder_Control());
=======
>>>>>>> c4a5d01 (added forms and user controls for ceating a budget)
=======
            this.BudgetEntryPlaceHolder_TablePanel.Controls.Add(new ActivityEntriesPlaceholder_Control());
>>>>>>> c4a5d0191eb69cd43b9f678fe9a1be19856814fc
>>>>>>> 1b193d40ef3835605b5ca55803473616f667b7da
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
