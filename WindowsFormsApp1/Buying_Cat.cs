﻿using System;
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
    public partial class Buying_Cat : Form
    {
        public Buying_Cat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buyer Check = new Buyer();
            Check.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable cats = new DataTable();
            String Breed = null;
            String Age = null;
            String Gender = null;
            String Personality = null;
            if (comboBox1.SelectedItem == null)
            {
                Breed = "Breed IS NOT NULL";
            }
            else
            {
                Breed = "Breed = '" + comboBox1.SelectedItem.ToString() + "'";
                MessageBox.Show(Breed);
            }
            if (comboBox2.SelectedItem == null)
            {
                Age = "Age IS NOT NULL";
            }
            else
            {
                Age = "Age = '" + comboBox2.SelectedItem.ToString() + "'";
                MessageBox.Show(Age);
            }
            if (comboBox3.SelectedItem == null)
            {
                Gender = "Gender IS NOT NULL";
            }
            else
            {
                Gender = "Gender = '" + comboBox3.SelectedItem.ToString() + "'";
                MessageBox.Show(Gender);
            }
            if (comboBox4.SelectedItem == null)
            {
                Personality = "Personality IS NOT NULL";
            }
            else
            {
                Personality = "Personality = '" + comboBox4.SelectedItem.ToString() + "'";
                MessageBox.Show(Personality);
            }

            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {



                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CAT Where " + Breed + " AND " + Age + " AND " + Gender + " AND " + Personality, connection))
                {
                    try
                    {
                        adapter.Fill(cats);
                    }
                    catch (SqlException sqlerror)
                    {
                        MessageBox.Show(sqlerror.ToString());
                    }


                }
                foreach (DataRow row in cats.Rows)
                {
                    Cat_results Check = new Cat_results(row["Name"].ToString(), row["Breed"].ToString(), row["Age"].ToString(), row["Gender"].ToString(),
                                            row["Weight"].ToString(), row["Personality"].ToString(), row["Email"].ToString(), this);
                    Check.ShowDialog();
                }
                Welcome_Screen Check2 = new Welcome_Screen();
                Check2.Show();
            }
        }
    }
}
