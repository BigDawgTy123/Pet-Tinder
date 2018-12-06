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
    public partial class Welcome_Screen : Form
    {
        public Welcome_Screen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            Seller_info Check = new Seller_info();
            Check.Show();
            Hide();
        }

        private void buyerButton_Click(object sender, EventArgs e)
        {
            Buyer Check = new Buyer();
            Check.Show();
            Hide();
        }

        private void buyer2Button_Click(object sender, EventArgs e)
        {
            Buyer_Info Check = new Buyer_Info();
            Check.Show();
            Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
