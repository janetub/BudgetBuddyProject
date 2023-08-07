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
    public partial class CreateBudget_Control : UserControl
    {
        public event EventHandler OnBudgetCreated;
        public event EventHandler OnBackButtonClicked;

        public CreateBudget_Control()
        {
            InitializeComponent();
        }

        private void CreateBudget_Control_Load(object sender, EventArgs e)
        {

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

        private void Amount_NumUpDown_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Budget amount is required.");
                    e.Cancel = true;
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Budget amount must be a positive number.");
                    e.Cancel = true;
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
                        MessageBox.Show("You have reached the maximum budget/funds allowed in the app.");
                        this.Amount_NumUpDown = null;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateBudgetButton_Click(object sender, EventArgs e)
        {
            try
            {
                double budgetAmount;
                if (string.IsNullOrEmpty(this.Name_TextBox.Text) && (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00"))
                {
                    MessageBox.Show("Please fill up all required fields to create a budget entry.");
                    this.RequiredAmount_Label.Visible = true;
                    this.RequiredName_Label.Visible = true;
                    return;
                }
                else if (string.IsNullOrEmpty(this.Name_TextBox.Text))
                {
                    MessageBox.Show("Please fill up all required fields");
                    this.RequiredName_Label.Visible = true;
                    return;
                }
                else if (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Please fill up all required fields");
                    this.RequiredAmount_Label.Visible = true;
                    return;
                }
                else if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                {
                    if (budgetAmount > 1000000000.00)
                    {
                        MessageBox.Show("You have reached the maximum budget/funds allowed in the app.");
                        this.Amount_NumUpDown = null;
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
            }
        }
        public void CloseControl()
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void Amount_NumUpDown_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.CreateBudgetButton.PerformClick();
            }
        }

        private void Name_TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
    }
}
