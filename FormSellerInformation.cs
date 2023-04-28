using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectXYZ
{
    public partial class FormSellerInformation : Form
    {
        private DataAccess Da { get; set; }
        public FormSellerInformation()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = "select * from xyzempinfo;";
            this.PopulateGridView(sql);
        }
        private void FormSellerInformation_Load(object sender, EventArgs e)
        {
            this.dgvsellerinformation.ClearSelection();
        }
        private void PopulateGridView(string sql = "select * from xyzempinfo;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvsellerinformation.AutoGenerateColumns = false;
            this.dgvsellerinformation.DataSource = ds.Tables[0];
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
                var txt = "select * from xyzempinfo where Id = '" + this.txtid.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    
                    var sql = @"update xyzempinfo
                                set username = '" + this.txtuname.Text + @"',
                                password = " + this.txtpassword.Text + @",
                                usertype = " + this.txtutype.Text + @",
                                joiningdate = '" + this.dtpjoining.Text + @"',
                                address = '" + this.txtaddress.Text + @"',
                                 name = '" + this.txtsname.Text + @"',
                                  salary = '" + this.txtsalary.Text + @"',
                                   phone = '" + this.txtphone.Text + @"'
                                where id = '" + this.txtid.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    //Insert record
                    string sql = "insert into xyzempinfo values('" + this.txtid.Text + "','" + this.txtuname.Text + "','" +
                         this.txtpassword.Text + "','" + this.txtutype.Text + "','" + this.dtpjoining.Text + "','" +
                         this.txtaddress.Text + "','" + this.txtsname.Text + "','" + this.txtsalary.Text + "','" + this.txtphone.Text + "');";
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
            if (String.IsNullOrEmpty(this.txtid.Text) || String.IsNullOrWhiteSpace(this.txtid.Text) ||
                String.IsNullOrEmpty(this.txtuname.Text) || String.IsNullOrWhiteSpace(this.txtuname.Text) ||
                String.IsNullOrEmpty(this.txtpassword.Text) || String.IsNullOrWhiteSpace(this.txtpassword.Text) ||
                String.IsNullOrEmpty(this.txtutype.Text) || String.IsNullOrWhiteSpace(this.txtutype.Text) ||
                String.IsNullOrEmpty(this.dtpjoining.Text) || String.IsNullOrWhiteSpace(this.dtpjoining.Text) ||
                 String.IsNullOrEmpty(this.txtaddress.Text) || String.IsNullOrWhiteSpace(this.txtaddress.Text) ||
                String.IsNullOrEmpty(this.txtsname.Text) || String.IsNullOrWhiteSpace(this.txtsname.Text) ||
                String.IsNullOrEmpty(this.txtsalary.Text) || String.IsNullOrWhiteSpace(this.txtsalary.Text) ||
                String.IsNullOrEmpty(this.txtphone.Text) || String.IsNullOrWhiteSpace(this.txtphone.Text))

            {
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (this.dgvsellerinformation.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var id = this.dgvsellerinformation.CurrentRow.Cells[0].Value.ToString();
            var title = this.dgvsellerinformation.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var sql = "Delete from xyzempinfo where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title + " remove complete");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtid.Clear();
            this.txtuname.Clear();
            this.txtpassword.Clear();
            this.txtutype.Clear();
            this.dtpjoining.Text= "";
            this.txtaddress.Clear();
            this.txtsname.Clear();
            this.txtsalary.Clear();
            this.txtphone.Clear();
            this.txtAutoSearch.Clear();
            this.dgvsellerinformation.ClearSelection();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fg = new FormLogin();
            fg.Show();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from xyzempinfo where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtid.Text = this.dgvsellerinformation.CurrentRow.Cells[0].Value.ToString();
            this.txtuname.Text = this.dgvsellerinformation.CurrentRow.Cells[1].Value.ToString();
            this.txtpassword.Text = this.dgvsellerinformation.CurrentRow.Cells[2].Value.ToString();
            this.txtutype.Text = this.dgvsellerinformation.CurrentRow.Cells[3].Value.ToString();
            this.dtpjoining.Text = this.dgvsellerinformation.CurrentRow.Cells[4].Value.ToString();
            this.txtaddress.Text = this.dgvsellerinformation.CurrentRow.Cells[5].Value.ToString();
            this.txtsname.Text = this.dgvsellerinformation.CurrentRow.Cells[6].Value.ToString();
            this.txtsalary.Text = this.dgvsellerinformation.CurrentRow.Cells[7].Value.ToString();
            this.txtphone.Text = this.dgvsellerinformation.CurrentRow.Cells[8].Value.ToString();


        }

    }
}
