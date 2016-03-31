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
using S22.Imap;
using System.Net.Mail;

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
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, "dmuitech@gmail.com", "DeMonfortUniversity2015", AuthMethod.Auto, true))
                {
                    var uids = client.Search(SearchCondition.All());
                    var messages = client.GetMessages(uids);

                    foreach (var mail in messages)
                    {
                        var header = mail.Headers["Subject"];
                        string body = mail.Body;
                        textBox1.Text = (header.ToString()); 
                        textBox1.Text = body;
                    }
                }
            }
        }
    }
}
