using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;
using BackOffice;


namespace BackEnd
{
    public partial class frmContactList : Form
    {
        public frmContactList()
        {
            InitializeComponent();
        }

        private void frmContactList_Load(object sender, EventArgs e)
        {
            DisplayEmails();
        }

        void DisplayEmails()
        {
            //create instance of the EmailCollection
            clsEmailAddressCollection Emails = new clsEmailAddressCollection();
            //set the data source to the list of emails in the collection class
            lstBxContacts.DataSource = Emails.AllEmailAddresses;
            //set the data field to display
            lstBxContacts.DisplayMember = "EmailAddress".ToString();
            //set the name of the primary key
            lstBxContacts.ValueMember = "EmailAddressNo";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmViewInbox form = new frmViewInbox();
            form.Show();
        }
    }
}