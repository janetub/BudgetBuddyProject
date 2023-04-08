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
    public partial class Adding_AnItemOrActivity : Form
    {
        public Adding_AnItemOrActivity()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            new EmptyActivity().Show();
            this.Hide();
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            new AddItem().Show();
            this.Hide();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            new CreateActivity().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Adding_AnItemOrActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
