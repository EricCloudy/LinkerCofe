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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(MyConnection.connectionString);
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ComstomizeProduct addNewProduct = new ComstomizeProduct();
            addNewProduct.Show();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            con.Open();
            string sqlQuery = "SELECT * FROM tblProduct";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgvProduct.Rows.Clear();
            foreach(DataRow item in dt.Rows)
            {
                int n = dgvProduct.Rows.Add();
                dgvProduct.Rows[n].Cells[0].Value = item[0].ToString();
                dgvProduct.Rows[n].Cells[1].Value = item[1].ToString();
                dgvProduct.Rows[n].Cells[2].Value = item[2].ToString();
                dgvProduct.Rows[n].Cells[3].Value = item[3].ToString();
                dgvProduct.Rows[n].Cells[4].Value = item[4].ToString();
            }

        }
    }
}
