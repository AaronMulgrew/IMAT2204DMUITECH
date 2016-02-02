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
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmConfirmation Confirmation = new frmConfirmation();
            //display the form
            Confirmation.Show();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {

        }
    }
}
