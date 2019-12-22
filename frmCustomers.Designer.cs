namespace northwind
{
    partial class frmCustomers
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
            this.btnAddCust = new System.Windows.Forms.Button();
            this.txtCustIDAdd = new System.Windows.Forms.TextBox();
            this.txtFaxAdd = new System.Windows.Forms.TextBox();
            this.txtPhoneAdd = new System.Windows.Forms.TextBox();
            this.txtCountryAdd = new System.Windows.Forms.TextBox();
            this.txtPostalCodeAdd = new System.Windows.Forms.TextBox();
            this.txtRegionAdd = new System.Windows.Forms.TextBox();
            this.txtCityAdd = new System.Windows.Forms.TextBox();
            this.txtAddressAdd = new System.Windows.Forms.TextBox();
            this.txtContactTitleAdd = new System.Windows.Forms.TextBox();
            this.txtContactNameAdd = new System.Windows.Forms.TextBox();
            this.txtCompanyNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtCustIDEdit = new System.Windows.Forms.TextBox();
            this.txtFaxEdit = new System.Windows.Forms.TextBox();
            this.txtPhoneEdit = new System.Windows.Forms.TextBox();
            this.txtCountryEdit = new System.Windows.Forms.TextBox();
            this.txtPostalEdit = new System.Windows.Forms.TextBox();
            this.txtRegionEdit = new System.Windows.Forms.TextBox();
            this.txtCityEdit = new System.Windows.Forms.TextBox();
            this.txtAddressEdit = new System.Windows.Forms.TextBox();
            this.txtContactTitleEdit = new System.Windows.Forms.TextBox();
            this.txtContactNameEdit = new System.Windows.Forms.TextBox();
            this.txtCompanyNameEdit = new System.Windows.Forms.TextBox();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
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
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtCustIDDel = new System.Windows.Forms.TextBox();
            this.btnCustDel = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.txtFaxSearch = new System.Windows.Forms.TextBox();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtCountrySearch = new System.Windows.Forms.TextBox();
            this.txtPostalSearch = new System.Windows.Forms.TextBox();
            this.txtRegionSearch = new System.Windows.Forms.TextBox();
            this.txtCitySearch = new System.Windows.Forms.TextBox();
            this.txtAddressSearch = new System.Windows.Forms.TextBox();
            this.txtContactTitleSearch = new System.Windows.Forms.TextBox();
            this.txtContactNameSearch = new System.Windows.Forms.TextBox();
            this.txtCustIDSearch = new System.Windows.Forms.TextBox();
            this.txtCompanyNameSearch = new System.Windows.Forms.TextBox();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnBackMainCus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.dgvCustomers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 360);
            this.panel1.TabIndex = 0;
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
            this.tabAdd.Controls.Add(this.btnAddCust);
            this.tabAdd.Controls.Add(this.txtCustIDAdd);
            this.tabAdd.Controls.Add(this.txtFaxAdd);
            this.tabAdd.Controls.Add(this.txtPhoneAdd);
            this.tabAdd.Controls.Add(this.txtCountryAdd);
            this.tabAdd.Controls.Add(this.txtPostalCodeAdd);
            this.tabAdd.Controls.Add(this.txtRegionAdd);
            this.tabAdd.Controls.Add(this.txtCityAdd);
            this.tabAdd.Controls.Add(this.txtAddressAdd);
            this.tabAdd.Controls.Add(this.txtContactTitleAdd);
            this.tabAdd.Controls.Add(this.txtContactNameAdd);
            this.tabAdd.Controls.Add(this.txtCompanyNameAdd);
            this.tabAdd.Controls.Add(this.label1);
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
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(133, 302);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(75, 23);
            this.btnAddCust.TabIndex = 25;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // txtCustIDAdd
            // 
            this.txtCustIDAdd.Location = new System.Drawing.Point(116, 13);
            this.txtCustIDAdd.MaxLength = 5212121;
            this.txtCustIDAdd.Name = "txtCustIDAdd";
            this.txtCustIDAdd.ReadOnly = true;
            this.txtCustIDAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCustIDAdd.TabIndex = 24;
            // 
            // txtFaxAdd
            // 
            this.txtFaxAdd.Location = new System.Drawing.Point(116, 259);
            this.txtFaxAdd.Name = "txtFaxAdd";
            this.txtFaxAdd.Size = new System.Drawing.Size(198, 20);
            this.txtFaxAdd.TabIndex = 23;
            // 
            // txtPhoneAdd
            // 
            this.txtPhoneAdd.Location = new System.Drawing.Point(116, 235);
            this.txtPhoneAdd.Name = "txtPhoneAdd";
            this.txtPhoneAdd.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneAdd.TabIndex = 22;
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(116, 211);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCountryAdd.TabIndex = 21;
            // 
            // txtPostalCodeAdd
            // 
            this.txtPostalCodeAdd.Location = new System.Drawing.Point(116, 186);
            this.txtPostalCodeAdd.Name = "txtPostalCodeAdd";
            this.txtPostalCodeAdd.Size = new System.Drawing.Size(198, 20);
            this.txtPostalCodeAdd.TabIndex = 20;
            // 
            // txtRegionAdd
            // 
            this.txtRegionAdd.Location = new System.Drawing.Point(116, 162);
            this.txtRegionAdd.Name = "txtRegionAdd";
            this.txtRegionAdd.Size = new System.Drawing.Size(198, 20);
            this.txtRegionAdd.TabIndex = 19;
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(116, 139);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCityAdd.TabIndex = 18;
            // 
            // txtAddressAdd
            // 
            this.txtAddressAdd.Location = new System.Drawing.Point(116, 113);
            this.txtAddressAdd.Name = "txtAddressAdd";
            this.txtAddressAdd.Size = new System.Drawing.Size(198, 20);
            this.txtAddressAdd.TabIndex = 17;
            // 
            // txtContactTitleAdd
            // 
            this.txtContactTitleAdd.Location = new System.Drawing.Point(116, 86);
            this.txtContactTitleAdd.Name = "txtContactTitleAdd";
            this.txtContactTitleAdd.Size = new System.Drawing.Size(198, 20);
            this.txtContactTitleAdd.TabIndex = 16;
            // 
            // txtContactNameAdd
            // 
            this.txtContactNameAdd.Location = new System.Drawing.Point(116, 60);
            this.txtContactNameAdd.Name = "txtContactNameAdd";
            this.txtContactNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtContactNameAdd.TabIndex = 15;
            // 
            // txtCompanyNameAdd
            // 
            this.txtCompanyNameAdd.Location = new System.Drawing.Point(116, 36);
            this.txtCompanyNameAdd.Name = "txtCompanyNameAdd";
            this.txtCompanyNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCompanyNameAdd.TabIndex = 14;
            this.txtCompanyNameAdd.TextChanged += new System.EventHandler(this.txtCompanyNameAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Postal Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txtCustIDEdit);
            this.tabEdit.Controls.Add(this.txtFaxEdit);
            this.tabEdit.Controls.Add(this.txtPhoneEdit);
            this.tabEdit.Controls.Add(this.txtCountryEdit);
            this.tabEdit.Controls.Add(this.txtPostalEdit);
            this.tabEdit.Controls.Add(this.txtRegionEdit);
            this.tabEdit.Controls.Add(this.txtCityEdit);
            this.tabEdit.Controls.Add(this.txtAddressEdit);
            this.tabEdit.Controls.Add(this.txtContactTitleEdit);
            this.tabEdit.Controls.Add(this.txtContactNameEdit);
            this.tabEdit.Controls.Add(this.txtCompanyNameEdit);
            this.tabEdit.Controls.Add(this.btnEditCust);
            this.tabEdit.Controls.Add(this.label14);
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
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(340, 331);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txtCustIDEdit
            // 
            this.txtCustIDEdit.Location = new System.Drawing.Point(123, 8);
            this.txtCustIDEdit.Name = "txtCustIDEdit";
            this.txtCustIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCustIDEdit.TabIndex = 47;
            // 
            // txtFaxEdit
            // 
            this.txtFaxEdit.Location = new System.Drawing.Point(123, 254);
            this.txtFaxEdit.Name = "txtFaxEdit";
            this.txtFaxEdit.Size = new System.Drawing.Size(198, 20);
            this.txtFaxEdit.TabIndex = 46;
            // 
            // txtPhoneEdit
            // 
            this.txtPhoneEdit.Location = new System.Drawing.Point(123, 230);
            this.txtPhoneEdit.Name = "txtPhoneEdit";
            this.txtPhoneEdit.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneEdit.TabIndex = 45;
            // 
            // txtCountryEdit
            // 
            this.txtCountryEdit.Location = new System.Drawing.Point(123, 206);
            this.txtCountryEdit.Name = "txtCountryEdit";
            this.txtCountryEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCountryEdit.TabIndex = 44;
            // 
            // txtPostalEdit
            // 
            this.txtPostalEdit.Location = new System.Drawing.Point(123, 181);
            this.txtPostalEdit.Name = "txtPostalEdit";
            this.txtPostalEdit.Size = new System.Drawing.Size(198, 20);
            this.txtPostalEdit.TabIndex = 43;
            // 
            // txtRegionEdit
            // 
            this.txtRegionEdit.Location = new System.Drawing.Point(123, 157);
            this.txtRegionEdit.Name = "txtRegionEdit";
            this.txtRegionEdit.Size = new System.Drawing.Size(198, 20);
            this.txtRegionEdit.TabIndex = 42;
            // 
            // txtCityEdit
            // 
            this.txtCityEdit.Location = new System.Drawing.Point(123, 134);
            this.txtCityEdit.Name = "txtCityEdit";
            this.txtCityEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCityEdit.TabIndex = 41;
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Location = new System.Drawing.Point(123, 108);
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(198, 20);
            this.txtAddressEdit.TabIndex = 40;
            // 
            // txtContactTitleEdit
            // 
            this.txtContactTitleEdit.Location = new System.Drawing.Point(123, 81);
            this.txtContactTitleEdit.Name = "txtContactTitleEdit";
            this.txtContactTitleEdit.Size = new System.Drawing.Size(198, 20);
            this.txtContactTitleEdit.TabIndex = 39;
            // 
            // txtContactNameEdit
            // 
            this.txtContactNameEdit.Location = new System.Drawing.Point(123, 55);
            this.txtContactNameEdit.Name = "txtContactNameEdit";
            this.txtContactNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtContactNameEdit.TabIndex = 38;
            // 
            // txtCompanyNameEdit
            // 
            this.txtCompanyNameEdit.Location = new System.Drawing.Point(123, 31);
            this.txtCompanyNameEdit.Name = "txtCompanyNameEdit";
            this.txtCompanyNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCompanyNameEdit.TabIndex = 37;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(148, 297);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(75, 23);
            this.btnEditCust.TabIndex = 36;
            this.btnEditCust.Text = "Edit";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Customer ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Fax:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Company Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Region";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Contact Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Country:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Contact Title:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 233);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Phone:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Address:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 184);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Postal Code:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "City:";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtCustIDDel);
            this.tabDelete.Controls.Add(this.btnCustDel);
            this.tabDelete.Controls.Add(this.label26);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(340, 331);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtCustIDDel
            // 
            this.txtCustIDDel.Location = new System.Drawing.Point(120, 116);
            this.txtCustIDDel.Name = "txtCustIDDel";
            this.txtCustIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtCustIDDel.TabIndex = 58;
            // 
            // btnCustDel
            // 
            this.btnCustDel.Location = new System.Drawing.Point(120, 159);
            this.btnCustDel.Name = "btnCustDel";
            this.btnCustDel.Size = new System.Drawing.Size(75, 23);
            this.btnCustDel.TabIndex = 36;
            this.btnCustDel.Text = "Delete";
            this.btnCustDel.UseVisualStyleBackColor = true;
            this.btnCustDel.Click += new System.EventHandler(this.btnCustDel_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 119);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Customer ID:";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.txtFaxSearch);
            this.tabSearch.Controls.Add(this.txtPhoneSearch);
            this.tabSearch.Controls.Add(this.txtCountrySearch);
            this.tabSearch.Controls.Add(this.txtPostalSearch);
            this.tabSearch.Controls.Add(this.txtRegionSearch);
            this.tabSearch.Controls.Add(this.txtCitySearch);
            this.tabSearch.Controls.Add(this.txtAddressSearch);
            this.tabSearch.Controls.Add(this.txtContactTitleSearch);
            this.tabSearch.Controls.Add(this.txtContactNameSearch);
            this.tabSearch.Controls.Add(this.txtCustIDSearch);
            this.tabSearch.Controls.Add(this.txtCompanyNameSearch);
            this.tabSearch.Controls.Add(this.btnCustSearch);
            this.tabSearch.Controls.Add(this.label38);
            this.tabSearch.Controls.Add(this.label39);
            this.tabSearch.Controls.Add(this.label40);
            this.tabSearch.Controls.Add(this.label41);
            this.tabSearch.Controls.Add(this.label42);
            this.tabSearch.Controls.Add(this.label43);
            this.tabSearch.Controls.Add(this.label44);
            this.tabSearch.Controls.Add(this.label45);
            this.tabSearch.Controls.Add(this.label46);
            this.tabSearch.Controls.Add(this.label47);
            this.tabSearch.Controls.Add(this.label48);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(340, 331);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // txtFaxSearch
            // 
            this.txtFaxSearch.Location = new System.Drawing.Point(123, 254);
            this.txtFaxSearch.Name = "txtFaxSearch";
            this.txtFaxSearch.ReadOnly = true;
            this.txtFaxSearch.Size = new System.Drawing.Size(198, 20);
            this.txtFaxSearch.TabIndex = 47;
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(123, 230);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.ReadOnly = true;
            this.txtPhoneSearch.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneSearch.TabIndex = 46;
            // 
            // txtCountrySearch
            // 
            this.txtCountrySearch.Location = new System.Drawing.Point(123, 206);
            this.txtCountrySearch.Name = "txtCountrySearch";
            this.txtCountrySearch.ReadOnly = true;
            this.txtCountrySearch.Size = new System.Drawing.Size(198, 20);
            this.txtCountrySearch.TabIndex = 45;
            // 
            // txtPostalSearch
            // 
            this.txtPostalSearch.Location = new System.Drawing.Point(123, 181);
            this.txtPostalSearch.Name = "txtPostalSearch";
            this.txtPostalSearch.ReadOnly = true;
            this.txtPostalSearch.Size = new System.Drawing.Size(198, 20);
            this.txtPostalSearch.TabIndex = 44;
            // 
            // txtRegionSearch
            // 
            this.txtRegionSearch.Location = new System.Drawing.Point(123, 157);
            this.txtRegionSearch.Name = "txtRegionSearch";
            this.txtRegionSearch.ReadOnly = true;
            this.txtRegionSearch.Size = new System.Drawing.Size(198, 20);
            this.txtRegionSearch.TabIndex = 43;
            // 
            // txtCitySearch
            // 
            this.txtCitySearch.Location = new System.Drawing.Point(123, 134);
            this.txtCitySearch.Name = "txtCitySearch";
            this.txtCitySearch.ReadOnly = true;
            this.txtCitySearch.Size = new System.Drawing.Size(198, 20);
            this.txtCitySearch.TabIndex = 42;
            // 
            // txtAddressSearch
            // 
            this.txtAddressSearch.Location = new System.Drawing.Point(123, 108);
            this.txtAddressSearch.Name = "txtAddressSearch";
            this.txtAddressSearch.ReadOnly = true;
            this.txtAddressSearch.Size = new System.Drawing.Size(198, 20);
            this.txtAddressSearch.TabIndex = 41;
            // 
            // txtContactTitleSearch
            // 
            this.txtContactTitleSearch.Location = new System.Drawing.Point(123, 81);
            this.txtContactTitleSearch.Name = "txtContactTitleSearch";
            this.txtContactTitleSearch.ReadOnly = true;
            this.txtContactTitleSearch.Size = new System.Drawing.Size(198, 20);
            this.txtContactTitleSearch.TabIndex = 40;
            // 
            // txtContactNameSearch
            // 
            this.txtContactNameSearch.Location = new System.Drawing.Point(123, 55);
            this.txtContactNameSearch.Name = "txtContactNameSearch";
            this.txtContactNameSearch.ReadOnly = true;
            this.txtContactNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtContactNameSearch.TabIndex = 39;
            // 
            // txtCustIDSearch
            // 
            this.txtCustIDSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustIDSearch.Location = new System.Drawing.Point(123, 8);
            this.txtCustIDSearch.Name = "txtCustIDSearch";
            this.txtCustIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtCustIDSearch.TabIndex = 38;
            // 
            // txtCompanyNameSearch
            // 
            this.txtCompanyNameSearch.Location = new System.Drawing.Point(123, 31);
            this.txtCompanyNameSearch.Name = "txtCompanyNameSearch";
            this.txtCompanyNameSearch.ReadOnly = true;
            this.txtCompanyNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtCompanyNameSearch.TabIndex = 37;
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(148, 297);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCustSearch.TabIndex = 36;
            this.btnCustSearch.Text = "Search";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.btnCustSearch_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 11);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(68, 13);
            this.label38.TabIndex = 25;
            this.label38.Text = "Customer ID:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 257);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 35;
            this.label39.Text = "Fax:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(20, 34);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(85, 13);
            this.label40.TabIndex = 26;
            this.label40.Text = "Company Name:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(20, 160);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 13);
            this.label41.TabIndex = 34;
            this.label41.Text = "Region";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(20, 58);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(78, 13);
            this.label42.TabIndex = 27;
            this.label42.Text = "Contact Name:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(20, 209);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(46, 13);
            this.label43.TabIndex = 33;
            this.label43.Text = "Country:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 84);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(70, 13);
            this.label44.TabIndex = 28;
            this.label44.Text = "Contact Title:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 233);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 13);
            this.label45.TabIndex = 32;
            this.label45.Text = "Phone:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(20, 111);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(48, 13);
            this.label46.TabIndex = 29;
            this.label46.Text = "Address:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(20, 184);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 13);
            this.label47.TabIndex = 31;
            this.label47.Text = "Postal Code:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(20, 137);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(27, 13);
            this.label48.TabIndex = 30;
            this.label48.Text = "City:";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(353, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(410, 354);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // btnBackMainCus
            // 
            this.btnBackMainCus.Location = new System.Drawing.Point(703, 380);
            this.btnBackMainCus.Name = "btnBackMainCus";
            this.btnBackMainCus.Size = new System.Drawing.Size(75, 23);
            this.btnBackMainCus.TabIndex = 14;
            this.btnBackMainCus.Text = "Back";
            this.btnBackMainCus.UseVisualStyleBackColor = true;
            this.btnBackMainCus.Click += new System.EventHandler(this.btnBackMainCus_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(790, 415);
            this.Controls.Add(this.btnBackMainCus);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtFaxAdd;
        private System.Windows.Forms.TextBox txtPhoneAdd;
        private System.Windows.Forms.TextBox txtCountryAdd;
        private System.Windows.Forms.TextBox txtPostalCodeAdd;
        private System.Windows.Forms.TextBox txtRegionAdd;
        private System.Windows.Forms.TextBox txtCityAdd;
        private System.Windows.Forms.TextBox txtAddressAdd;
        private System.Windows.Forms.TextBox txtContactTitleAdd;
        private System.Windows.Forms.TextBox txtContactNameAdd;
        private System.Windows.Forms.TextBox txtCompanyNameAdd;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtCustIDEdit;
        private System.Windows.Forms.TextBox txtFaxEdit;
        private System.Windows.Forms.TextBox txtPhoneEdit;
        private System.Windows.Forms.TextBox txtCountryEdit;
        private System.Windows.Forms.TextBox txtPostalEdit;
        private System.Windows.Forms.TextBox txtRegionEdit;
        private System.Windows.Forms.TextBox txtCityEdit;
        private System.Windows.Forms.TextBox txtAddressEdit;
        private System.Windows.Forms.TextBox txtContactTitleEdit;
        private System.Windows.Forms.TextBox txtContactNameEdit;
        private System.Windows.Forms.TextBox txtCompanyNameEdit;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox txtCustIDDel;
        private System.Windows.Forms.Button btnCustDel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtFaxSearch;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.TextBox txtCountrySearch;
        private System.Windows.Forms.TextBox txtPostalSearch;
        private System.Windows.Forms.TextBox txtRegionSearch;
        private System.Windows.Forms.TextBox txtCitySearch;
        private System.Windows.Forms.TextBox txtAddressSearch;
        private System.Windows.Forms.TextBox txtContactTitleSearch;
        private System.Windows.Forms.TextBox txtContactNameSearch;
        private System.Windows.Forms.TextBox txtCustIDSearch;
        private System.Windows.Forms.TextBox txtCompanyNameSearch;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnBackMainCus;
        private System.Windows.Forms.TextBox txtCustIDAdd;
        private System.Windows.Forms.Button btnAddCust;
    }
}