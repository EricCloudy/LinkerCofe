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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customer")
            {
                this.Hide();
                OpenCustomer.Show();
            }
            else if (comboBox1.Text == "Seller")
            {
                MessageBox.Show("Seller");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
