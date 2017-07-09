using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkerCofe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerForm OpenCustomer = new CustomerForm();
        Password OpenPasword = new Password();


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPasword.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seller");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chef");
        }
    }
}
