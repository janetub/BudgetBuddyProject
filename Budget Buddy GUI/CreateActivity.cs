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
    public partial class CreateActivity : Form
    {
        public CreateActivity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BudgetContents().Show();
            double maxBudget = 100, projected = 200, actual = 20;
            View_Activity1 view_Activity1 = new View_Activity1();
            view_Activity1.Show();
            this.Hide();
        }

        private void CreateActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
