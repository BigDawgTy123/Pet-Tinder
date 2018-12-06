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
    public partial class Cat_results : Form
    {
        public Cat_results()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_personality_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_weight_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_gender_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_age_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_results_breed_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cat_results_no_button_Click(object sender, EventArgs e)
        {

        }

        private void cat_results_yes_button_Click(object sender, EventArgs e)
        {
            Cat_buddy Check = new Cat_buddy();
            Check.Show();
            Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Buying_Cat Check = new Buying_Cat();
            Check.Show();
            Close();
        }
    }
}
