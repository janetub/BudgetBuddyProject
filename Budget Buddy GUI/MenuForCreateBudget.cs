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
    public partial class MenuForCreateBudget : Form
    {
        public MenuForCreateBudget()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new CreateBudget().Show();
            this.Hide();
        }
    }
}