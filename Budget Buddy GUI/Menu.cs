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
    public partial class Menu : Form
    {
        private Form previousForm;
        public Menu(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new HomeClick().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
