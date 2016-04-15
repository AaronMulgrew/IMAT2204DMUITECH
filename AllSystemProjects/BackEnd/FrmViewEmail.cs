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
    public partial class FrmViewEmail : Form
    {
        string EmailAddress;
        string EmailSubject;
        string EmailContent;

        public FrmViewEmail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void FrmViewEmail_Load(object sender, EventArgs e)
        {
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            //this simply calls the replyemail function within the compose email screen
            FrmComposeEmail EmailClient = new FrmComposeEmail();
            EmailClient.ReplyEmail(EmailAddress, EmailSubject, EmailContent);
            EmailClient.Show();
        }

        //this will be the function that shows the new email and it accepts the emailno selected in 
        //the datagridview
        public void NewEmail(int EmailAddressNo, int EmailNo)
        {
            //txtBxFrom.Text = Convert.ToString(EmailAddressNo);
            clsEmail OneEmail = new clsEmail();
            clsEmailCollection AllEmails = new clsEmailCollection();
            EmailAddress = AllEmails.GetEmailAddress(EmailAddressNo);
            bool IsArchive = false;
            AllEmails.GetOneEmail(EmailNo, IsArchive, out EmailSubject, out EmailContent);
            txtBxSubject.Text = EmailSubject;
            txtBxContent.Text = EmailContent;
            txtBxFrom.Text = EmailAddress;
        }

        public void ViewArchiveEmail(int EmailAddressNo, int ArchiveNo)
        {
            clsEmail OneEmail = new clsEmail();
            clsEmailCollection AllEmails = new clsEmailCollection();
            EmailAddress = AllEmails.GetEmailAddress(EmailAddressNo);
            bool IsArchive = true;
            AllEmails.GetOneEmail(ArchiveNo, IsArchive, out EmailSubject, out EmailContent);
            txtBxSubject.Text = EmailSubject;
            txtBxContent.Text = EmailContent;
            txtBxFrom.Text = EmailAddress;
        }

    }
}
