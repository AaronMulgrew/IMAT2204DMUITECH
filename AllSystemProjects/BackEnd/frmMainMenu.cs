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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        
        private void btnServiceOrders_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmOrderHome OrderHome = new frmOrderHome();
            //display the form
            OrderHome.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmHelp Help = new frmHelp();
            //display the form
            Help.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmStaff Staff = new frmStaff();
            //display the form
            Staff.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }
    }
}
