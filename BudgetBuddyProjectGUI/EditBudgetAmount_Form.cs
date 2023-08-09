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
    public partial class EditBudgetmount_Form : Form
    {
        private bool isDragging;
        private Point startPoint;
        public event EventHandler? OnConfirmAddButtonClicked;
        public event EventHandler? OnConfirmRemoveButtonClicked;
        public double Amount;

        public EditBudgetmount_Form(String mode)
        {
            InitializeComponent();
            if (mode.ToLower() == "add")
            {
                this.FormName_Label.Text = "Add Amount";
            }
            else if (mode.ToLower() == "remove")
            {
                this.FormName_Label.Text = "Remove Amount";
            }
            this.Tag = mode.ToLower();
        }

        private void AppBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void AppBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void AppBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void ConfirmEdit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Amount_NumUpDown.Text) || Amount_NumUpDown.Text == "0.00")
                {
                    MessageBox.Show("Budget amount is required.");
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains("-"))
                {
                    MessageBox.Show("Budget amount must be a positive number.");
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
                this.Amount = double.Parse(Amount_NumUpDown.Text);
                if((String)this.Tag == "add")
                {
                    OnConfirmAddButtonClicked?.Invoke(this, new EventArgs());
                }
                else if((String)this.Tag == "remove")
                {
                    OnConfirmRemoveButtonClicked?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading Edit Budget Amount form", "Cannot edit Budget Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
