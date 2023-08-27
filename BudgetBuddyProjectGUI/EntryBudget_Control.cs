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
        public event EventHandler? OnEntryClicked;
        public event EventHandler? OnDeleteButtonClicked;
        public EntryBudget_Control(Budget budget)
        {
            InitializeComponent();
            this.BudgetName_Label.Text = budget.Name;
            this.BudgetBalanceAmount_Label.Text = budget.Amount.ToString("N2");
            ToolTip nameLabel_toolTip = new ToolTip();
            nameLabel_toolTip.SetToolTip(BudgetName_Label, BudgetName_Label.Text);
            ToolTip budgetBalanceLabel_toolTip = new();
            budgetBalanceLabel_toolTip.SetToolTip(this.BudgetBalanceAmount_Label, "Remaining Budget Funds");
            ToolTip deleteButton_toolTip = new();
            deleteButton_toolTip.SetToolTip(this.Delete_Button, "Delete Budget");
            this.Tag = budget;
        }

        private void BudgetEntry_Control_Click(object sender, EventArgs e)
        {
            OnEntryClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteBudget_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this budget?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EntryBudget_Control_SizeChanged(object sender, EventArgs e)
        {
            int originalControlWidth = 350;
            int originalButtonX = 321;
            int currentControlWidth = this.Size.Width;
            int newButtonX = originalButtonX - (originalControlWidth - currentControlWidth);
            this.Delete_Button.Location = new Point(newButtonX, 3);
        }
    }
}
