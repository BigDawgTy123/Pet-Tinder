﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Buying_Lizard : Form
    {
        public Buying_Lizard()
        {
            InitializeComponent();
        }

        private void lizard_titlebar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buyer Check = new Buyer();
            Check.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lizard_results Check = new Lizard_results();
            Check.Show();
            Close();
        }
    }
}
