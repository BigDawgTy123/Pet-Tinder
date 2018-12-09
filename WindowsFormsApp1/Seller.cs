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
    public partial class Seller : Form
    {
        String email = null;
        public Seller(string Email)
        {
            InitializeComponent();
            email = Email;
        }

        private void dog_button_Click(object sender, EventArgs e)
        {
            Dog Check = new Dog(email);
            Check.Show();
            Hide();
        }

        private void cat_button_Click(object sender, EventArgs e)
        {
            Cat Check = new Cat(email);
            Check.Show();
            Hide();
        }

        private void lizard_button_Click(object sender, EventArgs e)
        {
            Lizard Check = new Lizard(email);
            Check.Show();
            Hide();
        }

        private void buyer_back_button_Click(object sender, EventArgs e)
        {
            Welcome_Screen Check = new Welcome_Screen();
            Check.Show();
            Close();
        }
    }
}
