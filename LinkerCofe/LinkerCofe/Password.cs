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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        CustomerForm OpenCustomer = new CustomerForm();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenCustomer.Show();
        }
    }
}
