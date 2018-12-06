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
    public partial class Dog : Form
    {
        string mail = null;
        public Dog(string Email)
        {
            InitializeComponent();
            mail = Email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dog_back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dog_submit_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Doggos (Email, Name, Breed, Weight, Gender, Personality, Playfulness, Shedding, Age) VALUES " +
                    "(@Email, @Name, @Breed, @Weight, @Gender, @Personality, @Playfulness, @Shedding, @Age)", connection);
                cmd.Parameters.AddWithValue("@Email", mail);
                cmd.Parameters.AddWithValue("@Name", name_text.Text);
                cmd.Parameters.AddWithValue("@Breed", breed_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Weight", weight_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Gender", gender_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Personality", personality_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Playfulness", playfulness_combo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Shedding", shedding_combo.SelectedItem.ToString());
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
    }
}
