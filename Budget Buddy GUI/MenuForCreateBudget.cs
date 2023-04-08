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
    public partial class MenuForCreateBudget : Form
    {
        public MenuForCreateBudget()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new CreateBudget().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HomeClick().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
