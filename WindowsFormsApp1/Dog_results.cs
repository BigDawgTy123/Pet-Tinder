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
        String Email = "";
        Form dog = null;
        public Dog_results(string name, string breed, string age, string gender, string weight, string personality, string email, Form Dog)
        {
            InitializeComponent();
            dog_results_name_textbox.Text = name;
            dog_results_breed_textbox.Text = breed;
            dog_results_age_textbox.Text = age;
            dog_results_gender_textbox.Text = gender;
            dog_results_weight_textbox.Text = weight;
            dog_results_personality_textbox.Text = personality;
            Email = email;
            dog=Dog;
            dog.Close();
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
          
            Dog_buddy Check = new Dog_buddy(Email);
            Check.ShowDialog();
            Close();
        }

        private void dog_results_no_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
