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
        String Email = "";
        Form cat = null;
        public Cat_results(string name, string breed, string age, string gender, string weight, string personality, string email, Form Cat)
        {
            InitializeComponent();
            cat_results_name_textbox.Text = name;
            cat_results_breed_textbox.Text = breed;
            cat_results_age_textbox.Text = age;
            cat_results_gender_textbox.Text = gender;
            cat_results_personality_textbox.Text = weight;
            cat_results_personality_textbox.Text = personality;
            Email = email;
            cat = Cat;
            cat.Close();
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
            Close();
        }

        private void cat_results_yes_button_Click(object sender, EventArgs e)
        {
            Cat_buddy Check = new Cat_buddy(Email);
            Check.ShowDialog();
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
