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
    public partial class frmCancelOrder : Form
    {
        public frmCancelOrder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if there is no order number entered in field...
            if (txtCancel.Text == "")
            {
                //print error message
                lblMessage.Text = "Please enter an existing Service Order number.";
            }
                //otherwise
            else
            {
                //print confirmation message
                lblMessage.Text = "The Service Order has been cancelled";
            }
        }

        private void frmCancelOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
