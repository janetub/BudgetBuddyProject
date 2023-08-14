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
    // TODO cleanup validations
    public partial class CreateBudget_Control : UserControl
    {
        public event EventHandler? OnBudgetCreated;
        public event EventHandler? OnBackButtonClicked;

        public CreateBudget_Control()
        {
            InitializeComponent();
        }

        private void Name_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text))
            {
                MessageBox.Show("Budget name is required.");
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

        private void Amount_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Budget amount is required.");
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Budget amount must be a positive number.");
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                double budgetAmount;
                if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                {
                    if (budgetAmount > 9999999999.99)
                    {
                        MessageBox.Show("You have reached the maximum budget allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CreateBudgetButton_Click(object sender, EventArgs e)
        {
            try
            {
                double budgetAmount;
                this.RequiredName_Label.Visible = string.IsNullOrEmpty(this.Name_TextBox.Text);
                this.RequiredAmount_Label.Visible = string.IsNullOrEmpty(this.Amount_NumUpDown.Text) || this.Amount_NumUpDown.Text == "0.00";
                if (string.IsNullOrEmpty(this.Name_TextBox.Text) || (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00"))
                {
                    MessageBox.Show("Please fill up all required fields to create a budget entry.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Budget amount must be a positive number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                {
                    if (budgetAmount > 999999999999.99)
                    {
                        MessageBox.Show("You have reached the maximum budget funds allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.RequiredAmount_Label.Visible = true;
                        return;
                    }
                    if (budgetAmount < 1)
                    {
                        MessageBox.Show("You have reached the minimum budget funds allowed in the app.", "Minimum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                double amount = double.Parse(Amount_NumUpDown.Text);
                Budget newBudget = new(this.Name_TextBox.Text, amount);
                this.Tag = newBudget;
                OnBudgetCreated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Budget Input Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CreateBudgetButton.PerformClick();
            }

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        /*private void Amount_NumUpDown_VueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Budget amount is required.");
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Budget amount must be a positive number.");
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                if (!this.Amount_NumUpDown.Text.Contains("."))
                    this.Amount_NumUpDown.Text += ".00";
                double budgetAmount;
                if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                {
                    if (budgetAmount > 1000000000.00)
                    {
                        MessageBox.Show("You have reached the maximum budget/funds allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Amount_NumUpDown = null;
                        this.Amount_NumUpDown = null;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}
