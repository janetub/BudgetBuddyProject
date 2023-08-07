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
        public event EventHandler OnEntryClicked;
        public event EventHandler OnDeleteButtonClicked;
        public EntryBudget_Control(Budget budget)
        {
            InitializeComponent();
            this.BudgetName_Label.Text = budget.Name;
            this.BudgetBalanceAmount_Label.Text = budget.Amount.ToString("N2");
            this.Tag = budget;
        }

        private void BudgetEntry_Control_Click(object sender, EventArgs e)
        {
            OnEntryClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteBudget_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this budget?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
