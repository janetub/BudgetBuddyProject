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
        private double budgetAmount;
        public event EventHandler? OnConfirmAddButtonClicked;
        public event EventHandler? OnConfirmRemoveButtonClicked;
        public double Amount;

        public EditBudgetmount_Form(String mode, Budget budget)
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
            this.budgetAmount = budget.Amount;
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
                    MessageBox.Show("Please fill up all required fields to create a budget entry.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (this.Amount_NumUpDown.Text.Contains('-'))
                {
                    MessageBox.Show("Budget amount must be a positive number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                double budgetAmount;
                this.Amount = double.Parse(Amount_NumUpDown.Text);
                if ((String)this.Tag == "add")
                {
                    if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                    {
                        if ((budgetAmount + this.budgetAmount) > 999999999999.99)
                        {
                            MessageBox.Show("You have reached the maximum budget funds allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if ((budgetAmount + this.budgetAmount) < 1)
                        {
                            MessageBox.Show("You have reached the minimum budget funds allowed in the app.", "Minimum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    OnConfirmAddButtonClicked?.Invoke(this, new EventArgs());
                }
                else if ((String)this.Tag == "remove")
                {
                    if (Double.TryParse(this.Amount_NumUpDown.Text, out budgetAmount))
                    {
                        if ((this.budgetAmount - budgetAmount) > 999999999999.99)
                        {
                            MessageBox.Show("You have reached the maximum budget funds allowed in the app.", "Maximum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if ((this.budgetAmount - budgetAmount) < 1)
                        {
                            MessageBox.Show("You have reached the minimum budget funds allowed in the app.", "Minimum Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    OnConfirmRemoveButtonClicked?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}", "Cannot Validate Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
