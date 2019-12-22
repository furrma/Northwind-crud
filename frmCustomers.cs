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
    public partial class frmCustomers : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnBackMainCus_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            cn.Open();
            
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
            cn.Close();
        }

        private void txtCompanyNameAdd_TextChanged(object sender, EventArgs e)
        {
            txtCustIDAdd.Text = txtCompanyNameAdd.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Customers values (@custid,@comname,@conname,@contit,@add,@city,@region,@postal, @country, @phone, @fax)", cn);

                cmd.Parameters.AddWithValue("@custid", txtCustIDAdd.Text);
                cmd.Parameters.AddWithValue("@comname", txtCompanyNameAdd.Text);
                cmd.Parameters.AddWithValue("@conname", txtContactNameAdd.Text);
                cmd.Parameters.AddWithValue("@contit", txtContactTitleAdd.Text);
                cmd.Parameters.AddWithValue("@add", txtAddressAdd.Text);
                cmd.Parameters.AddWithValue("@city", txtCityAdd.Text);
                cmd.Parameters.AddWithValue("@region", txtRegionAdd.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalCodeAdd.Text);
                cmd.Parameters.AddWithValue("@country", txtCountryAdd.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneAdd.Text);
                cmd.Parameters.AddWithValue("@fax", txtFaxAdd.Text);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Added Customer!");
                dgvCustomers.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
            catch {
                MessageBox.Show("Invalid data input. Please try again.");
                txtCompanyNameAdd.Clear();
                txtContactNameAdd.Clear();
                txtContactTitleAdd.Clear();
                txtAddressAdd.Clear();
                txtCityAdd.Clear();
                txtRegionAdd.Clear();
                txtPostalCodeAdd.Clear();
                txtCountryAdd.Clear();
                txtPhoneAdd.Clear();
                txtFaxAdd.Clear();

            }

            cn.Close();
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            cn.Open();
            try { 
            SqlCommand cmd = new SqlCommand("update Customers set CompanyName = @comname, ContactName = @conname,ContactTitle = @contit, Address = @add, City = @city, Region = @region, PostalCode = @postal, Country = @country, Phone = @phone, Fax = @fax where CustomerID = @custid", cn);

            cmd.Parameters.AddWithValue("@custid", txtCustIDEdit.Text);
            cmd.Parameters.AddWithValue("@comname", txtCompanyNameEdit.Text);
            cmd.Parameters.AddWithValue("@conname", txtContactNameEdit.Text);
            cmd.Parameters.AddWithValue("@contit", txtContactTitleEdit.Text);
            cmd.Parameters.AddWithValue("@add", txtAddressEdit.Text);
            cmd.Parameters.AddWithValue("@city", txtCityEdit.Text);
            cmd.Parameters.AddWithValue("@region", txtRegionEdit.Text);
            cmd.Parameters.AddWithValue("@postal", txtPostalEdit.Text);
            cmd.Parameters.AddWithValue("@country", txtCountryEdit.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhoneEdit.Text);
            cmd.Parameters.AddWithValue("@fax", txtFaxEdit.Text);
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
                MessageBox.Show("Succesfully Updated Customer!");
                else {
                    MessageBox.Show("Invalid Customer ID.");
                    txtCustIDEdit.Clear();
                }
            dgvCustomers.DataSource = null;
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
        }
        catch{
                MessageBox.Show("Invald data input. Please try again.");
                txtCustIDEdit.Clear();
                txtCompanyNameEdit.Clear();
                txtContactNameEdit.Clear();
                txtContactTitleEdit.Clear();
                txtAddressEdit.Clear();
                txtCityEdit.Clear();
                txtRegionEdit.Clear();
                txtPostalEdit.Clear();
                txtCountryEdit.Clear();
                txtPhoneEdit.Clear();
                txtFaxEdit.Clear();

            }
            cn.Close();
        }

        private void btnCustDel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from Customers where CustomerID = @custid", cn);

                    cmd.Parameters.AddWithValue("@custid", txtCustIDDel.Text);
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                        MessageBox.Show("Succesfully Deleted Customer!");
                    else { 
                        MessageBox.Show("Invalid CustomerID.");
                        txtCustIDDel.Clear();
                }
                    dgvCustomers.DataSource = null;
                    SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");

            }
            cn.Close();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomers.CurrentCell != null && dgvCustomers.CurrentCell.Value != null)
            {
                txtCustIDDel.Text = dgvCustomers.CurrentCell.Value.ToString();
                txtCustIDSearch.Text = dgvCustomers.CurrentCell.Value.ToString();
                dgvCustomers.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
            
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveCustomer @id", cn);

                cmd.Parameters.Add(new SqlParameter("@id", txtCustIDSearch.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtCompanyNameSearch.Text = (read["CompanyName"].ToString());
                    txtContactNameSearch.Text = (read["ContactName"].ToString());
                    txtContactTitleSearch.Text = (read["ContactTitle"].ToString());
                    txtAddressSearch.Text = (read["Address"].ToString());
                    txtCitySearch.Text = (read["City"].ToString());
                    txtRegionSearch.Text = (read["Region"].ToString());
                    txtPostalSearch.Text = (read["PostalCode"].ToString());
                    txtCountrySearch.Text = (read["Country"].ToString());
                    txtPhoneSearch.Text = (read["Phone"].ToString());
                    txtFaxSearch.Text = (read["Fax"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Invalid Customer ID.");
                txtCustIDSearch.Clear();
            }
            cn.Close();
        }
    }
}
