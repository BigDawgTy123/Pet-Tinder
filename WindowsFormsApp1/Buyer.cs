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
    public partial class Buyer : Form
    {
        int count = new int();
        public Buyer()
        {
            InitializeComponent();
            DataTable dogs = new DataTable();
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM doggos", connection))
                {
                    adapter.Fill(dogs);
                    count += dogs.Rows.Count;
                }
            }
            DataTable cats = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Cat", connection))
                {
                    adapter.Fill(cats);
                    count += cats.Rows.Count;
                }
            }
            DataTable lizards = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Lizard", connection))
                {
                    adapter.Fill(lizards);
                    count += lizards.Rows.Count;
                }
            }
            textBox1.Text = count.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buyer_back_button_Click(object sender, EventArgs e)
        {
            Welcome_Screen Check = new Welcome_Screen();
            Check.Show();
            Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buying_Dog Check = new Buying_Dog();
            Check.Show();
            Close();
        }

        private void to_buying_lizard_page_Click(object sender, EventArgs e)
        {
            Buying_Lizard Check = new Buying_Lizard();
            Check.Show();
            Close();
        }

        private void to_buying_cat_page_Click(object sender, EventArgs e)
        {
            Buying_Cat Check = new Buying_Cat();
            Check.Show();
            Close();
        }
    }
}
