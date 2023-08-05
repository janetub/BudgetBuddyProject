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
        }

        private void Price_NumUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Price_NumUpDown.Text) || Price_NumUpDown.Text == "0.00")
            {
                MessageBox.Show("Item price is required.");
                e.Cancel = true;
                this.RequiredPrice_Label.Visible = true;
                return;
            }
            if (!this.Price_NumUpDown.Text.Contains("."))
                this.Price_NumUpDown.Text += ".00";
            double budgetAmount;
            if (Double.TryParse(this.Price_NumUpDown.Text, out budgetAmount))
            {
                if (budgetAmount > 1000000000.00)
                {
                    MessageBox.Show("You have reached the maximum item cost allowed in the app.");
                    this.Price_NumUpDown = null;
                    return;
                }
            }
        }

        private void Quantity_NumUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Quantity_NumUpDown.Text) || Quantity_NumUpDown.Text == "0")
            {
                MessageBox.Show("Quantity is required.");
                e.Cancel = true;
                this.RequiredQuantity_Label.Visible = true;
                return;
            }
            if (this.Quantity_NumUpDown.Text.Contains("."))
            {
                MessageBox.Show("Quantity must be a whole number.");
                e.Cancel = true;
                this.RequiredQuantity_Label.Visible = true;
                return;
            }
            double qty;
            if (Double.TryParse(this.Quantity_NumUpDown.Text, out qty))
            {
                if (qty > 10000000)
                {
                    MessageBox.Show("You have reached the maximum quantity allowed in the app.");
                    this.Quantity_NumUpDown = null;
                    return;
                }
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
                if (string.IsNullOrEmpty(this.Name_TextBox.Text) && (string.IsNullOrEmpty(Price_NumUpDown.Text) || Price_NumUpDown.Text == "0.00"))
                {
                    MessageBox.Show("Please fill up all required fields to create an item entry.");
                    this.RequiredName_Label.Visible = this.RequiredPrice_Label.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(this.Name_TextBox.Text))
                {
                    MessageBox.Show("Please fill up all required fields.");
                    this.RequiredName_Label.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(Price_NumUpDown.Text) || Price_NumUpDown.Text == "0")
                {
                    MessageBox.Show("Please fill up all required fields.");
                    this.RequiredQuantity_Label.Visible = true;
                    return;
                }
                int qty = int.Parse(this.Quantity_NumUpDown.Text);
                if (this.Quantity_NumUpDown.Text.Contains(".") || qty < 1)
                {
                    MessageBox.Show("Quantity must be a whole number greater than 0.");
                    this.RequiredQuantity_Label.Visible = true;
                    return;
                }
                double amount = double.Parse(Price_NumUpDown.Text);
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
                MessageBox.Show("An error occurred while validating the Item entry. Please try again.\n" + ex.Message, "Error");
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
