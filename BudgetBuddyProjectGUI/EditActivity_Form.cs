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
    public partial class EditActivity_Form : Form
    {
        public event EventHandler? OnConfirmEditClicked;
        public EditActivity_Form(BudgetActivity act)
        {
            InitializeComponent();
            this.Name_TextBox.Text = act.Name;
            this.Description_RTextBox.Text = act.Description;
            this.Tag = act;
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

        private void ConfirmEdit_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Description_RTextBox.Text))
            {
                this.Description_RTextBox.Text += "";
            }
            BudgetActivity updatedAct = (BudgetActivity)this.Tag;
            updatedAct.Name = this.Name_TextBox.Text;
            updatedAct.Description = this.Description_RTextBox.Text;
            OnConfirmEditClicked?.Invoke(this, new EventArgs());
        }
    }
}
