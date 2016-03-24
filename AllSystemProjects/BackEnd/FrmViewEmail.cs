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
            EmailClient.ReplyEmail(EmailAddress);
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
            txtBxSubject.Text = AllEmails.GetOneEmail(EmailNo);
            txtBxContent.Text = AllEmails.GetOneEmail(EmailNo);
            txtBxFrom.Text = EmailAddress;
        }
    }
}
