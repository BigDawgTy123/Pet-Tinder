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
