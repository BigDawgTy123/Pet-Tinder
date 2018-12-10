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
    public partial class Lizard_results : Form
    {
        String Email = "";
        Form lizard = null;
        public Lizard_results(string name, string breed, string age, string gender, string weight, string personality, string email, Form Lizard)
        {
            InitializeComponent();
            lizard_results_name_texbox.Text = name;
            lizard_results_breed_texbox.Text = breed;
            lizard_results_age_texbox.Text = age;
            lizard_results_gender_texbox.Text = gender;
            lizard_results_weight_texbox.Text = weight;
            lizard_results_personality_texbox.Text = personality;
            Email = email;
            lizard = Lizard;
            lizard.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lizard_buddy Check = new Lizard_buddy(Email);
            Check.ShowDialog();
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Buying_Lizard Check = new Buying_Lizard();
            Check.Show();
            Close();
        }

        private void lizard_results_no_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
