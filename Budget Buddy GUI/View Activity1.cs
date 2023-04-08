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
    public partial class View_Activity1 : Form
    {
        public View_Activity1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmptyActivity().Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
