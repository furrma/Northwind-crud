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
    public partial class frmSuppliers : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void btnBackMainSup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSuppAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into suppliers (CompanyName, ContactName, ContactTitle,Address, City, Region, PostalCode, Country,Phone, Fax, HomePage) values (@comname,@conname,@contit,@add,@city,@region,@postal, @country, @phone, @fax, @hpage)", cn);

                cmd.Parameters.AddWithValue("@comname", txtComNameAdd.Text);
                cmd.Parameters.AddWithValue("@conname", txtConNameAdd.Text);
                cmd.Parameters.AddWithValue("@contit", txtCTitleAdd.Text);
                cmd.Parameters.AddWithValue("@add", txtAddressAdd.Text);
                cmd.Parameters.AddWithValue("@city", txtCityAdd.Text);
                cmd.Parameters.AddWithValue("@region", txtRegionAdd.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalAdd.Text);
                cmd.Parameters.AddWithValue("@country", txtCountryAdd.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneAdd.Text);
                cmd.Parameters.AddWithValue("@fax", txtFaxAdd.Text);
                cmd.Parameters.AddWithValue("@hpage", txtHPageAdd.Text);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Added Supplier!");
                dgvSuppliers.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from suppliers", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSuppliers.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtComNameAdd.Clear();
                txtConNameAdd.Clear();
                txtCTitleAdd.Clear();
                txtAddressAdd.Clear();
                txtCityAdd.Clear();
                txtRegionAdd.Clear();
                txtPostalAdd.Clear();
                txtCountryAdd.Clear();
                txtPhoneAdd.Clear();
                txtFaxAdd.Clear();
                txtHPageAdd.Clear();

            }
            cn.Close();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from suppliers", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSuppliers.DataSource = dt;
            cn.Close();
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuppliers.CurrentCell != null && dgvSuppliers.CurrentCell.Value != null)
            {
                txtSuppIDDel.Text = dgvSuppliers.CurrentCell.Value.ToString();
                txtSuppIDSearch.Text = dgvSuppliers.CurrentCell.Value.ToString();
                dgvSuppliers.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from Suppliers", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSuppliers.DataSource = dt;
            }
        }

        private void btnSuppEdit_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update suppliers set CompanyName = @comname, ContactName = @conname,ContactTitle = @contit, Address = @add, City = @city, Region = @region, PostalCode = @postal, Country = @country, Phone = @phone, Fax = @fax, HomePage = @hpage where SupplierID = @supid", cn);

                cmd.Parameters.AddWithValue("@supid", txtSuppIDEdit.Text);
                cmd.Parameters.AddWithValue("@comname", txtComNameEdit.Text);
                cmd.Parameters.AddWithValue("@conname", txtConNameEdit.Text);
                cmd.Parameters.AddWithValue("@contit", txtCTitleEdit.Text);
                cmd.Parameters.AddWithValue("@add", txtAddressEdit.Text);
                cmd.Parameters.AddWithValue("@city", txtCityEdit.Text);
                cmd.Parameters.AddWithValue("@region", txtRegionEdit.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalEdit.Text);
                cmd.Parameters.AddWithValue("@country", txtCountryEdit.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneEdit.Text);
                cmd.Parameters.AddWithValue("@fax", txtFaxEdit.Text);
                cmd.Parameters.AddWithValue("@hpage", txtHPageEdit.Text);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Updated Supplier!");
                else
                {
                    MessageBox.Show("Invalid SupplierID.");
                    txtSuppIDEdit.Clear();
                }
                dgvSuppliers.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from suppliers", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSuppliers.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid Data Input. Please try again.");
                txtSuppIDEdit.Clear();
                txtComNameEdit.Clear();
                txtConNameEdit.Clear();
                txtCTitleEdit.Clear();
                txtAddressEdit.Clear();
                txtCityEdit.Clear();
                txtRegionEdit.Clear();
                txtPostalEdit.Clear();
                txtCountryEdit.Clear();
                txtPhoneEdit.Clear();
                txtFaxEdit.Clear();
                txtHPageEdit.Clear();

            }

            cn.Close();
        }

        private void btnSuppDel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {

                DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from Suppliers where SupplierID = @supid", cn);

                    cmd.Parameters.AddWithValue("@supid", txtSuppIDDel.Text);
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                        MessageBox.Show("Succesfully Deleted Supplier!");
                    else
                    {
                        MessageBox.Show("Invalid SupplierID.");
                        txtSuppIDDel.Clear();
                    }
                        dgvSuppliers.DataSource = null;
                    SqlDataAdapter da = new SqlDataAdapter("select * from suppliers", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSuppliers.DataSource = dt;
                }
            }
            catch {
                MessageBox.Show("Invalid data input. Please try again.");
                txtSuppIDDel.Clear();
            }
            cn.Close();
        }

        private void btnSuppSearch_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveSuppliers @id", cn);

                cmd.Parameters.Add(new SqlParameter("@id", txtSuppIDSearch.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtComNameSearch.Text = (read["CompanyName"].ToString());
                    txtConNameSearch.Text = (read["ContactName"].ToString());
                    txtConTitleSearch.Text = (read["ContactTitle"].ToString());
                    txtAddressSearch.Text = (read["Address"].ToString());
                    txtCitySearch.Text = (read["City"].ToString());
                    txtRegionSearch.Text = (read["Region"].ToString());
                    txtPostalSearch.Text = (read["PostalCode"].ToString());
                    txtCountrySearch.Text = (read["Country"].ToString());
                    txtPhoneSearch.Text = (read["Phone"].ToString());
                    txtFaxSearch.Text = (read["Fax"].ToString());
                    txtHPageSearch.Text = (read["HomePage"].ToString());

                }
            }
            catch
            {
                MessageBox.Show("Invalid Supplier ID.");
                txtSuppIDSearch.Clear();
            }
            cn.Close();
        }
    }
}
