using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmOrderSummary Summary = new frmOrderSummary();
            //display the form
            Summary.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void lblAsterisk_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            //create instance of form
            frmOrderSummary Summary = new frmOrderSummary();
            //display the form
            Summary.Show();
        }

        private void ddlTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
