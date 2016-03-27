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
using AE.Net.Mail;

namespace BackEnd
{
    public partial class frmUpdateEmailTest : Form
    {
        public frmUpdateEmailTest()
        {
            InitializeComponent();
        }

        private void frmUpdateEmailTest_Load(object sender, EventArgs e)
        {
            // Connect to the IMAP server. The 'true' parameter uses SSL
            ImapClient ic = new ImapClient("imap.gmail.com", "dmuitech@gmail.com", "DeMonfortUniversity2015", AuthMethods.Login, 993, true);
            // Select a mailbox.
            ic.SelectMailbox("INBOX");
            // Get 11 messages
            // MailMessage
            AE.Net.Mail.MailMessage[] mm = ic.GetMessages(0, 2);
            foreach (MailMessage m in mm)
            {
                textBox1.Text = Convert.ToString(m.RawHeaders);
            }
        }
    }
}
