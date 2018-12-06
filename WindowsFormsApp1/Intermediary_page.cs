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
    public partial class Intermediate_page : Form
    {
        string owner_email;
        public Intermediate_page(string email_of_owner)
        {
            InitializeComponent();
            owner_email = email_of_owner;
        }

        private void list_current_pets_button_Click(object sender, EventArgs e)
        {
            Current_Pet Check = new Current_Pet(owner_email);
            Check.Show();
            Close();
        }

        private void new_pet_button_Click(object sender, EventArgs e)
        {
            Seller Check = new Seller(owner_email);
            Check.Show();
            Close();
        }

        private void intermed_back_button_Click(object sender, EventArgs e)
        {
            Welcome_Screen Check = new Welcome_Screen();
            Check.Show();
            Close();
        }
    }
}
