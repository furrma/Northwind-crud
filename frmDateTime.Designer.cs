namespace northwind
{
    partial class frmDateTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.lnkDateTime = new System.Windows.Forms.LinkLabel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "It is now";
            // 
            // lnkDateTime
            // 
            this.lnkDateTime.AutoSize = true;
            this.lnkDateTime.Location = new System.Drawing.Point(159, 54);
            this.lnkDateTime.Name = "lnkDateTime";
            this.lnkDateTime.Size = new System.Drawing.Size(53, 13);
            this.lnkDateTime.TabIndex = 1;
            this.lnkDateTime.TabStop = true;
            this.lnkDateTime.Text = "DateTime";
            this.lnkDateTime.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDateTime_LinkClicked);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(175, 86);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDateTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 135);
            this.ControlBox = false;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lnkDateTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDateTime";
            this.Load += new System.EventHandler(this.frmDateTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkDateTime;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Timer timer1;
    }
}