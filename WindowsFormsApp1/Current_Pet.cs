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
    public partial class Current_Pet : Form
    {
        string email;
        public Current_Pet(string owner_email)
        {
            InitializeComponent();
            email = owner_email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Intermediate_page Check = new Intermediate_page(email);
            Check.Show();
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand
                    ("DELETE FROM "+animal_selection.SelectedItem.ToString()+" WHERE Email = '"+email+
                    "' AND Name = '"+Selected_name.SelectedItem.ToString()+"'"
                    , connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEX)
                {
                    MessageBox.Show("DELETE FROM " + animal_selection.SelectedItem.ToString() + " WHERE Email = '" + email +
                    "' AND Name = '" + Selected_name.SelectedItem.ToString() + "'"
                    );
                    MessageBox.Show(sqlEX.Message);
                }
                connection.Close();
            }
            DataTable animal = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM " + animal_selection.SelectedItem.ToString() + " WHERE Email = '" + email + "'", connection))
                {
                    try
                    {
                        adapter.Fill(animal);
                    }
                    catch (SqlException sql)
                    {
                        MessageBox.Show("Select * FROM " + animal_selection.SelectedItem + " WHERE Email = '" + email + "'");
                        MessageBox.Show(sql.ToString());
                    }
                }


            }
            animal.Columns.Remove("Email");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = animal;
            Selected_name.Items.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void animal_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable animal = new DataTable();
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM "+animal_selection.SelectedItem.ToString()+" WHERE Email = '"+email+"'", connection))
                {
                    try
                    {
                        adapter.Fill(animal);
                    }
                    catch (SqlException sql)
                    {
                        MessageBox.Show("Select * FROM " + animal_selection.SelectedItem + " WHERE Email = '" + email + "'");
                        MessageBox.Show(sql.ToString());
                    }
                }


            }
            animal.Columns.Remove("Email");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = animal;
            foreach(DataRow row in animal.Rows)
            {
                Selected_name.Items.Add(row["Name"].ToString());
            }
        }

    }
}
