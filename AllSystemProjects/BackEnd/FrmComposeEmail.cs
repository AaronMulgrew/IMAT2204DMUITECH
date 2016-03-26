using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BackEnd
{
    public partial class FrmComposeEmail : Form
    {
        public FrmComposeEmail()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// this is if the user has navigated ot this page via the saved search page
        /// </summary>

        public void GroupEmail()
        {
            txtBxTo.Text = "SJAS@hotmail.com, lara11@hotmail.com, locals@hotmail.co.uk";
            lblMainTitle.Text = "New Group Email";
        }

        /// <summary>
        /// this is if the user has navigated to this page via the reply email option within the email client
        /// this is just some dummy data that will be replaced in the full system
        /// </summary>

        public void ReplyEmail(string EmailAddress)
        {
            //this loads the email address automatically from the reply email
            txtBxTo.Text = EmailAddress;
        }

        private void FrmComposeEmail_Load(object sender, EventArgs e)
        {
        }

        public void NewEmail()
        {
            //this runs if user clicks compose individual email on the email Client
            lblMainTitle.Text = "New Email";
        }

        public void AcceptEmails(List<string>EmailAddresses)
        {
            //this accepts the generic list and converts it to string
            string EmailAddressList = string.Join(",", EmailAddresses.ToArray());
            txtBxTo.Text = EmailAddressList;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ///these set the bool values to false
            bool isValidTo = false;
            bool isValidSubject = false;
            bool isValidMainBody = false;
            bool isValidToAt = false;
            //this is some simple validation, that will be replaced by the IsValid() function in the full system
            //this is if the text box to doesn't contain an @ symbol
            if (!txtBxTo.Text.Contains("@"))
            {
                isValidToAt = false;
                lblError.Text = "Please write a valid email address";
            }
            else
            {
                isValidToAt = true;
            }
            //this is if the text box to is null or white space
            if (string.IsNullOrWhiteSpace(txtBxTo.Text))
            {
                lblError.Text = "Please add recipient in the To textbox";
                isValidTo = false;
            }
            else
            {
                isValidTo = true;
            }


            //this is if the text box subject is null or white space
            if (string.IsNullOrWhiteSpace(txtBxSubject.Text))
            {
                lblError.Text = "Please add a subject to the textbox";
                isValidSubject = false;
            }
            else
            {
                isValidSubject = true;
            }


            //this is if the main body is null or white space
            if (string.IsNullOrWhiteSpace(txtBxMainBody.Text))
            {
                lblError.Text = "Please write something within the main body";
                isValidMainBody = false;
            }
            else
            {
                isValidMainBody = true;
            }

            //this is if all the counters are true
            if (isValidTo == true && isValidSubject == true && isValidMainBody == true && isValidToAt == true)
            {
                //this is a dummy message, will be replaced by real code
                //after the Smoke and Mirrors prototype


                ///Email Address = dmuitech@gmail.com
                ///Password = DeMonfortUniversity2015
                ///

                string Username = "dmuitech";
                string Password = "DeMonfortUniversity2015";

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("dmuitech@gmail.com");
                    mail.To.Add(txtBxTo.Text);
                    mail.Subject = txtBxSubject.Text;
                    mail.Body = txtBxMainBody.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Username, Password);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    //show the messagebox
                    MessageBox.Show("Email Successfully Sent!");
                    //this closes the current form
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void buttonAttachments_Click(object sender, EventArgs e)
        {
            //this initalises the filepath var
            string filepath = "";

            //this opens a new file browser
            OpenFileDialog filebrowserDialog = new OpenFileDialog();
            //this checks to see if the user has clicked ok
            if (filebrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = filebrowserDialog.FileName;
            }
            //this displays the attachmentpath in the path name
            this.txtBxAttachmentPath.Text = filepath;
        }

        private void btnContactList_Click(object sender, EventArgs e)
        {
            //this sets up the formcontactlistclass
            frmContactList newcontactlist = new frmContactList();
            //shows the new contact list form
            newcontactlist.Show();
            //closes the current form.
            this.Close();
        }
    }
}
