using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace northwind
{
    public partial class frmLogin : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveLogin @user, @pass", cn);

                cmd.Parameters.Add(new SqlParameter("@user", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/password. Please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid username/password. Please try again.");
            }
            cn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                    Application.Exit();
        }

        frmForgotPassword ForgotPassForm = new frmForgotPassword();
        private void lblForgot_Click(object sender, EventArgs e)
        {
            ForgotPassForm.Show();
        }
    }
}
