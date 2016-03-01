using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class frmViewInbox : Form
    {
        public frmViewInbox()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void FrmViewInbox_Load(object sender, EventArgs e)
        {
            //create instance of the EmailCollection
            clsEmailCollection Emails = new clsEmailCollection();
            //set the data source to the list of emails in the collection class
            dataGridViewInbox.DataSource = Emails.AllEmails;


        }


        public void LoadEmailData()
        {
            //create instance of the EmailCollection
        }


        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
        }

        private void btnShowMoreEmails_Click(object sender, EventArgs e)
        {
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
        }
    }
}
