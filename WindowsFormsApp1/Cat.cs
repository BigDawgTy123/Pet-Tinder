using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Cat : Form
    {
        string mail = null;

        public Cat(String Email)
        {
            InitializeComponent();
            mail = Email;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CAT (Email, Name, Breed, Weight, Gender, Personality, Laziness, Age) VALUES " +
                    "(@Email, @Name, @Breed, @Weight, @Gender, @Personality, @Laziness, @Age)", connection);
                cmd.Parameters.AddWithValue("@Email", mail);
                cmd.Parameters.AddWithValue("@Name", name_input.Text);
                cmd.Parameters.AddWithValue("@Breed", breed_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Weight", weight_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Gender", gender_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Personality", personality_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Laziness", laziness_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Age", age_combo.SelectedItem.ToString());
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEX)
                {
                    MessageBox.Show(sqlEX.Message);
                }
                connection.Close();

            }
            Intermediate_page Check = new Intermediate_page(mail);
            Check.Show();
            Close();
        }

        private void Cat_Load(object sender, EventArgs e)
        {

        }

        private void laziness_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void pensonality_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cat_back_button_Click(object sender, EventArgs e)
        {
            Seller Check = new Seller(mail);
            Check.Show();
            Close();
        }
    }
}
