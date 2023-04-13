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
    public partial class ActivityEntriesPlaceholder_Control : UserControl
    {
        private HashSet<BudgetActivity> budgets = new HashSet<BudgetActivity>();

        private HashSet<ActivityEntry_Control> displayedControls = new HashSet<ActivityEntry_Control>();

        public ActivityEntriesPlaceholder_Control(HashSet<BudgetActivity> activity)
        {
            InitializeComponent();
        }

    }
}
