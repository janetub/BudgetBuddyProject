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
    public partial class CreateBudget : Form
    {
        public CreateBudget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BudgetCreated().Show();
            /*textBox1.Text = "Budget Name:" + textBox1.Text;
            button1 = new Button();
            button1.Text = "Budget Name:" + textBox1.Text;*/
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MenuForCreateBudget().Show();
            this.Hide();
        }

        private void CreateBudget_Load(object sender, EventArgs e)
        {

        }
    }
}
