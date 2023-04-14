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
        public event EventHandler<ItemEventArgs> ItemEntered;
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

        private void Name_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AddItem_Button.PerformClick();
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

        }

        private void Tags_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Quantity_NumUpDown_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Price_NumUpDown_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // passed
            }
            else
            {
                MessageBox.Show("Please fill out all required fields to create an item entry.");
                this.RequiredName_Label.Visible = this.RequiredPrice_Label.Visible = true;
                return;
            }
        }
    }
}
