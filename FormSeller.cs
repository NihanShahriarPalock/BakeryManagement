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

namespace ProjectXYZ
{
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from foodinfo;";
            SqlConnection sqlcon = new SqlConnection("Data Source=NIHAN-LAPTOP\\SQLEXPRESS;Initial Catalog=xyx;Persist Security Info=True;User ID=sa;Password=Nihan@1234");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
           
            this.dgvfoodinfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from foodinfo where fname like '"+this.txtAutoSearch.Text+"%';";
            SqlConnection sqlcon = new SqlConnection("Data Source=NIHAN-LAPTOP\\SQLEXPRESS;Initial Catalog=xyx;Persist Security Info=True;User ID=sa;Password=Nihan@1234");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            
            this.dgvfoodinfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void rdbCakes_CheckedChanged(object sender, EventArgs e)
        {
            rdbCakes.ForeColor = System.Drawing.Color.Green;
            rdbBread.ForeColor = System.Drawing.Color.Red;
            rdbBiscuits.ForeColor = System.Drawing.Color.Red;
            cmbselectitem.Items.Clear();
            cmbselectitem.Items.Add("Chocolate cake");
            cmbselectitem.Items.Add("Vanilla cake");
            cmbselectitem.Items.Add("Red Velvet");
        }

        private void rdbBread_CheckedChanged(object sender, EventArgs e)
        {
            rdbCakes.ForeColor = System.Drawing.Color.Red;
            rdbBread.ForeColor = System.Drawing.Color.Green;
            rdbBiscuits.ForeColor = System.Drawing.Color.Red;
            cmbselectitem.Items.Clear();
            cmbselectitem.Items.Add("Brown Bread");
            cmbselectitem.Items.Add("Milk Bread");
            cmbselectitem.Items.Add("White Bread");
        }

        private void rdbBiscuits_CheckedChanged(object sender, EventArgs e)
        {
            rdbCakes.ForeColor = System.Drawing.Color.Red;
            rdbBread.ForeColor = System.Drawing.Color.Red;
            rdbBiscuits.ForeColor = System.Drawing.Color.Green;
            cmbselectitem.Items.Clear();
            cmbselectitem.Items.Add("Dry Cake");
            cmbselectitem.Items.Add("Cookies");
            cmbselectitem.Items.Add("Pineapple Biscuits");
        }

        private void cmbselectitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbselectitem.SelectedItem.ToString() == "Chocolate cake")
            {
                txtPrice.Text = "500";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Vanilla cake")
            {
                txtPrice.Text = "400";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Red Velvet")
            {
                txtPrice.Text = "750";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Brown Bread")
            {
                txtPrice.Text = "175";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Milk Bread")
            {
                txtPrice.Text = "60";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Dry Cake")
            {
                txtPrice.Text = "200";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Cookies")
            {
                txtPrice.Text = "100";
            }
            else if (cmbselectitem.SelectedItem.ToString() == "Pineapple Bicuits")
            {
                txtPrice.Text = "50";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into foodinfo values ('"+this.txtid.Text+ "','" + this.cmbselectitem.Text + "','" + this.txtPrice.Text + "','" + this.txtquantity.Text + "','" + this.txttotal.Text + "');";
            SqlConnection sqlcon = new SqlConnection("Data Source=NIHAN-LAPTOP\\SQLEXPRESS;Initial Catalog=xyx;Persist Security Info=True;User ID=sa;Password=Nihan@1234");
            MessageBox.Show("Data Inserted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            cmbselectitem.Text = string.Empty;
            txtid.Clear();
            txtPrice.Clear();
            txtquantity.Clear();
            txttotal.Clear();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();

        }

        private void btnsellinginfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSellingInfo fsi = new FormSellingInfo();
            fsi.Show();
        }
    }
}
