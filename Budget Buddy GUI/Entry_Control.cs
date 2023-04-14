using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Buddy_GUI
{
    public class Entry_Control: UserControl
    {
        public event EventHandler ActivityClicked;
        public event EventHandler DeleteButtonClicked;

        protected virtual void OnBudgetEntryAdded(EventArgs e)
        {
            ActivityClicked?.Invoke(this, e);
        }

        protected virtual void OnBudgetEntryDeleted(EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, e);
        }
    }
}
