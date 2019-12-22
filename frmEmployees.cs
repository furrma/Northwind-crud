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
    public partial class frmEmployees : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmEmployees()
        {
            InitializeComponent();
        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Employees(LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension) values (@lname,@fname,@tit,@tcour,@bday,@hdate,@add, @city, @region, @postal, @country, @phone, @ext)", cn);


                cmd.Parameters.AddWithValue("@lname", txtLNameAdd.Text);
                cmd.Parameters.AddWithValue("@fname", txtFNameAdd.Text);
                cmd.Parameters.AddWithValue("@tit", txtTitleAdd.Text);
                cmd.Parameters.AddWithValue("@tcour", txtTCourtesyAdd.Text);
                cmd.Parameters.AddWithValue("@bday", dtpBdayAdd.Value);
                cmd.Parameters.AddWithValue("@hdate", dtpHireDateAdd.Value);
                cmd.Parameters.AddWithValue("@add", txtAddressAdd.Text);
                cmd.Parameters.AddWithValue("@city", txtCityAdd.Text);
                cmd.Parameters.AddWithValue("@region", txtRegionAdd.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalAdd.Text);
                cmd.Parameters.AddWithValue("@country", txtCountryAdd.Text);
                cmd.Parameters.AddWithValue("@phone", txtHPhoneAdd.Text);
                cmd.Parameters.AddWithValue("@ext", txtExtAdd.Text);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Added Customer!");
                dgvEmployees.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtLNameAdd.Clear();
                txtFNameAdd.Clear();
                txtTitleAdd.Clear();
                txtTCourtesyAdd.Clear();
                dtpBdayAdd.ResetText();
                dtpHireDateAdd.ResetText();
                txtAddressAdd.Clear();
                txtCityAdd.Clear();
                txtRegionAdd.Clear();
                txtPostalAdd.Clear();
                txtCountryAdd.Clear();
                txtHPhoneAdd.Clear();
                txtExtAdd.Clear();

            }


            cn.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployees.DataSource = dt;
            cn.Close();
        }

        private void btnBackMainEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update Employees set LastName = @lname, FirstName =@fname, Title = @tit, TitleOfCourtesy = @tcour, BirthDate = @bday, HireDate = @hdate, Address = @add, City = @city, Region = @region, PostalCode = @postal, Country = @country, HomePhone = @phone, Extension = @ext where EmployeeID = @empid", cn);

                cmd.Parameters.AddWithValue("@empid", txtEmpIDEdit.Text);
                cmd.Parameters.AddWithValue("@lname", txtLNameEdit.Text);
                cmd.Parameters.AddWithValue("@fname", txtFNameEdit.Text);
                cmd.Parameters.AddWithValue("@tit", txtTitleEdit.Text);
                cmd.Parameters.AddWithValue("@tcour", txtTCourEdit.Text);
                cmd.Parameters.AddWithValue("@bday", dtpBdayEdit.Value);
                cmd.Parameters.AddWithValue("@hdate", dtpHDateEdit.Value);
                cmd.Parameters.AddWithValue("@add", txtAddressEdit.Text);
                cmd.Parameters.AddWithValue("@city", txtCityEdit.Text);
                cmd.Parameters.AddWithValue("@region", txtRegionEdit.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalEdit.Text);
                cmd.Parameters.AddWithValue("@country", txtCountryEdit.Text);
                cmd.Parameters.AddWithValue("@phone", txtHPhoneEdit.Text);
                cmd.Parameters.AddWithValue("@ext", txtExtEdit.Text);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Updated Customer!");
                else
                {
                    MessageBox.Show("Invalid Customer ID.");
                    txtCityEdit.Clear();
                }
                    
                    dgvEmployees.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtEmpIDEdit.Clear();
                txtLNameEdit.Clear();
                txtFNameEdit.Clear();
                txtTitleEdit.Clear();
                txtTCourEdit.Clear();
                dtpBdayEdit.ResetText();
                dtpHDateEdit.ResetText();
                txtAddressEdit.Clear();
                txtCityEdit.Clear();
                txtRegionEdit.Clear();
                txtPostalEdit.Clear();
                txtCountryEdit.Clear();
                txtHPhoneEdit.Clear();
                 txtExtEdit.Clear();

            }

            cn.Close();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.CurrentCell != null && dgvEmployees.CurrentCell.Value != null)
            {
                txtEmpIDDel.Text = dgvEmployees.CurrentCell.Value.ToString();
                txtEmpIDSearch.Text = dgvEmployees.CurrentCell.Value.ToString();
                dgvEmployees.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from employees where EmployeeID = @empid", cn);

                    cmd.Parameters.AddWithValue("@empid", txtEmpIDDel.Text);
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                        MessageBox.Show("Succesfully Deleted Employee!");
                        else
                        {
                        MessageBox.Show("Invalid Employee ID.");
                        txtEmpIDDel.Clear();
                        }
                    dgvEmployees.DataSource = null;
                    SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployees.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Invalid data input. Please try again.");
                txtEmpIDDel.Clear();
            }
            cn.Close();
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveEmployee @id", cn);

                cmd.Parameters.Add(new SqlParameter("@id", txtEmpIDSearch.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtLNameSearch.Text = (read["LastName"].ToString());
                    txtFNameSearch.Text = (read["FirstName"].ToString());
                    txtTitleSearch.Text = (read["Title"].ToString());
                    txtTCourSearch.Text = (read["TitleOfCourtesy"].ToString());
                    dtpBdaySearch.Value = Convert.ToDateTime(read["BirthDate"].ToString());
                    dtpHDateSearch.Value = Convert.ToDateTime(read["HireDate"].ToString());
                    txtAddressSearch.Text = (read["Address"].ToString());
                    txtCitySearch.Text = (read["City"].ToString());
                    txtRegionSearch.Text = (read["Region"].ToString());
                    txtPostalSearch.Text = (read["PostalCode"].ToString());
                    txtCountrySearch.Text = (read["Country"].ToString());
                    txtHPhoneSearch.Text = (read["HomePhone"].ToString());
                    txtExtSearch.Text = (read["Extension"].ToString());
                    txtNotesSearch.Text = (read["Notes"].ToString());
                    txtRepToSearch.Text = (read["ReportsTo"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Invalid Employee ID.");
                txtEmpIDSearch.Clear();
            }
            cn.Close();
        }
    }
}
