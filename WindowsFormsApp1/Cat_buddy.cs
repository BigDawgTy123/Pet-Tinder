using System;
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
    public partial class Cat_buddy : Form
    {

        public Cat_buddy(string email)
        {
            InitializeComponent();
            cat_email_textbox.Text = email;
        }

        private void cat_email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Welcome_Screen Check = new Welcome_Screen();
            Check.Show();
            Close();
        }
    }
}
