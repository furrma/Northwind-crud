using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.   Forms;

namespace northwind
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        frmCustomers CustomersForm = new frmCustomers();
        frmCategories CategoriesForm = new frmCategories();
        frmEmployees EmployeesForm = new frmEmployees();
        frmSuppliers SuppliersForm = new frmSuppliers();
        frmProducts ProductsForm = new frmProducts();
        frmForgotPassword PasswordForm = new frmForgotPassword();
        frmCreateUser CreateUserForm = new frmCreateUser();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                ProductsForm.MdiParent = this;
                ProductsForm.Show();
                return true;
            }
            else if (keyData == Keys.F2)
            {
                SuppliersForm.MdiParent = this;
                SuppliersForm.Show();
                return true;
            }
            else if (keyData == Keys.F3)
            {
                CategoriesForm.MdiParent = this;
                CategoriesForm.Show();
                return true;
            }
            else if (keyData == Keys.F4)
            {
                CustomersForm.MdiParent = this;
                CustomersForm.Show();
                return true;
            }
            else if (keyData == Keys.F5)
            {
                EmployeesForm.MdiParent = this;
                EmployeesForm.Show();
                return true;
            }
                return base.ProcessCmdKey(ref msg, keyData);
            }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ProductsForm.Visible == true)
                return;
            ProductsForm = new frmProducts();
            ProductsForm.MdiParent = this;
            ProductsForm.Show();
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SuppliersForm.Visible == true)
                return;
            SuppliersForm = new frmSuppliers();
            SuppliersForm.MdiParent = this;
            SuppliersForm.Show();
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CategoriesForm.Visible == true)
                return;
            CategoriesForm = new frmCategories();
            CategoriesForm.MdiParent = this;
            CategoriesForm.Show();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CustomersForm.Visible == true)
                return;
            CustomersForm = new frmCustomers();
            CustomersForm.MdiParent = this;
            CustomersForm.Show();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.Visible == true)
                return;
            EmployeesForm = new frmEmployees();
            EmployeesForm.MdiParent = this;
            EmployeesForm.Show();
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            timerLogin.Enabled = false;
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
                Application.Exit();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans;
                ans = MessageBox.Show("Are you sure you want to logout?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    frmLogin LoginForm = new frmLogin();
                    LoginForm.MdiParent = this;
                    LoginForm.ShowDialog();
                }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PasswordForm.Visible == true)
                return;
            PasswordForm = new frmForgotPassword();
            PasswordForm.MdiParent = this;
            PasswordForm.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUserForm.MdiParent = this;
            CreateUserForm.Show();
        }

        frmDateTime DateTimeForm = new frmDateTime();
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            timerDateTime.Enabled = false;
            DateTimeForm.MdiParent = this;
            DateTimeForm.Show();
        }

        private void fileMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
