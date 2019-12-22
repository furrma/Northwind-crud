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
    public partial class frmProducts : Form
    {
        SqlConnection cn = new SqlConnection("server= FURRMA; database=Northwind; user id=sa; password=koyangi13");

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnBackMainProd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

            cn.Open();
    
            try { 
            SqlCommand cmd = new SqlCommand("insert into products (ProductName, SupplierID, CategoryID,QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel,Discontinued) values (@prodname,@supid,@catid,@quan,@price,@stock,@order, @reorder, @discon)", cn);

            cmd.Parameters.AddWithValue("@prodname", txtProdNameAdd.Text);
            cmd.Parameters.AddWithValue("@supid", txtSuppIDAdd.Text);
            cmd.Parameters.AddWithValue("@catid", txtCatIDAdd.Text);
            cmd.Parameters.AddWithValue("@quan", txtQuanAdd.Text);
            cmd.Parameters.AddWithValue("@price", txtPriceAdd.Text);
            cmd.Parameters.AddWithValue("@stock", txtStockAdd.Text);
            cmd.Parameters.AddWithValue("@order", txtOnOrderAdd.Text);
            cmd.Parameters.AddWithValue("@reorder", txtReorderLevelAdd.Text);
            cmd.Parameters.AddWithValue("@discon", txtDiscontinuedAdd.Text);
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
                MessageBox.Show("Succesfully Added Product!");
            dgvProducts.DataSource = null;
            SqlDataAdapter da = new SqlDataAdapter("select * from products", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;

        }
            catch {
                MessageBox.Show("Invalid Data Input. Please try again.");
                txtProdNameAdd.Clear();
                txtSuppIDAdd.Clear() ;
                txtCatIDAdd.Clear();
                txtQuanAdd.Clear();
                txtPriceAdd.Clear();
                txtStockAdd.Clear();
                txtOnOrderAdd.Clear();
                txtReorderLevelAdd.Clear();
                txtDiscontinuedAdd.Clear();
            }


    cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from products", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
            cn.Close();
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update products set ProductName = @prodname, SupplierID = @supid, CategoryID = @catid,QuantityPerUnit = @quan, UnitPrice = @price,  UnitsInStock = @stock, UnitsOnOrder = @order, ReorderLevel = @reorder,Discontinued = @discon where ProductID = @prodid", cn);


                cmd.Parameters.AddWithValue("@prodid", txtProdIDEdit.Text);
                cmd.Parameters.AddWithValue("@prodname", txtProdNameEdit.Text);
                cmd.Parameters.AddWithValue("@supid", txtSuppIDEdit.Text);
                cmd.Parameters.AddWithValue("@catid", txtCatIDEdit.Text);
                cmd.Parameters.AddWithValue("@quan", txtQuanEdit.Text);
                cmd.Parameters.AddWithValue("@price", txtPriceEdit.Text);
                cmd.Parameters.AddWithValue("@stock", txtStockEdit.Text);
                cmd.Parameters.AddWithValue("@order", txtOnOrderEdit.Text);
                cmd.Parameters.AddWithValue("@reorder", txtReorderLevelEdit.Text);
                cmd.Parameters.AddWithValue("@discon", txtDiscontinuedEdit.Text);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    MessageBox.Show("Succesfully Updated Product!");
                else
                    MessageBox.Show("Invalid ProductID.");
                dgvProducts.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("select * from products", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            catch {
                MessageBox.Show("Invalid Data Input. Please try again.");
                txtProdIDEdit.Clear();
                txtProdNameEdit.Clear();
                txtSuppIDEdit.Clear() ;
                txtCatIDEdit.Clear();
                txtQuanEdit.Clear();
                txtPriceEdit.Clear();
                txtStockEdit.Clear();
                txtOnOrderEdit.Clear();
                txtReorderLevelEdit.Clear();
                txtDiscontinuedEdit.Clear();
            }
            
            cn.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from products", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
            cn.Close();
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {

            cn.Open();
            try
            {
                DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from Products where ProductID = @prodid", cn);

                    cmd.Parameters.AddWithValue("@prodid", txtProdIDDel.Text);
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                        MessageBox.Show("Succesfully Deleted Product!");
                    else
                        MessageBox.Show("Product Not Found!");
                    dgvProducts.DataSource = null;
                    SqlDataAdapter da = new SqlDataAdapter("select * from Products", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }

            catch {
                MessageBox.Show("Please Enter Valid ProductID.");
                txtCatIDDel.Clear();
            }
            cn.Close();
        
            
            }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("RetrieveProducts @id", cn);

                cmd.Parameters.Add(new SqlParameter("@id", txtProdIDSearch.Text));

                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtProdNameSearch.Text = (read["ProductName"].ToString());
                    txtSuppIDSearch.Text = (read["SupplierID"].ToString());
                    txtCatIDSearch.Text = (read["CategoryID"].ToString());
                    txtQuanSearch.Text = (read["QuantityPerUnit"].ToString());
                    txtPriceSearch.Text = (read["UnitPrice"].ToString());
                    txtStockSearch.Text = (read["UnitsInStock"].ToString());
                    txtOnOrderSearch.Text = (read["UnitsOnOrder"].ToString());
                    txtReorderLevelSearch.Text = (read["ReorderLevel"].ToString());
                    //txtDiscontinuedSearch.Text = (read["Discontnued"].ToString());
                    
                }
            }
            catch
            {
                MessageBox.Show("Invalid Product ID.");
                txtProdIDSearch.Clear();
            }
            cn.Close();
        }
    }
}
