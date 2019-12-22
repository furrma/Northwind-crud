using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace northwind
{
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void frmDateTime_Load(object sender, EventArgs e)
        {
            
        }

        private void lnkDateTime_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("timedate.cpl");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lnkDateTime.Text = DateTime.Now.Date.ToString("yyyy - MM - dd") + DateTime.Now.ToString("  //  h:mm:ss tt");
        }
    }
}
