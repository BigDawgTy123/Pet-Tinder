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
    public partial class Dog_results : Form
    {
        public Dog_results()
        {
            InitializeComponent();
        }

        private void Dog_results_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dog_results_breed_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_yes_button_Click(object sender, EventArgs e)
        {
            Dog_buddy Check = new Dog_buddy();
            Check.Show();
            Close();
        }

        private void dog_results_no_button_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Buying_Dog Check = new Buying_Dog();
            Check.Show();
            Close();
        }
    }
}
