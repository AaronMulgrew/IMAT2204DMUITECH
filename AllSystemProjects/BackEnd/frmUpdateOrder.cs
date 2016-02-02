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
    public partial class frmUpdateOrder : Form
    {
        public frmUpdateOrder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }
        //button event for 'Update' button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if there is no order number entered in field...
            if (txtUpdate.Text == "")
            {
                //print error message
                lblMessage.Text = "Please enter an existing Service Order number.";
            }
                //otherwise
            else
            {
                //if everything is ok...
                //create instance of form
            frmEditUpdate Edit = new frmEditUpdate();
                //display the form
            Edit.Show();
            }           
        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {

        }

        private void txtUpdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
