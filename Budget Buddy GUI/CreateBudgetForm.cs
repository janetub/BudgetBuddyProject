using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public partial class CreateBudgetForm : Form
    {
        public CreateBudgetForm()
        {
            InitializeComponent();
        }

        private void CreateBudgetForm_Load(object sender, EventArgs e)
        {
        }

        private void CreateBudgetButton_Click(object sender, EventArgs e)
        {

        }

        private void BudgetNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text))
            {
                MessageBox.Show("Budget name is required.");
                e.Cancel = true;
                this.RequiredName_Label.Visible = true;
            }
        }

        private void Amount_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Amount_TextBox.Text))
            {
                MessageBox.Show("Budget amount is required");
                e.Cancel = true;
                this.RequiredAmount_Label.Visible = true;
            }
        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
