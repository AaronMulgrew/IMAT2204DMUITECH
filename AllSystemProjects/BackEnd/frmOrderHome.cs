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
    public partial class frmOrderHome : Form
    {
        public frmOrderHome()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmAddOrder AddOrder = new frmAddOrder();
            //display the form
            AddOrder.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmCancelOrder Cancel = new frmCancelOrder();
            //display the form
            Cancel.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmUpdateOrder Update = new frmUpdateOrder();
            //display the form
            Update.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmSearch Search = new frmSearch();
            //display the form
            Search.Show();
        }

        private void frmOrderHome_Load(object sender, EventArgs e)
        {

        }
    }
}
