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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(MyConnection.connectionString);
        private string text;
        public override string Text
        {
            get { return text; }
            set { text = value; }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            lbSellCode.Text = Text;
            dynamicButton();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void dynamicButton()
        {         
            string count = "select count(*) from tblProduct";
            string info = "select * from tblProduct";
            con.Open();
            SqlCommand cmdCount = new SqlCommand(count, con);
            int Count = (int)cmdCount.ExecuteScalar();
            SqlCommand cmdInfo = new SqlCommand(info, con);
            SqlDataAdapter da = new SqlDataAdapter(cmdInfo);
            DataTable dt = new DataTable();
            da.Fill(dt);
                                   
            flowLayoutPanel1.Controls.Clear();            
            for(int i = 0; i < Count; i++)
            {
                    MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["Picture"]);
                    Button btn = new Button();
                    btn.Name = i.ToString();
                    btn.Image = new Bitmap(ms);
                    btn.AutoSize = false;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Width = 115;
                    btn.Height = 200;
                    
                    Label lbName = new Label();
                    lbName.Name = i.ToString();
                    lbName.Text = dt.Rows[i]["Product"].ToString();
                    lbName.TextAlign = ContentAlignment.MiddleCenter;
                    lbName.BackColor = Color.SaddleBrown;
                    lbName.Width = 115;
                    
                    Label lbCost = new Label();
                    lbCost.Name = i.ToString();
                    lbCost.Text = dt.Rows[i]["Price"].ToString();
                    lbCost.TextAlign = ContentAlignment.MiddleCenter;
                    lbCost.BackColor = Color.SandyBrown;
                    lbCost.Width = 115;
                    
                if(dt.Rows[i]["Type"].ToString() == "Coffee    ")
                {
                    flowLayoutPanel1.Controls.Add(btn);
                    flowLayoutPanel1.Controls.Add(lbName);
                    flowLayoutPanel1.Controls.Add(lbCost);
                }
                else if (dt.Rows[i]["Type"].ToString() == "Drink     ")
                {
                    flowLayoutPanel2.Controls.Add(btn);
                    flowLayoutPanel2.Controls.Add(lbName);
                    flowLayoutPanel2.Controls.Add(lbCost);
                }
                else
                {
                    flowLayoutPanel3.Controls.Add(btn);
                    flowLayoutPanel3.Controls.Add(lbName);
                    flowLayoutPanel3.Controls.Add(lbCost);
                }
                
            }
            con.Close();
        }
        public void GetImage()
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
