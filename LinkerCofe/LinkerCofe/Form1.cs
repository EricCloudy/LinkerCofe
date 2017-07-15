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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {         
            this.Hide();
            Table chooseTable = new Table();
            chooseTable.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller OpenSeller = new Seller();
            OpenSeller.Show();
        }
        private void btnChief_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
