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
    public partial class AppPanel_Form3 : Form
    {
        public AppPanel_Form3(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.Tag = budgets;
            //CreateBudgetActivity_Control control = new(false);
            //control.Enabled = false;
        }

        private void CreateBudgetForm_Load(object sender, EventArgs e)
        {

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            new AppPanel_Form((HashSet<Budget>)this.Tag).Show();
            this.Hide();
        }
    }
}
