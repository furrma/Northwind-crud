namespace northwind
{
    partial class frmSuppliers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtHPageAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFaxAdd = new System.Windows.Forms.TextBox();
            this.txtPhoneAdd = new System.Windows.Forms.TextBox();
            this.txtCountryAdd = new System.Windows.Forms.TextBox();
            this.txtPostalAdd = new System.Windows.Forms.TextBox();
            this.txtRegionAdd = new System.Windows.Forms.TextBox();
            this.txtCityAdd = new System.Windows.Forms.TextBox();
            this.txtAddressAdd = new System.Windows.Forms.TextBox();
            this.txtCTitleAdd = new System.Windows.Forms.TextBox();
            this.txtConNameAdd = new System.Windows.Forms.TextBox();
            this.txtComNameAdd = new System.Windows.Forms.TextBox();
            this.btnSuppAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            this.txtSuppIDEdit = new System.Windows.Forms.TextBox();
            this.txtHPageEdit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFaxEdit = new System.Windows.Forms.TextBox();
            this.txtPhoneEdit = new System.Windows.Forms.TextBox();
            this.txtCountryEdit = new System.Windows.Forms.TextBox();
            this.txtPostalEdit = new System.Windows.Forms.TextBox();
            this.txtRegionEdit = new System.Windows.Forms.TextBox();
            this.txtCityEdit = new System.Windows.Forms.TextBox();
            this.txtAddressEdit = new System.Windows.Forms.TextBox();
            this.txtCTitleEdit = new System.Windows.Forms.TextBox();
            this.txtConNameEdit = new System.Windows.Forms.TextBox();
            this.txtComNameEdit = new System.Windows.Forms.TextBox();
            this.btnSuppEdit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtSuppIDDel = new System.Windows.Forms.TextBox();
            this.btnSuppDel = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.txtSuppIDSearch = new System.Windows.Forms.TextBox();
            this.txtHPageSearch = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtFaxSearch = new System.Windows.Forms.TextBox();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtCountrySearch = new System.Windows.Forms.TextBox();
            this.txtPostalSearch = new System.Windows.Forms.TextBox();
            this.txtRegionSearch = new System.Windows.Forms.TextBox();
            this.txtCitySearch = new System.Windows.Forms.TextBox();
            this.txtAddressSearch = new System.Windows.Forms.TextBox();
            this.txtConTitleSearch = new System.Windows.Forms.TextBox();
            this.txtConNameSearch = new System.Windows.Forms.TextBox();
            this.txtComNameSearch = new System.Windows.Forms.TextBox();
            this.btnSuppSearch = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnBackMainSup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.dgvSuppliers);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 360);
            this.panel1.TabIndex = 1;
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
            this.tabAdd.Controls.Add(this.txtHPageAdd);
            this.tabAdd.Controls.Add(this.label13);
            this.tabAdd.Controls.Add(this.txtFaxAdd);
            this.tabAdd.Controls.Add(this.txtPhoneAdd);
            this.tabAdd.Controls.Add(this.txtCountryAdd);
            this.tabAdd.Controls.Add(this.txtPostalAdd);
            this.tabAdd.Controls.Add(this.txtRegionAdd);
            this.tabAdd.Controls.Add(this.txtCityAdd);
            this.tabAdd.Controls.Add(this.txtAddressAdd);
            this.tabAdd.Controls.Add(this.txtCTitleAdd);
            this.tabAdd.Controls.Add(this.txtConNameAdd);
            this.tabAdd.Controls.Add(this.txtComNameAdd);
            this.tabAdd.Controls.Add(this.btnSuppAdd);
            this.tabAdd.Controls.Add(this.label11);
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
            // txtHPageAdd
            // 
            this.txtHPageAdd.Location = new System.Drawing.Point(123, 266);
            this.txtHPageAdd.Name = "txtHPageAdd";
            this.txtHPageAdd.Size = new System.Drawing.Size(198, 20);
            this.txtHPageAdd.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Homepage:";
            // 
            // txtFaxAdd
            // 
            this.txtFaxAdd.Location = new System.Drawing.Point(123, 240);
            this.txtFaxAdd.Name = "txtFaxAdd";
            this.txtFaxAdd.Size = new System.Drawing.Size(198, 20);
            this.txtFaxAdd.TabIndex = 23;
            // 
            // txtPhoneAdd
            // 
            this.txtPhoneAdd.Location = new System.Drawing.Point(123, 216);
            this.txtPhoneAdd.Name = "txtPhoneAdd";
            this.txtPhoneAdd.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneAdd.TabIndex = 22;
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(123, 192);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCountryAdd.TabIndex = 21;
            // 
            // txtPostalAdd
            // 
            this.txtPostalAdd.Location = new System.Drawing.Point(123, 167);
            this.txtPostalAdd.Name = "txtPostalAdd";
            this.txtPostalAdd.Size = new System.Drawing.Size(198, 20);
            this.txtPostalAdd.TabIndex = 20;
            // 
            // txtRegionAdd
            // 
            this.txtRegionAdd.Location = new System.Drawing.Point(123, 143);
            this.txtRegionAdd.Name = "txtRegionAdd";
            this.txtRegionAdd.Size = new System.Drawing.Size(198, 20);
            this.txtRegionAdd.TabIndex = 19;
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(123, 119);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCityAdd.TabIndex = 18;
            // 
            // txtAddressAdd
            // 
            this.txtAddressAdd.Location = new System.Drawing.Point(123, 93);
            this.txtAddressAdd.Name = "txtAddressAdd";
            this.txtAddressAdd.Size = new System.Drawing.Size(198, 20);
            this.txtAddressAdd.TabIndex = 17;
            // 
            // txtCTitleAdd
            // 
            this.txtCTitleAdd.Location = new System.Drawing.Point(123, 67);
            this.txtCTitleAdd.Name = "txtCTitleAdd";
            this.txtCTitleAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCTitleAdd.TabIndex = 16;
            // 
            // txtConNameAdd
            // 
            this.txtConNameAdd.Location = new System.Drawing.Point(123, 41);
            this.txtConNameAdd.Name = "txtConNameAdd";
            this.txtConNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtConNameAdd.TabIndex = 15;
            // 
            // txtComNameAdd
            // 
            this.txtComNameAdd.Location = new System.Drawing.Point(123, 17);
            this.txtComNameAdd.Name = "txtComNameAdd";
            this.txtComNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtComNameAdd.TabIndex = 14;
            // 
            // btnSuppAdd
            // 
            this.btnSuppAdd.Location = new System.Drawing.Point(141, 302);
            this.btnSuppAdd.Name = "btnSuppAdd";
            this.btnSuppAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSuppAdd.TabIndex = 12;
            this.btnSuppAdd.Text = "Add";
            this.btnSuppAdd.UseVisualStyleBackColor = true;
            this.btnSuppAdd.Click += new System.EventHandler(this.btnSuppAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Postal Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txtSuppIDEdit);
            this.tabEdit.Controls.Add(this.txtHPageEdit);
            this.tabEdit.Controls.Add(this.label14);
            this.tabEdit.Controls.Add(this.txtFaxEdit);
            this.tabEdit.Controls.Add(this.txtPhoneEdit);
            this.tabEdit.Controls.Add(this.txtCountryEdit);
            this.tabEdit.Controls.Add(this.txtPostalEdit);
            this.tabEdit.Controls.Add(this.txtRegionEdit);
            this.tabEdit.Controls.Add(this.txtCityEdit);
            this.tabEdit.Controls.Add(this.txtAddressEdit);
            this.tabEdit.Controls.Add(this.txtCTitleEdit);
            this.tabEdit.Controls.Add(this.txtConNameEdit);
            this.tabEdit.Controls.Add(this.txtComNameEdit);
            this.tabEdit.Controls.Add(this.btnSuppEdit);
            this.tabEdit.Controls.Add(this.label15);
            this.tabEdit.Controls.Add(this.label16);
            this.tabEdit.Controls.Add(this.label17);
            this.tabEdit.Controls.Add(this.label18);
            this.tabEdit.Controls.Add(this.label19);
            this.tabEdit.Controls.Add(this.label20);
            this.tabEdit.Controls.Add(this.label21);
            this.tabEdit.Controls.Add(this.label22);
            this.tabEdit.Controls.Add(this.label23);
            this.tabEdit.Controls.Add(this.label24);
            this.tabEdit.Controls.Add(this.label25);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(340, 331);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txtSuppIDEdit
            // 
            this.txtSuppIDEdit.Location = new System.Drawing.Point(123, 2);
            this.txtSuppIDEdit.Name = "txtSuppIDEdit";
            this.txtSuppIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDEdit.TabIndex = 77;
            // 
            // txtHPageEdit
            // 
            this.txtHPageEdit.Location = new System.Drawing.Point(123, 279);
            this.txtHPageEdit.Name = "txtHPageEdit";
            this.txtHPageEdit.Size = new System.Drawing.Size(198, 20);
            this.txtHPageEdit.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Homepage:";
            // 
            // txtFaxEdit
            // 
            this.txtFaxEdit.Location = new System.Drawing.Point(123, 253);
            this.txtFaxEdit.Name = "txtFaxEdit";
            this.txtFaxEdit.Size = new System.Drawing.Size(198, 20);
            this.txtFaxEdit.TabIndex = 74;
            // 
            // txtPhoneEdit
            // 
            this.txtPhoneEdit.Location = new System.Drawing.Point(123, 229);
            this.txtPhoneEdit.Name = "txtPhoneEdit";
            this.txtPhoneEdit.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneEdit.TabIndex = 73;
            // 
            // txtCountryEdit
            // 
            this.txtCountryEdit.Location = new System.Drawing.Point(123, 205);
            this.txtCountryEdit.Name = "txtCountryEdit";
            this.txtCountryEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCountryEdit.TabIndex = 72;
            // 
            // txtPostalEdit
            // 
            this.txtPostalEdit.Location = new System.Drawing.Point(123, 180);
            this.txtPostalEdit.Name = "txtPostalEdit";
            this.txtPostalEdit.Size = new System.Drawing.Size(198, 20);
            this.txtPostalEdit.TabIndex = 71;
            // 
            // txtRegionEdit
            // 
            this.txtRegionEdit.Location = new System.Drawing.Point(123, 156);
            this.txtRegionEdit.Name = "txtRegionEdit";
            this.txtRegionEdit.Size = new System.Drawing.Size(198, 20);
            this.txtRegionEdit.TabIndex = 70;
            // 
            // txtCityEdit
            // 
            this.txtCityEdit.Location = new System.Drawing.Point(123, 132);
            this.txtCityEdit.Name = "txtCityEdit";
            this.txtCityEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCityEdit.TabIndex = 69;
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Location = new System.Drawing.Point(123, 106);
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(198, 20);
            this.txtAddressEdit.TabIndex = 68;
            // 
            // txtCTitleEdit
            // 
            this.txtCTitleEdit.Location = new System.Drawing.Point(123, 80);
            this.txtCTitleEdit.Name = "txtCTitleEdit";
            this.txtCTitleEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCTitleEdit.TabIndex = 67;
            // 
            // txtConNameEdit
            // 
            this.txtConNameEdit.Location = new System.Drawing.Point(123, 54);
            this.txtConNameEdit.Name = "txtConNameEdit";
            this.txtConNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtConNameEdit.TabIndex = 66;
            // 
            // txtComNameEdit
            // 
            this.txtComNameEdit.Location = new System.Drawing.Point(123, 30);
            this.txtComNameEdit.Name = "txtComNameEdit";
            this.txtComNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtComNameEdit.TabIndex = 65;
            // 
            // btnSuppEdit
            // 
            this.btnSuppEdit.Location = new System.Drawing.Point(143, 305);
            this.btnSuppEdit.Name = "btnSuppEdit";
            this.btnSuppEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSuppEdit.TabIndex = 64;
            this.btnSuppEdit.Text = "Edit";
            this.btnSuppEdit.UseVisualStyleBackColor = true;
            this.btnSuppEdit.Click += new System.EventHandler(this.btnSuppEdit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Supplier ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Fax:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Company Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Region:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Contact Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Country:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Contact Title:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 236);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Phone:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "Address:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 187);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 59;
            this.label24.Text = "Postal Code:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 145);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "City:";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtSuppIDDel);
            this.tabDelete.Controls.Add(this.btnSuppDel);
            this.tabDelete.Controls.Add(this.label27);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(340, 331);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtSuppIDDel
            // 
            this.txtSuppIDDel.Location = new System.Drawing.Point(112, 120);
            this.txtSuppIDDel.Name = "txtSuppIDDel";
            this.txtSuppIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDDel.TabIndex = 79;
            // 
            // btnSuppDel
            // 
            this.btnSuppDel.Location = new System.Drawing.Point(127, 167);
            this.btnSuppDel.Name = "btnSuppDel";
            this.btnSuppDel.Size = new System.Drawing.Size(75, 23);
            this.btnSuppDel.TabIndex = 64;
            this.btnSuppDel.Text = "Delete";
            this.btnSuppDel.UseVisualStyleBackColor = true;
            this.btnSuppDel.Click += new System.EventHandler(this.btnSuppDel_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(32, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 53;
            this.label27.Text = "Supplier ID:";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.txtSuppIDSearch);
            this.tabSearch.Controls.Add(this.txtHPageSearch);
            this.tabSearch.Controls.Add(this.label38);
            this.tabSearch.Controls.Add(this.txtFaxSearch);
            this.tabSearch.Controls.Add(this.txtPhoneSearch);
            this.tabSearch.Controls.Add(this.txtCountrySearch);
            this.tabSearch.Controls.Add(this.txtPostalSearch);
            this.tabSearch.Controls.Add(this.txtRegionSearch);
            this.tabSearch.Controls.Add(this.txtCitySearch);
            this.tabSearch.Controls.Add(this.txtAddressSearch);
            this.tabSearch.Controls.Add(this.txtConTitleSearch);
            this.tabSearch.Controls.Add(this.txtConNameSearch);
            this.tabSearch.Controls.Add(this.txtComNameSearch);
            this.tabSearch.Controls.Add(this.btnSuppSearch);
            this.tabSearch.Controls.Add(this.label40);
            this.tabSearch.Controls.Add(this.label41);
            this.tabSearch.Controls.Add(this.label42);
            this.tabSearch.Controls.Add(this.label43);
            this.tabSearch.Controls.Add(this.label44);
            this.tabSearch.Controls.Add(this.label45);
            this.tabSearch.Controls.Add(this.label46);
            this.tabSearch.Controls.Add(this.label47);
            this.tabSearch.Controls.Add(this.label48);
            this.tabSearch.Controls.Add(this.label51);
            this.tabSearch.Controls.Add(this.label52);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(340, 331);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // txtSuppIDSearch
            // 
            this.txtSuppIDSearch.Location = new System.Drawing.Point(123, 8);
            this.txtSuppIDSearch.Name = "txtSuppIDSearch";
            this.txtSuppIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSuppIDSearch.TabIndex = 52;
            // 
            // txtHPageSearch
            // 
            this.txtHPageSearch.Location = new System.Drawing.Point(123, 282);
            this.txtHPageSearch.Name = "txtHPageSearch";
            this.txtHPageSearch.ReadOnly = true;
            this.txtHPageSearch.Size = new System.Drawing.Size(198, 20);
            this.txtHPageSearch.TabIndex = 51;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 285);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(62, 13);
            this.label38.TabIndex = 50;
            this.label38.Text = "Homepage:";
            // 
            // txtFaxSearch
            // 
            this.txtFaxSearch.Location = new System.Drawing.Point(123, 256);
            this.txtFaxSearch.Name = "txtFaxSearch";
            this.txtFaxSearch.ReadOnly = true;
            this.txtFaxSearch.Size = new System.Drawing.Size(198, 20);
            this.txtFaxSearch.TabIndex = 48;
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(123, 232);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.ReadOnly = true;
            this.txtPhoneSearch.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneSearch.TabIndex = 47;
            // 
            // txtCountrySearch
            // 
            this.txtCountrySearch.Location = new System.Drawing.Point(123, 208);
            this.txtCountrySearch.Name = "txtCountrySearch";
            this.txtCountrySearch.ReadOnly = true;
            this.txtCountrySearch.Size = new System.Drawing.Size(198, 20);
            this.txtCountrySearch.TabIndex = 46;
            // 
            // txtPostalSearch
            // 
            this.txtPostalSearch.Location = new System.Drawing.Point(123, 183);
            this.txtPostalSearch.Name = "txtPostalSearch";
            this.txtPostalSearch.ReadOnly = true;
            this.txtPostalSearch.Size = new System.Drawing.Size(198, 20);
            this.txtPostalSearch.TabIndex = 45;
            // 
            // txtRegionSearch
            // 
            this.txtRegionSearch.Location = new System.Drawing.Point(123, 159);
            this.txtRegionSearch.Name = "txtRegionSearch";
            this.txtRegionSearch.ReadOnly = true;
            this.txtRegionSearch.Size = new System.Drawing.Size(198, 20);
            this.txtRegionSearch.TabIndex = 44;
            // 
            // txtCitySearch
            // 
            this.txtCitySearch.Location = new System.Drawing.Point(123, 135);
            this.txtCitySearch.Name = "txtCitySearch";
            this.txtCitySearch.ReadOnly = true;
            this.txtCitySearch.Size = new System.Drawing.Size(198, 20);
            this.txtCitySearch.TabIndex = 43;
            // 
            // txtAddressSearch
            // 
            this.txtAddressSearch.Location = new System.Drawing.Point(123, 109);
            this.txtAddressSearch.Name = "txtAddressSearch";
            this.txtAddressSearch.ReadOnly = true;
            this.txtAddressSearch.Size = new System.Drawing.Size(198, 20);
            this.txtAddressSearch.TabIndex = 42;
            // 
            // txtConTitleSearch
            // 
            this.txtConTitleSearch.Location = new System.Drawing.Point(123, 83);
            this.txtConTitleSearch.Name = "txtConTitleSearch";
            this.txtConTitleSearch.ReadOnly = true;
            this.txtConTitleSearch.Size = new System.Drawing.Size(198, 20);
            this.txtConTitleSearch.TabIndex = 41;
            // 
            // txtConNameSearch
            // 
            this.txtConNameSearch.Location = new System.Drawing.Point(123, 57);
            this.txtConNameSearch.Name = "txtConNameSearch";
            this.txtConNameSearch.ReadOnly = true;
            this.txtConNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtConNameSearch.TabIndex = 40;
            // 
            // txtComNameSearch
            // 
            this.txtComNameSearch.Location = new System.Drawing.Point(123, 33);
            this.txtComNameSearch.Name = "txtComNameSearch";
            this.txtComNameSearch.ReadOnly = true;
            this.txtComNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtComNameSearch.TabIndex = 39;
            // 
            // btnSuppSearch
            // 
            this.btnSuppSearch.Location = new System.Drawing.Point(143, 308);
            this.btnSuppSearch.Name = "btnSuppSearch";
            this.btnSuppSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSuppSearch.TabIndex = 38;
            this.btnSuppSearch.Text = "Search";
            this.btnSuppSearch.UseVisualStyleBackColor = true;
            this.btnSuppSearch.Click += new System.EventHandler(this.btnSuppSearch_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(20, 8);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(62, 13);
            this.label40.TabIndex = 27;
            this.label40.Text = "Supplier ID:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(20, 259);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(27, 13);
            this.label41.TabIndex = 37;
            this.label41.Text = "Fax:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(20, 40);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(85, 13);
            this.label42.TabIndex = 28;
            this.label42.Text = "Company Name:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(20, 166);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(41, 13);
            this.label43.TabIndex = 36;
            this.label43.Text = "Region";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 64);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 13);
            this.label44.TabIndex = 29;
            this.label44.Text = "Contact Name:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 215);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(46, 13);
            this.label45.TabIndex = 35;
            this.label45.Text = "Country:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(20, 90);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(70, 13);
            this.label46.TabIndex = 30;
            this.label46.Text = "Contact Title:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(20, 239);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 13);
            this.label47.TabIndex = 34;
            this.label47.Text = "Phone:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(20, 117);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(48, 13);
            this.label48.TabIndex = 31;
            this.label48.Text = "Address:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(20, 190);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 13);
            this.label51.TabIndex = 33;
            this.label51.Text = "Postal Code:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(20, 148);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(27, 13);
            this.label52.TabIndex = 32;
            this.label52.Text = "City:";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(353, 3);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(410, 354);
            this.dgvSuppliers.TabIndex = 2;
            this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
            // 
            // btnBackMainSup
            // 
            this.btnBackMainSup.Location = new System.Drawing.Point(692, 371);
            this.btnBackMainSup.Name = "btnBackMainSup";
            this.btnBackMainSup.Size = new System.Drawing.Size(75, 23);
            this.btnBackMainSup.TabIndex = 65;
            this.btnBackMainSup.Text = "Back";
            this.btnBackMainSup.UseVisualStyleBackColor = true;
            this.btnBackMainSup.Click += new System.EventHandler(this.btnBackMainSup_Click);
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 406);
            this.Controls.Add(this.btnBackMainSup);
            this.Controls.Add(this.panel1);
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtHPageAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFaxAdd;
        private System.Windows.Forms.TextBox txtPhoneAdd;
        private System.Windows.Forms.TextBox txtCountryAdd;
        private System.Windows.Forms.TextBox txtPostalAdd;
        private System.Windows.Forms.TextBox txtRegionAdd;
        private System.Windows.Forms.TextBox txtCityAdd;
        private System.Windows.Forms.TextBox txtAddressAdd;
        private System.Windows.Forms.TextBox txtCTitleAdd;
        private System.Windows.Forms.TextBox txtConNameAdd;
        private System.Windows.Forms.TextBox txtComNameAdd;
        private System.Windows.Forms.Button btnSuppAdd;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.TextBox txtSuppIDEdit;
        private System.Windows.Forms.TextBox txtHPageEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFaxEdit;
        private System.Windows.Forms.TextBox txtPhoneEdit;
        private System.Windows.Forms.TextBox txtCountryEdit;
        private System.Windows.Forms.TextBox txtPostalEdit;
        private System.Windows.Forms.TextBox txtRegionEdit;
        private System.Windows.Forms.TextBox txtCityEdit;
        private System.Windows.Forms.TextBox txtAddressEdit;
        private System.Windows.Forms.TextBox txtCTitleEdit;
        private System.Windows.Forms.TextBox txtConNameEdit;
        private System.Windows.Forms.TextBox txtComNameEdit;
        private System.Windows.Forms.Button btnSuppEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox txtSuppIDDel;
        private System.Windows.Forms.Button btnSuppDel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtHPageSearch;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtFaxSearch;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.TextBox txtCountrySearch;
        private System.Windows.Forms.TextBox txtPostalSearch;
        private System.Windows.Forms.TextBox txtRegionSearch;
        private System.Windows.Forms.TextBox txtCitySearch;
        private System.Windows.Forms.TextBox txtAddressSearch;
        private System.Windows.Forms.TextBox txtConTitleSearch;
        private System.Windows.Forms.TextBox txtConNameSearch;
        private System.Windows.Forms.TextBox txtComNameSearch;
        private System.Windows.Forms.Button btnSuppSearch;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnBackMainSup;
        private System.Windows.Forms.TextBox txtSuppIDSearch;
    }
}