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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customer")
            {
                MessageBox.Show("Customer");
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
    }
}
