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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Budget_Buddy_GUI
{
    public partial class CreateItem_Control : UserControl
    {
        public event EventHandler? OnItemCreationConfirmed;
        public event EventHandler? OnBackButtonClicked;
        public CreateItem_Control()
        {
            InitializeComponent();
        }

        private void Name_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text))
            {
                MessageBox.Show("Item name is required.");
                e.Cancel = true;
                this.RequiredName_Label.Visible = true;
            }
            int maxLength = 100;
            if (Name_TextBox.Text.Length > maxLength)
            {
                MessageBox.Show($"Item name must be no more than {maxLength} characters.");
                e.Cancel = true;
                this.RequiredName_Label.Visible = true;
            }
        }

        private void Cost_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.RequiredCost_Label.Visible = true;
                if (string.IsNullOrEmpty(Cost_NumUpDown.Text) || Cost_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Item cost is required.");
                    return;
                }
                if (this.Cost_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Item cost must be a positive number.");
                    return;
                }
                double itemCost;
                if (Double.TryParse(this.Cost_NumUpDown.Text, out itemCost))
                {
                    if (itemCost > 999999.99)
                    {
                        MessageBox.Show("You have reached the maximum item cost allowed in the app.", "Maximum Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                this.RequiredCost_Label.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Cost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Quantity_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.RequiredQuantity_Label.Visible = true;
                if (string.IsNullOrEmpty(Quantity_NumUpDown.Text) || Quantity_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Item quantity is required.");
                    return;
                }
                if (this.Quantity_NumUpDown.Text.Contains("-") || this.Quantity_NumUpDown.Text.Contains("."))
                {
                    MessageBox.Show("Item quantity must be a positive whole number.");
                    return;
                }
                double itemCost;
                if (Double.TryParse(this.Quantity_NumUpDown.Text, out itemCost))
                {
                    if (itemCost > 999999.99)
                    {
                        MessageBox.Show("You have reached the maximum item cost allowed in the app.", "Maximum Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                this.RequiredQuantity_Label.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tags_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tag = Tags_ComboBox.Text;
                if (!string.IsNullOrWhiteSpace(tag) && !Tags_ComboBox.Items.Contains(tag))
                {
                    Tags_ComboBox.Items.Add(tag);
                }
                Tags_ComboBox.Text = "";
            }
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.RequiredName_Label.Visible = string.IsNullOrEmpty(this.Name_TextBox.Text);
                this.RequiredQuantity_Label.Visible = (string.IsNullOrEmpty(Quantity_NumUpDown.Text) || Quantity_NumUpDown.Text == "0.00");
                this.RequiredCost_Label.Visible = (string.IsNullOrEmpty(Cost_NumUpDown.Text) || Cost_NumUpDown.Text == "0.00");
                if (this.Quantity_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Item quantity must be a positive number.");
                    this.RequiredQuantity_Label.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(this.Name_TextBox.Text) || (string.IsNullOrEmpty(Cost_NumUpDown.Text) || Cost_NumUpDown.Text == "0.00"))
                {
                    MessageBox.Show("Please fill up all required fields to create an activity entry.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (this.Quantity_NumUpDown.Text.Contains("-") || this.Quantity_NumUpDown.Text.Contains("."))
                {
                    MessageBox.Show("Item quantity must be a positive whole number.");
                    this.RequiredQuantity_Label.Visible = true;
                    return;
                }
                int qty = int.Parse(this.Quantity_NumUpDown.Text);
                double amount = double.Parse(Cost_NumUpDown.Text);
                Item newItem = new(this.Name_TextBox.Text, amount, qty);
                if (Tags_ComboBox.Items.Count > 0)
                {
                    foreach (string t in Tags_ComboBox.Items)
                    {
                        newItem.AddTag(t);
                    }
                }
                this.Tag = newItem;
                OnItemCreationConfirmed?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred while validating the Item entry. Please try again.\nError: {ex.Message}", "Cannot Validate Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AddItem_Button.PerformClick();
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
