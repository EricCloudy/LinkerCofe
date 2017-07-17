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
using System.IO;

namespace LinkerCofe
{
    public partial class ComstomizeProduct : Form
    {
        public ComstomizeProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(MyConnection.connectionString);
        string imgLocation;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtPrice.Text == "" || comboType.Text == "" || pictureBox1.Image == null)
                {
                    MessageBox.Show("Please input all information...!");
                }
                else
                {
                    byte[] images = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(stream);
                    images = br.ReadBytes((int)stream.Length);

                    con.Open();
                    string sqlQuery = "INSERT INTO tblProduct(Product, Price, Type, Picture) VALUES ('" + txtProductName.Text + "', '" + txtPrice.Text + "', '" + comboType.Text + "', @images)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully...!");
                    Seller obj = (Seller)Application.OpenForms["Seller"];
                    this.Close();
                    obj.refreshDataGridView();
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }           
        }

    }
}
