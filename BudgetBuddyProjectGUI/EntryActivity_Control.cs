using BudgetBuddyProject;
using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy_GUI
{
    // TODO add detail if savings or expense type
    public partial class EntryActivity_Control : UserControl
    {
        public event EventHandler? OnControlClicked;
        public event EventHandler? OnDeleteButtonClicked;
        public event EventHandler? OnDeleteAndTransferButtonClicked;

        public EntryActivity_Control(BudgetActivity activity)
        {
            InitializeComponent();
            double balance = activity.Projected - activity.Actual;
            this.ActualBalanceAmount_Label.Text = balance.ToString().Contains(".") ? balance.ToString() : balance.ToString() + ".00";
            this.ActivityName_Label.Text = activity.Name;
            this.ProjectedBalanceAmount_Label.Text = "/ " + (activity.Projected.ToString().Contains(".") ? activity.Projected.ToString() : activity.Projected.ToString() + ".00");
            if (activity.ActivityType == BudgetActivityType.Savings)
            {
                this.BudgetActivityType_Label.Text = "Savings";
            }
            else
            {
                this.BudgetActivityType_Label.Visible = false;
            }
            this.Tag = activity;
        }

        private void ActivityEntry_Control_Load(object sender, EventArgs e)
        {

        }

        private void EntryActivity_Control_Click(object sender, EventArgs e)
        {
            OnControlClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this budget and transfer the amount back to the budget funds?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OnDeleteAndTransferButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            else if (result == DialogResult.No)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
