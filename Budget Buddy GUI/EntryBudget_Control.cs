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
    public partial class EntryBudget_Control : UserControl
    {
        public event EventHandler OnControlClicked;
        public event EventHandler OnDeleteButtonClicked;
        public EntryBudget_Control(Budget budget)
        {
            InitializeComponent();
            this.BudgetName_Label.Text = budget.Name;
            this.BudgetBalanceAmount_Label.Text = budget.Amount.ToString();
            if (!this.BudgetBalanceAmount_Label.Text.Contains("."))
            {
                this.BudgetBalanceAmount_Label.Text += ".00";
            }
            this.Tag = budget;
        }

        private void BudgetEntry_Control_Click(object sender, EventArgs e)
        {
            OnControlClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteBudget_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this budget?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void BudgetName_Label_Click(object sender, EventArgs e)
        {
            this.BudgetEntry_Control_Click(sender, e);
        }

        private void BudgetFundsStatus_Panel_Click(object sender, EventArgs e)
        {
            this.BudgetEntry_Control_Click(sender, e);
        }

        private void Balance_Label_Click(object sender, EventArgs e)
        {
            this.BudgetEntry_Control_Click(sender, e);
        }

        private void BudgetBalanceAmount_Label_Click(object sender, EventArgs e)
        {
            this.BudgetEntry_Control_Click(sender, e);
        }

    }
}
