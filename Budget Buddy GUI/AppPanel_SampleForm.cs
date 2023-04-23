using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddyProject;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public partial class AppPanel_SampleForm : Form
    {
        public AppPanel_SampleForm()
        {
            InitializeComponent();
            this.Placeholder_Panel.Controls.Add(new Placeholder_BudgetActivitiesEntries_Control(new BudgetActivity("Grocery SHopping", "For my grocery shopping", 500, BudgetActivityType.Expense)));
            this.Add_Button.Visible = true;
        }

        private void AppPanel_SampleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
