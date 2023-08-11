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

        public EntryActivity_Control(BudgetActivity activity)
        {
            InitializeComponent();
            double balance = activity.Projected - activity.Actual;
            this.ActualBalanceAmount_Label.Text = balance.ToString("N2");
            this.ActivityName_Label.Text = activity.Name;
            ToolTip budgetType_tooolTip = new();
            ToolTip deleteButton_toolTip = new();
            deleteButton_toolTip.SetToolTip(this.Delete_Button, "Delete Actiivity");
            ToolTip actualBalanceLabel_toolTip = new();
            ToolTip projectedLabel_toolTip = new();
            if (activity.ActivityType == BudgetActivityType.Savings)
            {
                this.BudgetActivityType_Label.Text = "Savings";
                this.Balance_Label.Text = "Target:";
                this.ProjectedBalanceAmount_Label.Text = "till " + (activity.Projected.ToString("N2"));
                actualBalanceLabel_toolTip.SetToolTip(this.ActualBalanceAmount_Label, "Remaining amount to reach your main target");
                projectedLabel_toolTip.SetToolTip(this.ProjectedBalanceAmount_Label, $"Main Target Amount: {activity.Projected.ToString("N2")}");
            }
            else
            {
                this.BudgetActivityType_Label.Text = "Expense";
                this.ProjectedBalanceAmount_Label.Text = "/" + (activity.Projected.ToString("N2"));
                ToolTip nameLabel_toolTip = new();
                nameLabel_toolTip.SetToolTip(ActivityName_Label, ActivityName_Label.Text);
                actualBalanceLabel_toolTip.SetToolTip(this.ActualBalanceAmount_Label, "Remaining Activity Funds");
                projectedLabel_toolTip.SetToolTip(this.ProjectedBalanceAmount_Label, "Amount taken from Budget funds and allocated for the Activity");
            }
            budgetType_tooolTip.SetToolTip(this.BudgetActivityType_Label, this.BudgetActivityType_Label.Text);
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this budget?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EntryActivity_Control_SizeChanged(object sender, EventArgs e)
        {
            int originalControlWidth = 350;
            int originalButtonX = 321;
            int currentControlWidth = this.Size.Width;
            int newButtonX = originalButtonX - (originalControlWidth - currentControlWidth);
            this.Delete_Button.Location = new Point(newButtonX, 3);
        }
    }
}
