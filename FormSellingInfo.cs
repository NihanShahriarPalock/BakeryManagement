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
    public partial class FormSellingInfo : Form
    {
        private DataAccess Da { get; set; }

        public FormSellingInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = "select * from sellinginformation;";
            this.PopulateGridView(sql);

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormSellingInfo_Load(object sender, EventArgs e)
        {
            this.dgvSellingInfo.ClearSelection();
        }


        private void PopulateGridView(string sql = "select * from sellinginformation;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvSellingInfo.AutoGenerateColumns = false;
            this.dgvSellingInfo.DataSource = ds.Tables[0];
        }

        private void txtAutosearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from sellinginformation where name like '" + this.txtAutosearch.Text + "%';";
            this.PopulateGridView(sql);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToSave())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var txt = "select * from sellinginformation where Id = '" + this.txtfoodid.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    
                    var sql = @"update sellinginformation
                                set sellerid = '" + this.txtsellerid.Text + @"',
                                name = " + this.txtfoodname.Text + @",
                                price = " + this.txtprice.Text + @",
                                quantity= '" + this.txtquantity.Text + @"',
                                total = '" + this.txttotal.Text + @"'
                                where id = '" + this.txtfoodid.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    
                    string sql = "insert into sellinginformation values('" + this.txtfoodid.Text + "','" + this.txtfoodname.Text + "'," +
                        this.txtprice.Text + "," + this.txtquantity.Text + ",'" + this.txttotal.Text + "','" +
                        this.txtsellerid.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion complete");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtfoodid.Text) || String.IsNullOrWhiteSpace(this.txtfoodid.Text) ||
                String.IsNullOrEmpty(this.txtfoodname.Text) || String.IsNullOrWhiteSpace(this.txtfoodname.Text) ||
                String.IsNullOrEmpty(this.txtprice.Text) || String.IsNullOrWhiteSpace(this.txtprice.Text) ||
                String.IsNullOrEmpty(this.txtquantity.Text) || String.IsNullOrWhiteSpace(this.txtquantity.Text) ||
                String.IsNullOrEmpty(this.txttotal.Text) || String.IsNullOrWhiteSpace(this.txttotal.Text) ||
                String.IsNullOrEmpty(this.txtsellerid.Text) || String.IsNullOrWhiteSpace(this.txtsellerid.Text) )
            {
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtfoodid.Clear();
            this.txtfoodname.Clear();
            this.txtprice.Clear();
            this.txtquantity.Clear();
            this.txttotal.Clear();
            this.txtsellerid.Clear();

  
            this.txtAutosearch.Clear();
            this.dgvSellingInfo.ClearSelection();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvSellingInfo.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var id = this.dgvSellingInfo.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvSellingInfo.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var sql = "Delete from sellinginformation where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " remove completed");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void dgvSellingInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtfoodid.Text = this.dgvSellingInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtfoodname.Text = this.dgvSellingInfo.CurrentRow.Cells[1].Value.ToString();
            this.txtprice.Text = this.dgvSellingInfo.CurrentRow.Cells[2].Value.ToString();
            this.txtquantity.Text = this.dgvSellingInfo.CurrentRow.Cells[3].Value.ToString();
            this.txttotal.Text = this.dgvSellingInfo.CurrentRow.Cells[4].Value.ToString();
            this.txtsellerid.Text = this.dgvSellingInfo.CurrentRow.Cells[5].Value.ToString();

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeller fs = new FormSeller();
            fs.Show();
        }
    }
}
