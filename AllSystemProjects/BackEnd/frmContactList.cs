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
using BackEnd;


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
            //a bit of linq to convert the lstbxcontacts to a generic list
            ///FIXTHISBITTTTTT
            List<string> EmailAddresses = lstBxContacts.SelectedItems.OfType<string>().ToList();

            //instantiation of the frmcomposemail form
            FrmComposeEmail SendAddresses = new FrmComposeEmail();
            SendAddresses.AcceptEmails(EmailAddresses);
            //this shows the email compostion page
            SendAddresses.Show();

            this.Close();
        }

        private void lstBxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}