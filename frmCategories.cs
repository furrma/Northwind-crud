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
    public partial class frmCategories : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmCategories()
        {
            InitializeComponent();
        }

        private void btnBackMainCat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCategories.DataSource = dt;
            cn.Close();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            try { 
            SqlCommand cmd = new SqlCommand("insert into Categories (CategoryName, Description)values (@catname,@desc)", cn);

            cmd.Parameters.AddWithValue("@catname", txtCatNameAdd.Text);
            cmd.Parameters.AddWithValue("@desc", txtDescAdd.Text);
            
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
                MessageBox.Show("Succesfully Added Category!");
            dgvCategories.DataSource = null;
            SqlDataAdapter da = new SqlDataAdapter("select * from Categories", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCategories.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtCatNameAdd.Clear();
                txtDescAdd.Clear();

            }

            cn.Close();
        }

        private void btnCatEdit_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update Categories set CategoryName = @catname, Description = @desc where CategoryID = @catid", cn);

                cmd.Parameters.AddWithValue("@catid", txtCatIDEdit.Text);
                cmd.Parameters.AddWithValue("@catname", txtCatNameEdit.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescEdit.Text);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Updated Category!");
                    else
                    {
                    MessageBox.Show("Invalid Category ID.");
                    txtCatIDEdit.Clear();
                    }
                dgvCategories.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from Categories", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategories.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtCatIDEdit.Clear();
                txtCatNameEdit.Clear();
                txtDescEdit.Clear();

            }
            cn.Close();
        }

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("delete from Categories where CategoryID = @catid", cn);

                    cmd.Parameters.AddWithValue("@catid", txtCatIDDel.Text);
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                        MessageBox.Show("Succesfully Deleted Customer!");
                        else
                        {
                        MessageBox.Show("Invalid Customer ID.");
                        txtCatIDDel.Clear();
                        }
                    dgvCategories.DataSource = null;
                    SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCategories.DataSource = dt;

                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please try again.");
                txtCatIDDel.Clear();

            }
            cn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnCatSearch_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveCategory @catid", cn);
            
            cmd.Parameters.Add(new SqlParameter("@catid", txtCatIDSearch.Text));
           
            SqlDataReader read = null;
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                txtCatNameSearch.Text = (read["CategoryName"].ToString());
                txtDescSearch.Text = (read["Description"].ToString());
            }
            }
            catch
            {
                MessageBox.Show("Invalid Customer ID.");
                txtCatIDSearch.Clear();
            }
            cn.Close();
        }
    }
}
