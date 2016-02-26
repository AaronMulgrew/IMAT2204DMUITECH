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
    public partial class FrmViewEmail : Form
    {
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

        public void ShowEmail(Int32 SelectedIndex)
        {
            //these just put in some dummy data so that the system can be realistically tested
            if (SelectedIndex == 1)
            {
                txtBxFrom.Text = "Lara11@hotmail.co.uk";
                txtBxSubject.Text = "Refunds";
                txtBxContent.Text = "Hi I have recently paid for a repair from your business, do you do refunds?";
            }
            else if (SelectedIndex == 2)
            {
                txtBxFrom.Text = "Lara11@hotmail.co.uk";
                txtBxSubject.Text = "Enquiry";
                txtBxContent.Text = "Hi I am interested in a repair, when are you available?";
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            //this simply calls the replyemail function within the compose email screen
            FrmComposeEmail EmailClient = new FrmComposeEmail();
            EmailClient.ReplyEmail();
            EmailClient.Show();
        }
    }
}
