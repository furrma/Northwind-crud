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
    public partial class frmForgotPassword : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("VerifyUser @user, @ans", cn);

                cmd.Parameters.Add(new SqlParameter("@user", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@ans", cmbAnswer.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    grpChange.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalid user details. Please try again.");
                    txtUsername.Clear();
                    cmbAnswer.Refresh();
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid username/password. Please try again.");
            }
            cn.Close();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            cn.Open();
            DialogResult ans;
            if (txtNewPassword.Text == txtRetype.Text)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update Login set Password = @pass where Username = @user", cn);

                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtNewPassword.Text);
                   
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("Successfully updated login!");
                 ans = MessageBox.Show("Proceed to login?", "You may login now.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (ans == DialogResult.Yes)
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.");
                        txtNewPassword.Clear();
                        txtRetype.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Invalid data input. Please try again.");
                    txtNewPassword.Clear();
                    txtRetype.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match! Please try again.");
            }
            cn.Close();
        }
    }
}
