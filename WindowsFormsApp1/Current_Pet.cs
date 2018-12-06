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
    }
}
