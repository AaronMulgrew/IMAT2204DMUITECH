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

namespace BackEnd
{
    public partial class frmViewArchive : Form
    {
        public frmViewArchive()
        {
            InitializeComponent();
        }

        private void frmViewArchive_Load(object sender, EventArgs e)
        {
            LoadEmails();
        }

        private void LoadEmails()
        {
            
            //create instance of the EmailCollection
            clsEmailCollection Emails = new clsEmailCollection();

            //set the data source to the list of emails in the collection class
            dataGridViewInbox.DataSource = Emails.AllEmails;

            //hide the emailAddressNo
            dataGridViewInbox.Columns["EmailAddressNo"].Visible = false;

            //this safeguards us incase somebody clicks the "view email" button before selecting a row
            Int32 SelectedIndex = 0;
            //this puts the emailno and emailaddressno ready for the parameters to frmViewEmail
            Int32 ArchiveNo = (Int32)dataGridViewInbox["ArchiveNo", SelectedIndex].Value;
            Int32 EmailAddressNo = (Int32)dataGridViewInbox["EmailAddressNo", SelectedIndex].Value;
        }

    }
}
