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
    public partial class Lizard : Form
    {
        public Lizard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lizard_back_button_Click(object sender, EventArgs e)
        {
            //Seller Check = new Seller();
           // Check.Show();
            Close();
        }

        private void lizard_submit_Click(object sender, EventArgs e)
        {
            Seller_info Check = new Seller_info();
            Check.Show();
            //Close();
        }
    }
}
