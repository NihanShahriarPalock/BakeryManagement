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
    public partial class FormSellInfo : Form
    {
        private DataAccess Da { get; set; }
        public FormSellInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = "select * from sellinginformation;";
            this.PopulateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormSellInfo_Load(object sender, EventArgs e)
        {
            this.dgvASellInfo.ClearSelection();
        }
        private void PopulateGridView(string sql = "select * from sellinginformation;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvASellInfo.AutoGenerateColumns = false;
            this.dgvASellInfo.DataSource = ds.Tables[0];
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvASellInfo.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var id = this.dgvASellInfo.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvASellInfo.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var sql = "Delete from sellinginformation where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " remove complete");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.dgvASellInfo.ClearSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }
    }
}
