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
    public partial class frmExistingCustomer : Form
    {
        public frmExistingCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }
        //button event for 'Continue' button
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmOrderSummary Summary = new frmOrderSummary();
            //display the form
            Summary.Show();
        }

        private void frmExistingCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
