using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public partial class AppPanel_Form : Form
    {
        private HashSet<Budget> budgets = new HashSet<Budget>();

        public AppPanel_Form(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            this.Placeholder_Panel.Controls.Add(new Placeholder_BudgetEntries_Control(budgets));
            this.Add_Button.Visible = true;
        }

        private void BudgetEntriesPlaceholder_BudgetEntryAdded(object sender, BudgetEventArgs e)
        {
            budgets.Add(e.Budget);
            this.Placeholder_Panel.Controls.Clear();
            Placeholder_BudgetEntries_Control placeholder_BudgetEntries_Control = new Placeholder_BudgetEntries_Control(budgets);
            this.Placeholder_Panel.Controls.Add(placeholder_BudgetEntries_Control);

            this.Add_Button.Visible = true;
        }

        private void ActivityEntryPlaceholder_BudgetEntryAdded(object sender, ActivityEventArgs e)
        {
            /*Budget budget = budgets.FirstOrDefault(b => b.Id == e.BudgetActivity.BudgetId);

            if (budget != null)
            {
                // Add the activity to the budget
                budget.Activities.Add(e.BudgetActivity);

                // Refresh the UI
                this.Placeholder_Panel.Controls.Clear();
                this.Placeholder_Panel.Controls.Add(new Placeholder_BudgetEntries_Control(budgets));
                this.Add_Button.Visible = true;
            }*/
        }

        private void ShowCreateBudgetControl()
        {
            CreateBudget_Control createBudgetControl = new CreateBudget_Control();

            createBudgetControl.BudgetEntered += BudgetEntriesPlaceholder_BudgetEntryAdded;

            this.Placeholder_Panel.Controls.Add(createBudgetControl);

            createBudgetControl.Dock = DockStyle.Fill;
        }
        private void ShowCreateBudgetActivityControl(Budget budget)
        {
            CreateBudgetActivity_Control createBudgetActivityControl = new CreateBudgetActivity_Control(true);
            createBudgetActivityControl.Tag = budget;
            createBudgetActivityControl.ActivityEntered += ActivityEntryPlaceholder_BudgetEntryAdded;

            this.Placeholder_Panel.Controls.Add(createBudgetActivityControl);

            createBudgetActivityControl.Dock = DockStyle.Fill;
        }



        private void Add_Button_Click(object sender, EventArgs e)
        {

            if (this.Placeholder_Panel.Controls.Count > 0)
            {
                var placeholderContent = this.Placeholder_Panel.Controls.OfType<Placeholder_BudgetEntries_Control>().FirstOrDefault();

                if (placeholderContent is Placeholder_BudgetEntries_Control)
                {
                    this.Placeholder_Panel.Controls.Clear();
                    this.ShowCreateBudgetControl();

                    this.Add_Button.Visible = false;
                }
                else if (placeholderContent is Placeholder_ActivityEntries_Control)
                {
                    this.Placeholder_Panel.Controls.Clear();
                    this.ShowCreateBudgetActivityControl((Budget)placeholderContent.Tag);

                    this.Add_Button.Visible = false;
                }
            }
        }

        private void AppPanel_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Placeholder_Panel.Controls.Clear();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            new AppPanel_Form2(new BudgetActivity("Saving for Inline skates", "I want to learn inline skating.", 2300, BudgetBuddyProject.BudgetActivityType.Expense)).Show();
            this.Close();
        }

        /*private void BudgetEntry_BudgetClicked(object sender, EventArgs e)
        {
            EntryBudget_Control budgetEntry = (EntryBudget_Control)sender;
            selectedBudget = (Budget)budgetEntry.Tag;

            AppPanel_Form2 form = new AppPanel_Form2(selectedBudget);

            form.ShowDialog();

            // Update the budget entries after the form is closed
            budgets = form.BudgetEntries;
            this.Placeholder_Panel.Controls.Clear();
            this.Placeholder_Panel.Controls.Add(new PlaceholderBudgetEntries_Control(budgets));
        }*/
    }
}
