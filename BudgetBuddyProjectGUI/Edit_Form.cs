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
    public partial class Edit_Form : Form
    {
        private bool isDragging;
        private Point startPoint;
        public event EventHandler? OnConfirmButtonClicked;

        public Edit_Form(Budget budget, String formName)
        {
            InitializeComponent();
            this.FormName_Label.Text = formName;
            if(formName == "Add Budget Amount")
            {
                ShowAddBudgetAmount(budget);
            }
            else
            {
                MessageBox.Show("An error occured while loading the edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormName_Label.Left = (this.ClientSize.Width - FormName_Label.Size.Width) / 2;
        }

        public void ShowAddBudgetAmount(Budget budget)
        {

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

        private void PageName_Label_SizeChanged(object? sender, EventArgs e)
        {
            FormName_Label.Left = (this.ClientSize.Width - FormName_Label.Size.Width) / 2;
        }
    }
}
