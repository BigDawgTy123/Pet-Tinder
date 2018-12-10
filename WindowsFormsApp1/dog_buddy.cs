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
    public partial class Dog_buddy : Form
    {
        public Dog_buddy(string email)
        {
            InitializeComponent();
            dog_email_textbox.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dog_email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Welcome_Screen Check = new Welcome_Screen();
            Check.Show();
            Close();
        }

        private void Dog_buddy_Load(object sender, EventArgs e)
        {

        }
    }
}
