namespace northwind
{
    partial class frmProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtDiscontinuedAdd = new System.Windows.Forms.TextBox();
            this.txtReorderLevelAdd = new System.Windows.Forms.TextBox();
            this.txtOnOrderAdd = new System.Windows.Forms.TextBox();
            this.txtStockAdd = new System.Windows.Forms.TextBox();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.txtQuanAdd = new System.Windows.Forms.TextBox();
            this.txtCatIDAdd = new System.Windows.Forms.TextBox();
            this.txtSuppIDAdd = new System.Windows.Forms.TextBox();
            this.txtProdNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtProdIDEdit = new System.Windows.Forms.TextBox();
            this.txtDiscontinuedEdit = new System.Windows.Forms.TextBox();
            this.txtReorderLevelEdit = new System.Windows.Forms.TextBox();
            this.txtOnOrderEdit = new System.Windows.Forms.TextBox();
            this.txtStockEdit = new System.Windows.Forms.TextBox();
            this.txtPriceEdit = new System.Windows.Forms.TextBox();
            this.txtQuanEdit = new System.Windows.Forms.TextBox();
            this.txtCatIDEdit = new System.Windows.Forms.TextBox();
            this.txtSuppIDEdit = new System.Windows.Forms.TextBox();
            this.txtProdNameEdit = new System.Windows.Forms.TextBox();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtDiscontinuedDel = new System.Windows.Forms.TextBox();
            this.txtReorderLevelDel = new System.Windows.Forms.TextBox();
            this.txtOnOrderDel = new System.Windows.Forms.TextBox();
            this.txtStockDel = new System.Windows.Forms.TextBox();
            this.txtPriceDel = new System.Windows.Forms.TextBox();
            this.txtQuanDel = new System.Windows.Forms.TextBox();
            this.txtCatIDDel = new System.Windows.Forms.TextBox();
            this.txtSuppIDDel = new System.Windows.Forms.TextBox();
            this.txtProdNameDel = new System.Windows.Forms.TextBox();
            this.txtProdIDDel = new System.Windows.Forms.TextBox();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.txtDiscontinuedSearch = new System.Windows.Forms.TextBox();
            this.txtReorderLevelSearch = new System.Windows.Forms.TextBox();
            this.txtOnOrderSearch = new System.Windows.Forms.TextBox();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.txtPriceSearch = new System.Windows.Forms.TextBox();
            this.txtQuanSearch = new System.Windows.Forms.TextBox();
            this.txtCatIDSearch = new System.Windows.Forms.TextBox();
            this.txtSuppIDSearch = new System.Windows.Forms.TextBox();
            this.txtProdIDSearch = new System.Windows.Forms.TextBox();
            this.txtProdNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btnBackMainProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 360);
            this.panel1.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(353, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProducts.Size = new System.Drawing.Size(410, 354);
            this.dgvProducts.TabIndex = 14;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 357);
            this.tabControl1.TabIndex = 13;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtDiscontinuedAdd);
            this.tabAdd.Controls.Add(this.txtReorderLevelAdd);
            this.tabAdd.Controls.Add(this.txtOnOrderAdd);
            this.tabAdd.Controls.Add(this.txtStockAdd);
            this.tabAdd.Controls.Add(this.txtPriceAdd);
            this.tabAdd.Controls.Add(this.txtQuanAdd);
            this.tabAdd.Controls.Add(this.txtCatIDAdd);
            this.tabAdd.Controls.Add(this.txtSuppIDAdd);
            this.tabAdd.Controls.Add(this.txtProdNameAdd);
            this.tabAdd.Controls.Add(this.btnAddProd);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label10);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(340, 331);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtDiscontinuedAdd
            // 
            this.txtDiscontinuedAdd.Location = new System.Drawing.Point(120, 225);
            this.txtDiscontinuedAdd.Name = "txtDiscontinuedAdd";
            this.txtDiscontinuedAdd.Size = new System.Drawing.Size(198, 20);
            this.txtDiscontinuedAdd.TabIndex = 22;
            // 
            // txtReorderLevelAdd
            // 
            this.txtReorderLevelAdd.Location = new System.Drawing.Point(120, 201);
            this.txtReorderLevelAdd.Name = "txtReorderLevelAdd";
            this.txtReorderLevelAdd.Size = new System.Drawing.Size(198, 20);
            this.txtReorderLevelAdd.TabIndex = 21;
            // 
            // txtOnOrderAdd
            // 
            this.txtOnOrderAdd.Location = new System.Drawing.Point(120, 176);
            this.txtOnOrderAdd.Name = "txtOnOrderAdd";
            this.txtOnOrderAdd.Size = new System.Drawing.Size(198, 20);
            this.txtOnOrderAdd.TabIndex = 20;
            // 
            // txtStockAdd
            // 
            this.txtStockAdd.Location = new System.Drawing.Point(120, 152);
            this.txtStockAdd.Name = "txtStockAdd";
            this.txtStockAdd.Size = new System.Drawing.Size(198, 20);
            this.txtStockAdd.TabIndex = 19;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(120, 129);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(198, 20);
            this.txtPriceAdd.TabIndex = 18;
            // 
            // txtQuanAdd
            // 
            this.txtQuanAdd.Location = new System.Drawing.Point(120, 103);
            this.txtQuanAdd.Name = "txtQuanAdd";
            this.txtQuanAdd.Size = new System.Drawing.Size(198, 20);
            this.txtQuanAdd.TabIndex = 17;
            // 
            // txtCatIDAdd
            // 
            this.txtCatIDAdd.Location = new System.Drawing.Point(120, 76);
            this.txtCatIDAdd.Name = "txtCatIDAdd";
            this.txtCatIDAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDAdd.TabIndex = 16;
            // 
            // txtSuppIDAdd
            // 
            this.txtSuppIDAdd.Location = new System.Drawing.Point(120, 50);
            this.txtSuppIDAdd.Name = "txtSuppIDAdd";
            this.txtSuppIDAdd.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDAdd.TabIndex = 15;
            // 
            // txtProdNameAdd
            // 
            this.txtProdNameAdd.Location = new System.Drawing.Point(120, 26);
            this.txtProdNameAdd.Name = "txtProdNameAdd";
            this.txtProdNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtProdNameAdd.TabIndex = 14;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(141, 277);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddProd.TabIndex = 12;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Units In Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Reorder Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Discontinued:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity Per Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Units On Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit Price:";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txtProdIDEdit);
            this.tabEdit.Controls.Add(this.txtDiscontinuedEdit);
            this.tabEdit.Controls.Add(this.txtReorderLevelEdit);
            this.tabEdit.Controls.Add(this.txtOnOrderEdit);
            this.tabEdit.Controls.Add(this.txtStockEdit);
            this.tabEdit.Controls.Add(this.txtPriceEdit);
            this.tabEdit.Controls.Add(this.txtQuanEdit);
            this.tabEdit.Controls.Add(this.txtCatIDEdit);
            this.tabEdit.Controls.Add(this.txtSuppIDEdit);
            this.tabEdit.Controls.Add(this.txtProdNameEdit);
            this.tabEdit.Controls.Add(this.btnEditProd);
            this.tabEdit.Controls.Add(this.label13);
            this.tabEdit.Controls.Add(this.label14);
            this.tabEdit.Controls.Add(this.label15);
            this.tabEdit.Controls.Add(this.label16);
            this.tabEdit.Controls.Add(this.label17);
            this.tabEdit.Controls.Add(this.label18);
            this.tabEdit.Controls.Add(this.label19);
            this.tabEdit.Controls.Add(this.label20);
            this.tabEdit.Controls.Add(this.label21);
            this.tabEdit.Controls.Add(this.label22);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(340, 331);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txtProdIDEdit
            // 
            this.txtProdIDEdit.Location = new System.Drawing.Point(123, 20);
            this.txtProdIDEdit.Name = "txtProdIDEdit";
            this.txtProdIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtProdIDEdit.TabIndex = 45;
            // 
            // txtDiscontinuedEdit
            // 
            this.txtDiscontinuedEdit.Location = new System.Drawing.Point(123, 242);
            this.txtDiscontinuedEdit.Name = "txtDiscontinuedEdit";
            this.txtDiscontinuedEdit.Size = new System.Drawing.Size(198, 20);
            this.txtDiscontinuedEdit.TabIndex = 44;
            // 
            // txtReorderLevelEdit
            // 
            this.txtReorderLevelEdit.Location = new System.Drawing.Point(123, 218);
            this.txtReorderLevelEdit.Name = "txtReorderLevelEdit";
            this.txtReorderLevelEdit.Size = new System.Drawing.Size(198, 20);
            this.txtReorderLevelEdit.TabIndex = 43;
            // 
            // txtOnOrderEdit
            // 
            this.txtOnOrderEdit.Location = new System.Drawing.Point(123, 193);
            this.txtOnOrderEdit.Name = "txtOnOrderEdit";
            this.txtOnOrderEdit.Size = new System.Drawing.Size(198, 20);
            this.txtOnOrderEdit.TabIndex = 42;
            // 
            // txtStockEdit
            // 
            this.txtStockEdit.Location = new System.Drawing.Point(123, 169);
            this.txtStockEdit.Name = "txtStockEdit";
            this.txtStockEdit.Size = new System.Drawing.Size(198, 20);
            this.txtStockEdit.TabIndex = 41;
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(123, 146);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(198, 20);
            this.txtPriceEdit.TabIndex = 40;
            // 
            // txtQuanEdit
            // 
            this.txtQuanEdit.Location = new System.Drawing.Point(123, 120);
            this.txtQuanEdit.Name = "txtQuanEdit";
            this.txtQuanEdit.Size = new System.Drawing.Size(198, 20);
            this.txtQuanEdit.TabIndex = 39;
            // 
            // txtCatIDEdit
            // 
            this.txtCatIDEdit.Location = new System.Drawing.Point(123, 93);
            this.txtCatIDEdit.Name = "txtCatIDEdit";
            this.txtCatIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDEdit.TabIndex = 38;
            // 
            // txtSuppIDEdit
            // 
            this.txtSuppIDEdit.Location = new System.Drawing.Point(123, 67);
            this.txtSuppIDEdit.Name = "txtSuppIDEdit";
            this.txtSuppIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDEdit.TabIndex = 37;
            // 
            // txtProdNameEdit
            // 
            this.txtProdNameEdit.Location = new System.Drawing.Point(123, 43);
            this.txtProdNameEdit.Name = "txtProdNameEdit";
            this.txtProdNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtProdNameEdit.TabIndex = 36;
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(148, 284);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 23);
            this.btnEditProd.TabIndex = 35;
            this.btnEditProd.Text = "Edit";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Product ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Product Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Units In Stock:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Supplier ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Reorder Level:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Category ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 245);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Discontinued:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Quantity Per Unit:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Units On Order:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 149);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Unit Price:";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtDiscontinuedDel);
            this.tabDelete.Controls.Add(this.txtReorderLevelDel);
            this.tabDelete.Controls.Add(this.txtOnOrderDel);
            this.tabDelete.Controls.Add(this.txtStockDel);
            this.tabDelete.Controls.Add(this.txtPriceDel);
            this.tabDelete.Controls.Add(this.txtQuanDel);
            this.tabDelete.Controls.Add(this.txtCatIDDel);
            this.tabDelete.Controls.Add(this.txtSuppIDDel);
            this.tabDelete.Controls.Add(this.txtProdNameDel);
            this.tabDelete.Controls.Add(this.txtProdIDDel);
            this.tabDelete.Controls.Add(this.btnDeleteProd);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.label23);
            this.tabDelete.Controls.Add(this.label24);
            this.tabDelete.Controls.Add(this.label25);
            this.tabDelete.Controls.Add(this.label26);
            this.tabDelete.Controls.Add(this.label27);
            this.tabDelete.Controls.Add(this.label28);
            this.tabDelete.Controls.Add(this.label29);
            this.tabDelete.Controls.Add(this.label30);
            this.tabDelete.Controls.Add(this.label31);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(340, 331);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtDiscontinuedDel
            // 
            this.txtDiscontinuedDel.Enabled = false;
            this.txtDiscontinuedDel.Location = new System.Drawing.Point(123, 245);
            this.txtDiscontinuedDel.Name = "txtDiscontinuedDel";
            this.txtDiscontinuedDel.Size = new System.Drawing.Size(198, 20);
            this.txtDiscontinuedDel.TabIndex = 89;
            // 
            // txtReorderLevelDel
            // 
            this.txtReorderLevelDel.Enabled = false;
            this.txtReorderLevelDel.Location = new System.Drawing.Point(123, 221);
            this.txtReorderLevelDel.Name = "txtReorderLevelDel";
            this.txtReorderLevelDel.Size = new System.Drawing.Size(198, 20);
            this.txtReorderLevelDel.TabIndex = 88;
            // 
            // txtOnOrderDel
            // 
            this.txtOnOrderDel.Enabled = false;
            this.txtOnOrderDel.Location = new System.Drawing.Point(123, 196);
            this.txtOnOrderDel.Name = "txtOnOrderDel";
            this.txtOnOrderDel.Size = new System.Drawing.Size(198, 20);
            this.txtOnOrderDel.TabIndex = 87;
            // 
            // txtStockDel
            // 
            this.txtStockDel.Enabled = false;
            this.txtStockDel.Location = new System.Drawing.Point(123, 172);
            this.txtStockDel.Name = "txtStockDel";
            this.txtStockDel.Size = new System.Drawing.Size(198, 20);
            this.txtStockDel.TabIndex = 86;
            // 
            // txtPriceDel
            // 
            this.txtPriceDel.Enabled = false;
            this.txtPriceDel.Location = new System.Drawing.Point(123, 149);
            this.txtPriceDel.Name = "txtPriceDel";
            this.txtPriceDel.Size = new System.Drawing.Size(198, 20);
            this.txtPriceDel.TabIndex = 85;
            // 
            // txtQuanDel
            // 
            this.txtQuanDel.Enabled = false;
            this.txtQuanDel.Location = new System.Drawing.Point(123, 123);
            this.txtQuanDel.Name = "txtQuanDel";
            this.txtQuanDel.Size = new System.Drawing.Size(198, 20);
            this.txtQuanDel.TabIndex = 84;
            // 
            // txtCatIDDel
            // 
            this.txtCatIDDel.Enabled = false;
            this.txtCatIDDel.Location = new System.Drawing.Point(123, 96);
            this.txtCatIDDel.Name = "txtCatIDDel";
            this.txtCatIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDDel.TabIndex = 83;
            // 
            // txtSuppIDDel
            // 
            this.txtSuppIDDel.Enabled = false;
            this.txtSuppIDDel.Location = new System.Drawing.Point(123, 70);
            this.txtSuppIDDel.Name = "txtSuppIDDel";
            this.txtSuppIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDDel.TabIndex = 82;
            // 
            // txtProdNameDel
            // 
            this.txtProdNameDel.Enabled = false;
            this.txtProdNameDel.Location = new System.Drawing.Point(123, 46);
            this.txtProdNameDel.Name = "txtProdNameDel";
            this.txtProdNameDel.Size = new System.Drawing.Size(198, 20);
            this.txtProdNameDel.TabIndex = 81;
            // 
            // txtProdIDDel
            // 
            this.txtProdIDDel.Location = new System.Drawing.Point(123, 23);
            this.txtProdIDDel.Name = "txtProdIDDel";
            this.txtProdIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtProdIDDel.TabIndex = 67;
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(148, 287);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProd.TabIndex = 57;
            this.btnDeleteProd.Text = "Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Product ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "Product Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 56;
            this.label24.Text = "Units In Stock:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 49;
            this.label25.Text = "Supplier ID:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 224);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 55;
            this.label26.Text = "Reorder Level:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 99);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 13);
            this.label27.TabIndex = 50;
            this.label27.Text = "Category ID:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 248);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "Discontinued:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 13);
            this.label29.TabIndex = 51;
            this.label29.Text = "Quantity Per Unit:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(20, 199);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "Units On Order:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 152);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 13);
            this.label31.TabIndex = 52;
            this.label31.Text = "Unit Price:";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.txtDiscontinuedSearch);
            this.tabSearch.Controls.Add(this.txtReorderLevelSearch);
            this.tabSearch.Controls.Add(this.txtOnOrderSearch);
            this.tabSearch.Controls.Add(this.txtStockSearch);
            this.tabSearch.Controls.Add(this.txtPriceSearch);
            this.tabSearch.Controls.Add(this.txtQuanSearch);
            this.tabSearch.Controls.Add(this.txtCatIDSearch);
            this.tabSearch.Controls.Add(this.txtSuppIDSearch);
            this.tabSearch.Controls.Add(this.txtProdIDSearch);
            this.tabSearch.Controls.Add(this.txtProdNameSearch);
            this.tabSearch.Controls.Add(this.btnSearchProd);
            this.tabSearch.Controls.Add(this.label32);
            this.tabSearch.Controls.Add(this.label33);
            this.tabSearch.Controls.Add(this.label34);
            this.tabSearch.Controls.Add(this.label35);
            this.tabSearch.Controls.Add(this.label36);
            this.tabSearch.Controls.Add(this.label37);
            this.tabSearch.Controls.Add(this.label38);
            this.tabSearch.Controls.Add(this.label39);
            this.tabSearch.Controls.Add(this.label40);
            this.tabSearch.Controls.Add(this.label41);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(340, 331);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // txtDiscontinuedSearch
            // 
            this.txtDiscontinuedSearch.Location = new System.Drawing.Point(123, 245);
            this.txtDiscontinuedSearch.Name = "txtDiscontinuedSearch";
            this.txtDiscontinuedSearch.ReadOnly = true;
            this.txtDiscontinuedSearch.Size = new System.Drawing.Size(198, 20);
            this.txtDiscontinuedSearch.TabIndex = 98;
            // 
            // txtReorderLevelSearch
            // 
            this.txtReorderLevelSearch.Location = new System.Drawing.Point(123, 221);
            this.txtReorderLevelSearch.Name = "txtReorderLevelSearch";
            this.txtReorderLevelSearch.ReadOnly = true;
            this.txtReorderLevelSearch.Size = new System.Drawing.Size(198, 20);
            this.txtReorderLevelSearch.TabIndex = 97;
            // 
            // txtOnOrderSearch
            // 
            this.txtOnOrderSearch.Location = new System.Drawing.Point(123, 196);
            this.txtOnOrderSearch.Name = "txtOnOrderSearch";
            this.txtOnOrderSearch.ReadOnly = true;
            this.txtOnOrderSearch.Size = new System.Drawing.Size(198, 20);
            this.txtOnOrderSearch.TabIndex = 96;
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Location = new System.Drawing.Point(123, 172);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.ReadOnly = true;
            this.txtStockSearch.Size = new System.Drawing.Size(198, 20);
            this.txtStockSearch.TabIndex = 95;
            // 
            // txtPriceSearch
            // 
            this.txtPriceSearch.Location = new System.Drawing.Point(123, 149);
            this.txtPriceSearch.Name = "txtPriceSearch";
            this.txtPriceSearch.ReadOnly = true;
            this.txtPriceSearch.Size = new System.Drawing.Size(198, 20);
            this.txtPriceSearch.TabIndex = 94;
            // 
            // txtQuanSearch
            // 
            this.txtQuanSearch.Location = new System.Drawing.Point(123, 123);
            this.txtQuanSearch.Name = "txtQuanSearch";
            this.txtQuanSearch.ReadOnly = true;
            this.txtQuanSearch.Size = new System.Drawing.Size(198, 20);
            this.txtQuanSearch.TabIndex = 93;
            // 
            // txtCatIDSearch
            // 
            this.txtCatIDSearch.Location = new System.Drawing.Point(123, 96);
            this.txtCatIDSearch.Name = "txtCatIDSearch";
            this.txtCatIDSearch.ReadOnly = true;
            this.txtCatIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDSearch.TabIndex = 92;
            // 
            // txtSuppIDSearch
            // 
            this.txtSuppIDSearch.Location = new System.Drawing.Point(123, 70);
            this.txtSuppIDSearch.Name = "txtSuppIDSearch";
            this.txtSuppIDSearch.ReadOnly = true;
            this.txtSuppIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDSearch.TabIndex = 91;
            // 
            // txtProdIDSearch
            // 
            this.txtProdIDSearch.Location = new System.Drawing.Point(123, 23);
            this.txtProdIDSearch.Name = "txtProdIDSearch";
            this.txtProdIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtProdIDSearch.TabIndex = 89;
            // 
            // txtProdNameSearch
            // 
            this.txtProdNameSearch.Location = new System.Drawing.Point(123, 46);
            this.txtProdNameSearch.Name = "txtProdNameSearch";
            this.txtProdNameSearch.ReadOnly = true;
            this.txtProdNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtProdNameSearch.TabIndex = 80;
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Location = new System.Drawing.Point(148, 287);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProd.TabIndex = 79;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.UseVisualStyleBackColor = true;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 26);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 13);
            this.label32.TabIndex = 69;
            this.label32.Text = "Product ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(20, 49);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 13);
            this.label33.TabIndex = 70;
            this.label33.Text = "Product Name:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(20, 175);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(77, 13);
            this.label34.TabIndex = 78;
            this.label34.Text = "Units In Stock:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(20, 73);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 13);
            this.label35.TabIndex = 71;
            this.label35.Text = "Supplier ID:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(20, 224);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 13);
            this.label36.TabIndex = 77;
            this.label36.Text = "Reorder Level:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(20, 99);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 72;
            this.label37.Text = "Category ID:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 248);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(72, 13);
            this.label38.TabIndex = 76;
            this.label38.Text = "Discontinued:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 126);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(90, 13);
            this.label39.TabIndex = 73;
            this.label39.Text = "Quantity Per Unit:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(20, 199);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(80, 13);
            this.label40.TabIndex = 75;
            this.label40.Text = "Units On Order:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(20, 152);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 13);
            this.label41.TabIndex = 74;
            this.label41.Text = "Unit Price:";
            // 
            // btnBackMainProd
            // 
            this.btnBackMainProd.Location = new System.Drawing.Point(701, 373);
            this.btnBackMainProd.Name = "btnBackMainProd";
            this.btnBackMainProd.Size = new System.Drawing.Size(75, 23);
            this.btnBackMainProd.TabIndex = 36;
            this.btnBackMainProd.Text = "Back";
            this.btnBackMainProd.UseVisualStyleBackColor = true;
            this.btnBackMainProd.Click += new System.EventHandler(this.btnBackMainProd_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 408);
            this.Controls.Add(this.btnBackMainProd);
            this.Controls.Add(this.panel1);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtDiscontinuedAdd;
        private System.Windows.Forms.TextBox txtReorderLevelAdd;
        private System.Windows.Forms.TextBox txtOnOrderAdd;
        private System.Windows.Forms.TextBox txtStockAdd;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.TextBox txtQuanAdd;
        private System.Windows.Forms.TextBox txtCatIDAdd;
        private System.Windows.Forms.TextBox txtSuppIDAdd;
        private System.Windows.Forms.TextBox txtProdNameAdd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtProdIDEdit;
        private System.Windows.Forms.TextBox txtDiscontinuedEdit;
        private System.Windows.Forms.TextBox txtReorderLevelEdit;
        private System.Windows.Forms.TextBox txtOnOrderEdit;
        private System.Windows.Forms.TextBox txtStockEdit;
        private System.Windows.Forms.TextBox txtPriceEdit;
        private System.Windows.Forms.TextBox txtQuanEdit;
        private System.Windows.Forms.TextBox txtCatIDEdit;
        private System.Windows.Forms.TextBox txtSuppIDEdit;
        private System.Windows.Forms.TextBox txtProdNameEdit;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDiscontinuedDel;
        private System.Windows.Forms.TextBox txtReorderLevelDel;
        private System.Windows.Forms.TextBox txtOnOrderDel;
        private System.Windows.Forms.TextBox txtStockDel;
        private System.Windows.Forms.TextBox txtPriceDel;
        private System.Windows.Forms.TextBox txtQuanDel;
        private System.Windows.Forms.TextBox txtCatIDDel;
        private System.Windows.Forms.TextBox txtSuppIDDel;
        private System.Windows.Forms.TextBox txtProdNameDel;
        private System.Windows.Forms.TextBox txtProdIDDel;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtDiscontinuedSearch;
        private System.Windows.Forms.TextBox txtReorderLevelSearch;
        private System.Windows.Forms.TextBox txtOnOrderSearch;
        private System.Windows.Forms.TextBox txtStockSearch;
        private System.Windows.Forms.TextBox txtPriceSearch;
        private System.Windows.Forms.TextBox txtQuanSearch;
        private System.Windows.Forms.TextBox txtCatIDSearch;
        private System.Windows.Forms.TextBox txtSuppIDSearch;
        private System.Windows.Forms.TextBox txtProdIDSearch;
        private System.Windows.Forms.TextBox txtProdNameSearch;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnBackMainProd;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}