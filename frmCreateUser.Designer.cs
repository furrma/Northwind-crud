namespace northwind
{
    partial class frmCreateUser
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAnswerAdd = new System.Windows.Forms.ComboBox();
            this.txtUsernameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetypeAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAccounts = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.cmbAnswerEdit = new System.Windows.Forms.ComboBox();
            this.txtRetypeEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsernameEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDDel = new System.Windows.Forms.TextBox();
            this.cmbAnswerDel = new System.Windows.Forms.ComboBox();
            this.txtRetypeDel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPasswordDel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUsernameDel = new System.Windows.Forms.TextBox();
            this.btnIDDel = new System.Windows.Forms.Button();
            this.btnIDEdit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIDEdit = new System.Windows.Forms.TextBox();
            this.tabAccounts.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAnswerAdd
            // 
            this.cmbAnswerAdd.FormattingEnabled = true;
            this.cmbAnswerAdd.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "white",
            "black",
            "orange",
            "purple"});
            this.cmbAnswerAdd.Location = new System.Drawing.Point(206, 150);
            this.cmbAnswerAdd.Name = "cmbAnswerAdd";
            this.cmbAnswerAdd.Size = new System.Drawing.Size(151, 21);
            this.cmbAnswerAdd.TabIndex = 21;
            // 
            // txtUsernameAdd
            // 
            this.txtUsernameAdd.Location = new System.Drawing.Point(206, 72);
            this.txtUsernameAdd.Name = "txtUsernameAdd";
            this.txtUsernameAdd.Size = new System.Drawing.Size(151, 20);
            this.txtUsernameAdd.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "What is your favorite color?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Create New Account:";
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(206, 98);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(151, 20);
            this.txtPasswordAdd.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password:";
            // 
            // txtRetypeAdd
            // 
            this.txtRetypeAdd.Location = new System.Drawing.Point(206, 124);
            this.txtRetypeAdd.Name = "txtRetypeAdd";
            this.txtRetypeAdd.Size = new System.Drawing.Size(151, 20);
            this.txtRetypeAdd.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Retype Password:";
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.tabAdd);
            this.tabAccounts.Controls.Add(this.tabEdit);
            this.tabAccounts.Controls.Add(this.tabDelete);
            this.tabAccounts.Location = new System.Drawing.Point(12, 12);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.SelectedIndex = 0;
            this.tabAccounts.Size = new System.Drawing.Size(423, 281);
            this.tabAccounts.TabIndex = 28;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.cmbAnswerAdd);
            this.tabAdd.Controls.Add(this.txtRetypeAdd);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.txtPasswordAdd);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.txtUsernameAdd);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(415, 255);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Account";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.btnIDEdit);
            this.tabEdit.Controls.Add(this.label13);
            this.tabEdit.Controls.Add(this.txtIDEdit);
            this.tabEdit.Controls.Add(this.cmbAnswerEdit);
            this.tabEdit.Controls.Add(this.txtRetypeEdit);
            this.tabEdit.Controls.Add(this.label6);
            this.tabEdit.Controls.Add(this.label7);
            this.tabEdit.Controls.Add(this.label8);
            this.tabEdit.Controls.Add(this.txtPasswordEdit);
            this.tabEdit.Controls.Add(this.label9);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.txtUsernameEdit);
            this.tabEdit.Controls.Add(this.btnEdit);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(415, 255);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit Account";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnIDDel);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.txtIDDel);
            this.tabDelete.Controls.Add(this.cmbAnswerDel);
            this.tabDelete.Controls.Add(this.txtRetypeDel);
            this.tabDelete.Controls.Add(this.label14);
            this.tabDelete.Controls.Add(this.label15);
            this.tabDelete.Controls.Add(this.txtPasswordDel);
            this.tabDelete.Controls.Add(this.label16);
            this.tabDelete.Controls.Add(this.label17);
            this.tabDelete.Controls.Add(this.txtUsernameDel);
            this.tabDelete.Controls.Add(this.label12);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(415, 255);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete Account";
            this.tabDelete.UseVisualStyleBackColor = true;
            this.tabDelete.Click += new System.EventHandler(this.tabDelete_Click);
            // 
            // cmbAnswerEdit
            // 
            this.cmbAnswerEdit.FormattingEnabled = true;
            this.cmbAnswerEdit.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "white",
            "black",
            "orange",
            "purple"});
            this.cmbAnswerEdit.Location = new System.Drawing.Point(202, 166);
            this.cmbAnswerEdit.Name = "cmbAnswerEdit";
            this.cmbAnswerEdit.Size = new System.Drawing.Size(151, 21);
            this.cmbAnswerEdit.TabIndex = 33;
            // 
            // txtRetypeEdit
            // 
            this.txtRetypeEdit.Location = new System.Drawing.Point(202, 140);
            this.txtRetypeEdit.Name = "txtRetypeEdit";
            this.txtRetypeEdit.Size = new System.Drawing.Size(151, 20);
            this.txtRetypeEdit.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Edit Account:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Retype Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Username:";
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(202, 114);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(151, 20);
            this.txtPasswordEdit.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "What is your favorite color?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Password:";
            // 
            // txtUsernameEdit
            // 
            this.txtUsernameEdit.Location = new System.Drawing.Point(202, 88);
            this.txtUsernameEdit.Name = "txtUsernameEdit";
            this.txtUsernameEdit.Size = new System.Drawing.Size(151, 20);
            this.txtUsernameEdit.TabIndex = 32;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(176, 205);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "Delete Account:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(344, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "ID:";
            // 
            // txtIDDel
            // 
            this.txtIDDel.Location = new System.Drawing.Point(171, 62);
            this.txtIDDel.Name = "txtIDDel";
            this.txtIDDel.Size = new System.Drawing.Size(75, 20);
            this.txtIDDel.TabIndex = 50;
            // 
            // cmbAnswerDel
            // 
            this.cmbAnswerDel.Enabled = false;
            this.cmbAnswerDel.FormattingEnabled = true;
            this.cmbAnswerDel.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "white",
            "black",
            "orange",
            "purple"});
            this.cmbAnswerDel.Location = new System.Drawing.Point(171, 166);
            this.cmbAnswerDel.Name = "cmbAnswerDel";
            this.cmbAnswerDel.Size = new System.Drawing.Size(151, 21);
            this.cmbAnswerDel.TabIndex = 44;
            // 
            // txtRetypeDel
            // 
            this.txtRetypeDel.Location = new System.Drawing.Point(171, 140);
            this.txtRetypeDel.Name = "txtRetypeDel";
            this.txtRetypeDel.ReadOnly = true;
            this.txtRetypeDel.Size = new System.Drawing.Size(151, 20);
            this.txtRetypeDel.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Retype Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(97, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Username:";
            // 
            // txtPasswordDel
            // 
            this.txtPasswordDel.Location = new System.Drawing.Point(171, 114);
            this.txtPasswordDel.Name = "txtPasswordDel";
            this.txtPasswordDel.ReadOnly = true;
            this.txtPasswordDel.Size = new System.Drawing.Size(151, 20);
            this.txtPasswordDel.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "What is your favorite color?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Password:";
            // 
            // txtUsernameDel
            // 
            this.txtUsernameDel.Location = new System.Drawing.Point(171, 88);
            this.txtUsernameDel.Name = "txtUsernameDel";
            this.txtUsernameDel.ReadOnly = true;
            this.txtUsernameDel.Size = new System.Drawing.Size(151, 20);
            this.txtUsernameDel.TabIndex = 43;
            // 
            // btnIDDel
            // 
            this.btnIDDel.Location = new System.Drawing.Point(252, 62);
            this.btnIDDel.Name = "btnIDDel";
            this.btnIDDel.Size = new System.Drawing.Size(70, 23);
            this.btnIDDel.TabIndex = 51;
            this.btnIDDel.Text = "Enter";
            this.btnIDDel.UseVisualStyleBackColor = true;
            // 
            // btnIDEdit
            // 
            this.btnIDEdit.Location = new System.Drawing.Point(282, 62);
            this.btnIDEdit.Name = "btnIDEdit";
            this.btnIDEdit.Size = new System.Drawing.Size(70, 23);
            this.btnIDEdit.TabIndex = 54;
            this.btnIDEdit.Text = "Enter";
            this.btnIDEdit.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "ID:";
            // 
            // txtIDEdit
            // 
            this.txtIDEdit.Location = new System.Drawing.Point(201, 62);
            this.txtIDEdit.Name = "txtIDEdit";
            this.txtIDEdit.Size = new System.Drawing.Size(75, 20);
            this.txtIDEdit.TabIndex = 53;
            // 
            // frmCreateUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 343);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.tabAccounts.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAnswerAdd;
        private System.Windows.Forms.TextBox txtUsernameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetypeAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabAccounts;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.ComboBox cmbAnswerEdit;
        private System.Windows.Forms.TextBox txtRetypeEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsernameEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnIDEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDEdit;
        private System.Windows.Forms.Button btnIDDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDDel;
        private System.Windows.Forms.ComboBox cmbAnswerDel;
        private System.Windows.Forms.TextBox txtRetypeDel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPasswordDel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUsernameDel;
        private System.Windows.Forms.Button btnBack;
    }
}