﻿using System;
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
    public partial class EmptyActivity : Form
    {
        public EmptyActivity()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MenuForEmptyActivity().Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            new Adding_AnItemOrActivity().Show();
            this.Hide();
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
            new Adding_AnItemOrActivity().Show();
            this.Hide();
        }
    }
}
