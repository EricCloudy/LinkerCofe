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
            refreshDataGridView();
            dgvProduct.RowTemplate.Height = 60;
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)dgvProduct.Columns[4];
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvProduct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void refreshDataGridView()
        {
            con.Open();
            string sqlQuery = "SELECT * FROM tblProduct";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProduct.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ProductID = GetID();
            foreach (DataGridViewCell onecell in dgvProduct.SelectedCells)
            {
                if (onecell.Selected)
                {
                    dgvProduct.Rows.RemoveAt(onecell.RowIndex);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from tblProduct where Product_ID='"+ProductID+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        dgvProduct.Update();
                        dgvProduct.Refresh();
                        MessageBox.Show("Deleted sucessfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        public int GetID()
        {
            int a = 0;
            if (dgvProduct.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProduct.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProduct.Rows[selectedrowindex];
                a = Convert.ToInt16(selectedRow.Cells[0].Value);
            }
            return a;
        }
    }
}
