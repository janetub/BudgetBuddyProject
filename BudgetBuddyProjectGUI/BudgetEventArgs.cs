using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public class BudgetEventArgs : EventArgs
    {
        public Budget Budget { get; }

        public BudgetEventArgs (Budget budget)
        {
            this.Budget = budget;
        }
    }
}
