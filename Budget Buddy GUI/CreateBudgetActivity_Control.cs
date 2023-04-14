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
    public partial class CreateBudgetActivity_Control : UserControl
    {
        public event EventHandler<ActivityEventArgs> ActivityEntered;
        public CreateBudgetActivity_Control(bool canCreateSavings)
        {
            InitializeComponent();
            
            if (canCreateSavings)
            {
                this.ActivityType_ComboBox.DataSource = Enum.GetNames(typeof(BudgetActivityType));
            }
            else
            {
                this.ActivityType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                this.ActivityType_ComboBox.DataSource = new string[] { BudgetActivityType.Expense.ToString() };
            }
        }

        private void Name_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Name_TextBox.Text))
            {
                MessageBox.Show("Activity name is required.");
                e.Cancel = true;
                this.RequiredName_Label.Visible = true;
            }
        }

        private void ProjectedAmount_NumUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.ProjectedAmount_NumUpDown.Text) || this.ProjectedAmount_NumUpDown.Text == "0.00")
            {
                MessageBox.Show("Projected amount is required.");
                e.Cancel = true;
                this.RequiredProjectedAmount_Label.Visible = true;
            }
            if (!this.ProjectedAmount_NumUpDown.Text.Contains("."))
                this.ProjectedAmount_NumUpDown.Text += ".00";
            double budgetAmount;
            if (Double.TryParse(this.ProjectedAmount_NumUpDown.Text, out budgetAmount))
            {
                if (budgetAmount > 1000000000.00)
                {
                    MessageBox.Show("You have reached the maximum funds allowed in the app.");
                    this.ProjectedAmount_NumUpDown = null;
                }
            }
        }

        private void CreateActivity_Button_Click(object sender, EventArgs e)
        {
            if (this.ActivityType_ComboBox == null)
            {
                MessageBox.Show("Activity type is required.");
                this.RequiredActivityType_Label.Visible = true;
                return;
            }
            BudgetActivityType activityType = (BudgetActivityType)Enum.Parse(typeof(BudgetActivityType), this.ActivityType_ComboBox.Text);
            if (string.IsNullOrEmpty(this.Name_TextBox.Text) && (string.IsNullOrEmpty(ProjectedAmount_NumUpDown.Text) || ProjectedAmount_NumUpDown.Text == "0.00"))
            {
                MessageBox.Show("Please fill up all required fields to create an activity entry.");
                this.RequiredProjectedAmount_Label.Visible = this.RequiredName_Label.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(this.Name_TextBox.Text))
            {
                MessageBox.Show("Please fill up all required fields.");
                this.RequiredName_Label.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(ProjectedAmount_NumUpDown.Text) || ProjectedAmount_NumUpDown.Text == "0.00")
            {
                MessageBox.Show("Please fill up all required fields.");
                this.ProjectedAmount_NumUpDown.Visible = true;
                return;
            }
            if (!this.ProjectedAmount_NumUpDown.Text.Contains("."))
                this.ProjectedAmount_NumUpDown.Text += ".00";
            if (string.IsNullOrEmpty(this.Description_RTextBox.Text))
                this.Description_RTextBox.Text += "";
            double amount = double.Parse(ProjectedAmount_NumUpDown.Text);
            BudgetActivity newAct = new BudgetActivity(this.Name_TextBox.Text, this.Description_RTextBox.Text, amount, activityType);
            ActivityEntered?.Invoke(this, new ActivityEventArgs(newAct));

        }

        private void Name_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CreateActivity_Button.PerformClick();
            }
        }

        private void ProjectedAmount_NumUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CreateActivity_Button.PerformClick();
            }
        }

        private void Description_RTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CreateActivity_Button.PerformClick();
            }
        }

        private void ActivityType_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.ActivityType_ComboBox == null)
            {
                MessageBox.Show("Activity type is required.");
                this.RequiredActivityType_Label.Visible = true;
                return;
            }
        }
    }
}
