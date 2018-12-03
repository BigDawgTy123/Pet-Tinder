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
    public partial class Dog : Form
    {
        public Dog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dog_back_button_Click(object sender, EventArgs e)
        {
            Seller Check = new Seller();
            Check.Show();
            Close();
        }

        private void dog_submit_Click(object sender, EventArgs e)
        {
            Seller_info Check = new Seller_info();
            Check.Show();
            //Close();
        }
    }
}
