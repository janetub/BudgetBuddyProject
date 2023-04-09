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
    public partial class BudgetCreated : Form
    {
        public BudgetCreated()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MenuForm(this).Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            new CreateBudget().Show();
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            new CreateBudget().Show();
            this.Hide();
        }
    }
}
