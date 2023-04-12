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
    public partial class BudgetEntry_Control : UserControl
    {
        private Budget budget;
        public event EventHandler BudgetClicked;
        public event EventHandler DeleteButtonClicked;
        public int HashCode { get; set; }
        public BudgetEntry_Control(Budget budget)
        {
            InitializeComponent();
            this.BudgetName_Label.Text = budget.Name;
            this.BudgetBalanceAmount_Label.Text = budget.Amount.ToString();
            if (!this.BudgetBalanceAmount_Label.Text.Contains("."))
            {
                this.BudgetBalanceAmount_Label.Text += ".00";
            }
        }

        public Budget Budget
        {

            get => this.budget;
        }

        private void BudgetEntry_Control_Click(object sender, EventArgs e)
        {
            // Raise the BudgetClicked event when the control is clicked
            BudgetClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteBudget_Button_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
