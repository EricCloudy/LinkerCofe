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

namespace LinkerCofe
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }      
        SqlConnection con = new SqlConnection(MyConnection.connectionString);
        private string text;
        public override string Text
        {
            get { return text; }
            set{ text = value; }
        }
        private void Password_Load(object sender, EventArgs e)
        {
            lbTableNum.Text = Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            try
            {
                if(txtCustomerID.Text != "")
                {
                    con.Open();
                    string query = "select count(Sell_ID) from tblSellCode where Sell_ID = '"+txtCustomerID.Text+"'";
                    SqlCommand checkCodeSell = new SqlCommand(query, con);
                    int Count = (int)checkCodeSell.ExecuteScalar();   
                    if(Count == 1)
                    {
                        this.Hide();
                        CustomerForm OpenCustomer = new CustomerForm();
                        OpenCustomer.Text = txtCustomerID.Text;
                        OpenCustomer.Show();

                    }
                    else
                    {
                        MessageBox.Show("This ID cannot access to cashier...");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please input ID...");      
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                btnLogin.Enabled = !string.IsNullOrWhiteSpace(tb.Text);
            }
        }
    }
}
