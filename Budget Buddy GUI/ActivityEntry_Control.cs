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
    public partial class ActivityEntry_Control : UserControl
    {
        public event EventHandler ActivityClicked;
        public event EventHandler DeleteButtonClicked;
        public ActivityEntry_Control(BudgetActivity budgetActivity)
        {
            InitializeComponent();
            this.ActivityName_Label.Text = budgetActivity.Name;
            this.ActualBalanceAmount_Label.Text = budgetActivity.Actual.ToString();
            this.ProjectedBalanceAmount_Label.Text = budgetActivity.Projected.ToString();
            this.Tag = budgetActivity;
            if (!this.ActualBalanceAmount_Label.Text.Contains("."))
            {
                this.ActualBalanceAmount_Label.Text += ".00";
            }
            if (!this.ProjectedBalanceAmount_Label.Text.Contains("."))
            {
                this.ProjectedBalanceAmount_Label.Text += ".00";
            }

        }

        private void ActivityEntry_Control_Load(object sender, EventArgs e)
        {
            ActivityClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ActivityEntry_Control_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
