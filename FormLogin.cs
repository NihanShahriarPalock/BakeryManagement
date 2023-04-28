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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string cs = "Data Source=NIHAN-LAPTOP\\SQLEXPRESS;Initial Catalog=xyx;Persist Security Info=True;User ID=sa;Password=Nihan@1234";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserid.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Provide Username and Password");
            }
            try 
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from xyzempinfo where username = @username and Password= @password", con);
                cmd.Parameters.AddWithValue("@username", txtUserid.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapt.Fill(ds);
                con.Close();
                if(ds.Rows.Count>0)
                {
                    switch(ds.Rows[0]["usertype"]as string)
                    {
                        case "admin":
                            {
                                this.Hide();
                                new FormAdmin().Show();
                                break;
                            }
                        case "seller":
                            {
                                this.Hide();
                                new FormSeller().Show();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Enter correct Username and Password");
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                        
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelUP_Click(object sender, EventArgs e)
        {
            this.txtUserid.Clear();
            this.txtPassword.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.DarkCyan;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.PaleTurquoise;
        }

        private void btnCancelUP_MouseHover(object sender, EventArgs e)
        {
            this.btnCancelUP.BackColor = Color.DarkCyan;
        }

        private void btnCancelUP_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelUP.BackColor = Color.PaleTurquoise;
        }

        
    }
}
