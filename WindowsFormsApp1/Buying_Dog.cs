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
    public partial class Buying_Dog : Form
    {
        public Buying_Dog()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buyer Check = new Buyer();
            Check.Show();
            Close();
        }
        private void Submit_click(object sender, EventArgs e)
        {
            DataTable dogs = new DataTable();
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Doggos", connection)) //, Age = IFNULL(" + comboBox2 + ", @Age), Gender = IFNULL(" + comboBox3 + ", @Gender), Weight = IFNULL(" + comboBox4 + ", @Weight), Personality = IFNULL(" + comboBox5 + ", @Personality)", connection))
                {
                    try
                    {
                        //MessageBox.Show(adapter.ToString());
                        adapter.Fill(dogs);
                    }
                    catch (SqlException sqlerror)
                    {
                        MessageBox.Show(sqlerror.ToString());
                    }
                }
            }
            foreach (DataRow row in dogs.Rows)
            {
                string email = row["Email"].ToString();
                string breed = row["Breed"].ToString();
                string name = row["Name"].ToString();
                MessageBox.Show("Email:"+email+" Breed:"+breed+"Dog Name"+name+" ");
            }
        }
        private void Buying_Dog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.doggos' table. You can move, or remove it, as needed.
           // this.doggosTableAdapter.Fill(this.database1DataSet.doggos);

        }

        private void dog_submit_button_Click(object sender, EventArgs e)
        {
            Dog_results Check = new Dog_results();
            Check.Show();
            Close();
        }
    }
}
