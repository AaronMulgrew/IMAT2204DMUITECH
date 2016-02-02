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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if there is no order number entered in field...
            if (txtSearch.Text == "")
            {
                //print error message
                lblMessage.Text = "Please enter an existing Service Order number.";
            }
                //otherwise
            else
            {
                //create instance of the form
                frmSearchResults Results = new frmSearchResults();
                //display the form
                Results.Show();
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
