using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Buddy_GUI
{
    public class ActivityEventArgs : EventArgs
    {
        public BudgetActivity Activity { get; }
        
        public ActivityEventArgs(BudgetActivity activity)
        {
            this.Activity = activity;
        }
    }
}
