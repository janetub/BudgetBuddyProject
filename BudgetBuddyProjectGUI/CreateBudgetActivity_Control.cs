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
            int maxLength = 100;
            if (Name_TextBox.Text.Length > maxLength)
            {
                MessageBox.Show($"Budget name must be no more than {maxLength} characters.");
                e.Cancel = true;
                this.RequiredName_Label.Visible = true;
            }
        }

        private void ProjectedAmount_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ProjectedAmount_NumUpDown.Text) || ProjectedAmount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Projected amount is required.");
                    this.RequiredProjectedAmount_Label.Visible = true;
                    return;
                }
                if (this.ProjectedAmount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Projected amount must be a positive number.");
                    this.RequiredProjectedAmount_Label.Visible = true;
                    return;
                }
                double projectedAmount;
                if (Double.TryParse(this.ProjectedAmount_NumUpDown.Text, out projectedAmount))
                {
                    if (projectedAmount > 9999999999.99)
                    {
                        MessageBox.Show("You have reached the maximum projected amount allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.RequiredName_Label.Visible = string.IsNullOrEmpty(this.Name_TextBox.Text);
                this.RequiredProjectedAmount_Label.Visible = string.IsNullOrEmpty(this.ProjectedAmount_NumUpDown.Text) || this.ProjectedAmount_NumUpDown.Text == "0.00";
                this.RequiredActivityType_Label.Visible = (this.ActivityType_ComboBox == null);
                if (string.IsNullOrEmpty(this.Name_TextBox.Text) || (string.IsNullOrEmpty(ProjectedAmount_NumUpDown.Text) || ProjectedAmount_NumUpDown.Text == "0.00") || (this.ActivityType_ComboBox == null))
                {
                    MessageBox.Show("Please fill up all required fields to create an activity entry.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (this.ProjectedAmount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Projected amount must be a positive number.");
                    this.ProjectedAmount_NumUpDown.Visible = true;
                    return;
                }
                double projectedAmount;
                if (Double.TryParse(this.ProjectedAmount_NumUpDown.Text, out projectedAmount))
                {
                    if (projectedAmount > 9999999999.99)
                    {
                        MessageBox.Show("You have reached the maximum projected amount allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(this.Description_RTextBox.Text))
                {
                    this.Description_RTextBox.Text += "";
                }
                BudgetActivityType activityType = (BudgetActivityType)Enum.Parse(typeof(BudgetActivityType), this.ActivityType_ComboBox.Text);
                double amount = double.Parse(ProjectedAmount_NumUpDown.Text);
                this.Tag = new BudgetActivity(this.Name_TextBox.Text, this.Description_RTextBox.Text, amount, activityType);
                OnActivityEntered?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Budget Activity Input Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
