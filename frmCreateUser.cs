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
    public partial class frmCreateUser : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void tabDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this account?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Login (UserName, Password, Answer)values (@catname,@desc)", cn);

                cmd.Parameters.AddWithValue("@user", txtUsernameAdd.Text);
                cmd.Parameters.AddWithValue("@pass", txtPasswordAdd.Text);
                cmd.Parameters.AddWithValue("@ans",cmbAnswerAdd.Text);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Added User!");
                
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtUsernameAdd.Clear();
                txtPasswordAdd.Clear();
                txtRetypeAdd.Clear();

            }

            cn.Close();
        }
    }
}
