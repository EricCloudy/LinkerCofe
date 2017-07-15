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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(MyConnection.connectionString);
        public string tblNum;
        private void Table_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select TableNum from [TableCafe]";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                combTableNum.Items.Add(dr["TableNum"].ToString());
            }
            con.Close();
            tblNum = combTableNum.Text;
        }
        public void btChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if(combTableNum.Text == "")
                    MessageBox.Show("Please choose table number !");
                else
                {
                    this.Hide();
                    Password fPassword = new Password();
                    fPassword.Text = combTableNum.Text;
                    fPassword.Show();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }       
        }   
        public string setTable()
        {
            return tblNum;
        }
        public string test()
        {
            return "";
        }
    }
}
