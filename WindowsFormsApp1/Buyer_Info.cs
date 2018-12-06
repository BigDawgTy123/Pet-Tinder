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
    public partial class Buyer_Info : Form
    {
        public Buyer_Info()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Buyer (BID, Name, Email, Phone, State, City) VALUES (@BID, @Name, @Email, @Phone, @State, @City)", connection);
                cmd.Parameters.AddWithValue("@BID", 123);
                cmd.Parameters.AddWithValue("@Name", buyer_name_info.Text);
                cmd.Parameters.AddWithValue("@Email", buyer_email_info.Text);
                cmd.Parameters.AddWithValue("@Phone", buyer_phone_info.Text);
                cmd.Parameters.AddWithValue("@State", buyer_state_info.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@City", buyer_city_info.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(SqlException sqlEX)
                {
                    MessageBox.Show(sqlEX.Message);
                }
                connection.Close();
                Close();
            }

                Close();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
