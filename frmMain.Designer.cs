namespace northwind
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMaintenanceToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            this.fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.suppliersToolStripMenuItem1,
            this.categoriesToolStripMenuItem1,
            this.customersToolStripMenuItem1,
            this.employeesToolStripMenuItem1,
            this.exitToolStripMenuItem1,
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            this.fileMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            this.fileMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.fileMaintenanceToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.productsToolStripMenuItem1.Text = "(F1) Products";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.productsToolStripMenuItem1_Click);
            // 
            // suppliersToolStripMenuItem1
            // 
            this.suppliersToolStripMenuItem1.Name = "suppliersToolStripMenuItem1";
            this.suppliersToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.suppliersToolStripMenuItem1.Text = "(F2) Suppliers";
            this.suppliersToolStripMenuItem1.Click += new System.EventHandler(this.suppliersToolStripMenuItem1_Click);
            // 
            // categoriesToolStripMenuItem1
            // 
            this.categoriesToolStripMenuItem1.Name = "categoriesToolStripMenuItem1";
            this.categoriesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.categoriesToolStripMenuItem1.Text = "(F3) Categories";
            this.categoriesToolStripMenuItem1.Click += new System.EventHandler(this.categoriesToolStripMenuItem1_Click);
            // 
            // customersToolStripMenuItem1
            // 
            this.customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            this.customersToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.customersToolStripMenuItem1.Text = "(F4) Customers";
            this.customersToolStripMenuItem1.Click += new System.EventHandler(this.customersToolStripMenuItem1_Click);
            // 
            // employeesToolStripMenuItem1
            // 
            this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.employeesToolStripMenuItem1.Text = "(F5) Employees";
            this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem1_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterlistToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // masterlistToolStripMenuItem
            // 
            this.masterlistToolStripMenuItem.Name = "masterlistToolStripMenuItem";
            this.masterlistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masterlistToolStripMenuItem.Text = "Masterlist";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // timerLogin
            // 
            this.timerLogin.Enabled = true;
            this.timerLogin.Interval = 500;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Northwind";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem1;
        private System.Windows.Forms.Timer timerDateTime;
    }
}