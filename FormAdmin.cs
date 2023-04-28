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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnadminlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fg = new FormLogin();
            fg.Show();
        }

        private void btnSellerInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSellerInformation afs = new FormSellerInformation();
            afs.Show();

        }

        private void btnItemInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormItemInfo da = new FormItemInfo();
            da.Show();

        }

        private void btnSellInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSellInfo afs = new FormSellInfo();
            afs.Show();
        }
    }
}
