namespace northwind
{
    partial class frmForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.grpChange = new System.Windows.Forms.GroupBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.grpChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORGOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "What is your favorite color?";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(184, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(198, 178);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(87, 27);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "white",
            "black",
            "orange",
            "purple"});
            this.cmbAnswer.Location = new System.Drawing.Point(138, 151);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(202, 21);
            this.cmbAnswer.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(158, 13);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(151, 20);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Password:";
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(158, 39);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(151, 20);
            this.txtRetype.TabIndex = 11;
            this.txtRetype.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Retype Password:";
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(158, 65);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(87, 27);
            this.btnSavePassword.TabIndex = 12;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // grpChange
            // 
            this.grpChange.Controls.Add(this.btnSavePassword);
            this.grpChange.Controls.Add(this.label5);
            this.grpChange.Controls.Add(this.txtRetype);
            this.grpChange.Controls.Add(this.txtNewPassword);
            this.grpChange.Controls.Add(this.label6);
            this.grpChange.Enabled = false;
            this.grpChange.Location = new System.Drawing.Point(40, 211);
            this.grpChange.Name = "grpChange";
            this.grpChange.Size = new System.Drawing.Size(387, 94);
            this.grpChange.TabIndex = 13;
            this.grpChange.TabStop = false;
            this.grpChange.Text = "Change Password";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(223, 308);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(39, 13);
            this.lblCancel.TabIndex = 14;
            this.lblCancel.Text = "cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 332);
            this.ControlBox = false;
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.grpChange);
            this.Controls.Add(this.cmbAnswer);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassword";
            this.grpChange.ResumeLayout(false);
            this.grpChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.GroupBox grpChange;
        private System.Windows.Forms.Label lblCancel;
    }
}