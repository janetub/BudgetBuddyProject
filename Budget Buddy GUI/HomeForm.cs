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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MenuForm(this).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateBudget().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddActivity().Show();
            this.Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new(this);
            menuForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
