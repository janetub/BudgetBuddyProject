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
            this.Placeholder_Panel.Controls.Add(new BudgetEntriesPlaceholder_Control(budgets));
            this.Add_Button.Visible = true;
        }

        // Method to handle the BudgetEntered event of the create budget user control
        private void BudgetEntriesPlaceholder_BudgetEntryAdded(object sender, BudgetEventArgs e)
        {
            // Add the budget object to the list of budget entries
            budgets.Add(e.Budget);
            this.Placeholder_Panel.Controls.Clear();
            this.Placeholder_Panel.Controls.Add(new BudgetEntriesPlaceholder_Control(budgets));

            this.Add_Button.Visible = true;
        }

        // Code to create and show the create budget user control
        private void ShowCreateBudgetControl()
        {
            // Create an instance of the create budget user control
            CreateBudget_Control createBudgetControl = new CreateBudget_Control();

            // Attach the BudgetEntered event handler to the user control
            createBudgetControl.BudgetEntered += BudgetEntriesPlaceholder_BudgetEntryAdded;

            // Add the user control to the panel on the main form
            this.Placeholder_Panel.Controls.Add(createBudgetControl);

            // Set the user control's Dock property to Fill so it fills the panel
            createBudgetControl.Dock = DockStyle.Fill;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            if (this.Placeholder_Panel.Controls.Count > 0)
            {
                var placeholderContent = this.Placeholder_Panel.Controls.OfType<BudgetEntriesPlaceholder_Control>().FirstOrDefault();

                if (placeholderContent is BudgetEntriesPlaceholder_Control)
                {
                    this.Placeholder_Panel.Controls.Clear();
                    this.ShowCreateBudgetControl();

                    this.Add_Button.Visible = false;
                }
                /*else if (placeholderContent is ActivityBudgetEntriesPlaceholder_Control)
                {
                    // Add activity budget code...
                }
                else if (placeholderContent is ItemEntriesPlaceholder_Control)
                {
                    // Add item code...
                }
                else
                {
                    // Unknown control type
                }*/
            }
        }

        private void AppPanel_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Placeholder_Panel.Controls.Clear();
            }
        }
    }
}
