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
    // TODO Content length will be limited to 100 characters (including spaces)
    public partial class CreateBudgetActivity_Control : UserControl
    {
        public event EventHandler? OnActivityEntered;
        public event EventHandler? OnBackButtonClicked;
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
            if (string.IsNullOrEmpty(this.Name_Label.Text))
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

        private void ActivityType_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.ActivityType_ComboBox == null)
            {
                MessageBox.Show("Activity type is required.");
                this.RequiredActivityType_Label.Visible = true;
                return;
            }
        }

        private void CreateActivity_Button_Click(object sender, EventArgs e)
        {
            try
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
                this.Tag = new BudgetActivity(this.Name_TextBox.Text, this.Description_RTextBox.Text, amount, activityType);
                OnActivityEntered?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void ValidateField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CreateActivity_Button.PerformClick();
            }
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
