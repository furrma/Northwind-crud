namespace northwind
{
    partial class frmCategories
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
            this.txtDescAdd = new System.Windows.Forms.TextBox();
            this.txtCatNameAdd = new System.Windows.Forms.TextBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtCatIDEdit = new System.Windows.Forms.TextBox();
            this.txtDescEdit = new System.Windows.Forms.TextBox();
            this.txtCatNameEdit = new System.Windows.Forms.TextBox();
            this.btnCatEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtCatIDDel = new System.Windows.Forms.TextBox();
            this.btnCatDel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnCatSearch = new System.Windows.Forms.Button();
            this.txtCatIDSearch = new System.Windows.Forms.TextBox();
            this.txtDescSearch = new System.Windows.Forms.TextBox();
            this.txtCatNameSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnBackMainCat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.dgvCategories);
            this.panel1.Location = new System.Drawing.Point(9, 8);
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
            this.tabAdd.Controls.Add(this.txtDescAdd);
            this.tabAdd.Controls.Add(this.txtCatNameAdd);
            this.tabAdd.Controls.Add(this.btnCatAdd);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(340, 331);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtDescAdd
            // 
            this.txtDescAdd.Location = new System.Drawing.Point(118, 118);
            this.txtDescAdd.Name = "txtDescAdd";
            this.txtDescAdd.Size = new System.Drawing.Size(198, 20);
            this.txtDescAdd.TabIndex = 15;
            // 
            // txtCatNameAdd
            // 
            this.txtCatNameAdd.Location = new System.Drawing.Point(118, 94);
            this.txtCatNameAdd.Name = "txtCatNameAdd";
            this.txtCatNameAdd.Size = new System.Drawing.Size(198, 20);
            this.txtCatNameAdd.TabIndex = 14;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(129, 162);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCatAdd.TabIndex = 12;
            this.btnCatAdd.Text = "Add";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txtCatIDEdit);
            this.tabEdit.Controls.Add(this.txtDescEdit);
            this.tabEdit.Controls.Add(this.txtCatNameEdit);
            this.tabEdit.Controls.Add(this.btnCatEdit);
            this.tabEdit.Controls.Add(this.label6);
            this.tabEdit.Controls.Add(this.label7);
            this.tabEdit.Controls.Add(this.label8);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(340, 331);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txtCatIDEdit
            // 
            this.txtCatIDEdit.Location = new System.Drawing.Point(123, 96);
            this.txtCatIDEdit.Name = "txtCatIDEdit";
            this.txtCatIDEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDEdit.TabIndex = 36;
            // 
            // txtDescEdit
            // 
            this.txtDescEdit.Location = new System.Drawing.Point(123, 143);
            this.txtDescEdit.Name = "txtDescEdit";
            this.txtDescEdit.Size = new System.Drawing.Size(198, 20);
            this.txtDescEdit.TabIndex = 32;
            // 
            // txtCatNameEdit
            // 
            this.txtCatNameEdit.Location = new System.Drawing.Point(123, 119);
            this.txtCatNameEdit.Name = "txtCatNameEdit";
            this.txtCatNameEdit.Size = new System.Drawing.Size(198, 20);
            this.txtCatNameEdit.TabIndex = 31;
            // 
            // btnCatEdit
            // 
            this.btnCatEdit.Location = new System.Drawing.Point(148, 194);
            this.btnCatEdit.Name = "btnCatEdit";
            this.btnCatEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCatEdit.TabIndex = 30;
            this.btnCatEdit.Text = "Edit";
            this.btnCatEdit.UseVisualStyleBackColor = true;
            this.btnCatEdit.Click += new System.EventHandler(this.btnCatEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Category ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Category Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Description";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtCatIDDel);
            this.tabDelete.Controls.Add(this.btnCatDel);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(340, 331);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtCatIDDel
            // 
            this.txtCatIDDel.Location = new System.Drawing.Point(125, 117);
            this.txtCatIDDel.Name = "txtCatIDDel";
            this.txtCatIDDel.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDDel.TabIndex = 33;
            // 
            // btnCatDel
            // 
            this.btnCatDel.Location = new System.Drawing.Point(125, 156);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(75, 23);
            this.btnCatDel.TabIndex = 30;
            this.btnCatDel.Text = "Delete";
            this.btnCatDel.UseVisualStyleBackColor = true;
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Category ID:";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnCatSearch);
            this.tabSearch.Controls.Add(this.txtCatIDSearch);
            this.tabSearch.Controls.Add(this.txtDescSearch);
            this.tabSearch.Controls.Add(this.txtCatNameSearch);
            this.tabSearch.Controls.Add(this.label17);
            this.tabSearch.Controls.Add(this.label18);
            this.tabSearch.Controls.Add(this.label19);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(340, 331);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // btnCatSearch
            // 
            this.btnCatSearch.Location = new System.Drawing.Point(134, 207);
            this.btnCatSearch.Name = "btnCatSearch";
            this.btnCatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCatSearch.TabIndex = 35;
            this.btnCatSearch.Text = "Search";
            this.btnCatSearch.UseVisualStyleBackColor = true;
            this.btnCatSearch.Click += new System.EventHandler(this.btnCatSearch_Click);
            // 
            // txtCatIDSearch
            // 
            this.txtCatIDSearch.Location = new System.Drawing.Point(122, 112);
            this.txtCatIDSearch.Name = "txtCatIDSearch";
            this.txtCatIDSearch.Size = new System.Drawing.Size(198, 20);
            this.txtCatIDSearch.TabIndex = 33;
            // 
            // txtDescSearch
            // 
            this.txtDescSearch.Location = new System.Drawing.Point(122, 162);
            this.txtDescSearch.Name = "txtDescSearch";
            this.txtDescSearch.ReadOnly = true;
            this.txtDescSearch.Size = new System.Drawing.Size(198, 20);
            this.txtDescSearch.TabIndex = 32;
            // 
            // txtCatNameSearch
            // 
            this.txtCatNameSearch.Location = new System.Drawing.Point(122, 138);
            this.txtCatNameSearch.Name = "txtCatNameSearch";
            this.txtCatNameSearch.ReadOnly = true;
            this.txtCatNameSearch.Size = new System.Drawing.Size(198, 20);
            this.txtCatNameSearch.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Category ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Category Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Description";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(353, 3);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(410, 354);
            this.dgvCategories.TabIndex = 2;
            // 
            // btnBackMainCat
            // 
            this.btnBackMainCat.Location = new System.Drawing.Point(698, 374);
            this.btnBackMainCat.Name = "btnBackMainCat";
            this.btnBackMainCat.Size = new System.Drawing.Size(75, 23);
            this.btnBackMainCat.TabIndex = 13;
            this.btnBackMainCat.Text = "Back";
            this.btnBackMainCat.UseVisualStyleBackColor = true;
            this.btnBackMainCat.Click += new System.EventHandler(this.btnBackMainCat_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(785, 409);
            this.Controls.Add(this.btnBackMainCat);
            this.Controls.Add(this.panel1);
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtDescAdd;
        private System.Windows.Forms.TextBox txtCatNameAdd;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtCatIDEdit;
        private System.Windows.Forms.TextBox txtDescEdit;
        private System.Windows.Forms.TextBox txtCatNameEdit;
        private System.Windows.Forms.Button btnCatEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCatIDDel;
        private System.Windows.Forms.Button btnCatDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCatIDSearch;
        private System.Windows.Forms.TextBox txtDescSearch;
        private System.Windows.Forms.TextBox txtCatNameSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBackMainCat;
        private System.Windows.Forms.Button btnCatSearch;
    }
}