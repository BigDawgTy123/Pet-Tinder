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
    public partial class Seller_info : Form
    {
        public Seller_info()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_click(object sender, EventArgs e)
        {
            DataTable emails = new DataTable();
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            bool login = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Seller (Email, Name, City, State, Provisions, Phone) VALUES (@Email, @Name, @City, @State, @Provisions, @Phone)", connection);
                cmd.Parameters.AddWithValue("@Email", owner_email_info.Text);
                cmd.Parameters.AddWithValue("@Name", owner_name_info.Text);
                cmd.Parameters.AddWithValue("@City", owner_city_info.Text);
                cmd.Parameters.AddWithValue("@State", owner_state_info.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Provisions", owner_provisions_info.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", owner_phone_info.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEX)
                {

                    if (sqlEX.Message.StartsWith("Violation of PRIMARY KEY constraint"))
                    {
                        MessageBox.Show("Please click login button ");
                        login = true;
                    }
                    else
                        MessageBox.Show(sqlEX.Message);
                }
                connection.Close();
                if (!login)
                {
                    Seller Check = new Seller(owner_email_info.Text);
                    Check.Show();
                    Hide();
                    Close();
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Welcome_Screen check = new Welcome_Screen();
            check.Show();
            Close();
        }

        private void Loigin_click(object sender, EventArgs e)
        {
            DataTable Emails = new DataTable();
            bool login2 = false;
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select Email FROM Seller ", connection))
                {
                    try
                    {
                        adapter.Fill(Emails);
                    }
                    catch(SqlException sql)
                    {
                        MessageBox.Show(sql.ToString());
                    }
                }

            }
            foreach (DataRow row in Emails.Rows)
            {
                if(owner_email_info.Text == row["Email"].ToString())
                {
                    Intermediate_page Check = new Intermediate_page(owner_email_info.Text);
                    Check.Show();
                    Close();
                    login2 = true;
                    break;
                }
                else
                {
                    login2 = false;
                }
            }
            if (!login2)
            {
                MessageBox.Show("Please sign in using valid Email.");
            }
              
        }
    }
}
