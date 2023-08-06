using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    public class ItemEventArgs : EventArgs
    {
        public Item item { get; }

        public ItemEventArgs(Item item) 
        { 
            this.item = item;
        }
    }
}
