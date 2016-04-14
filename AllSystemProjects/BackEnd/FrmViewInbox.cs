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
    public partial class frmViewInbox : Form
    {
        Int32 EmailAddressNo = 0;
        Int32 EmailNo = 0;
        public frmViewInbox()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            FrmViewEmail newViewEmail = new FrmViewEmail();
            newViewEmail.Show();
            newViewEmail.NewEmail(EmailAddressNo, EmailNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void FrmViewInbox_Load(object sender, EventArgs e)
        {
            //this protects us for any internet connection outages
            bool Result = CheckForInternetConnection();
            //this runs if the internet connection is all ok
            if (Result == true)
            {
                //create instance of the EmailCollection
                clsEmailCollection Emails = new clsEmailCollection();

                //this will add new emails from the server online
                Emails.UpdateEmails();

                LoadEmails();
            }
            else
            {
                //this runs if the internet connection is not good.
                this.Close();
                MessageBox.Show("You must have an active internet connection");
            }
        }


        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
        }

        private void LoadEmails()
        {
            //create instance of the EmailCollection
            clsEmailCollection Emails = new clsEmailCollection();

            //set the data source to the list of emails in the collection class
            dataGridViewInbox.DataSource = Emails.AllEmails;
            //hide the emailTimeStamp
            dataGridViewInbox.Columns["EmailTimeStamp"].Visible = false;
            //hide the Email Content, this is for the viewEmail page
            dataGridViewInbox.Columns["EmailContent"].Visible = false;
            //hide the emailNo
            dataGridViewInbox.Columns["EmailNo"].Visible = false;

            //hide the emailAddressNo
            dataGridViewInbox.Columns["EmailAddressNo"].Visible = false;

            //this safeguards us incase somebody clicks the "view email" button before selecting a row
            Int32 SelectedIndex = 0;
            //this puts the emailno and emailaddressno ready for the parameters to frmViewEmail
            EmailNo = (Int32)dataGridViewInbox["EmailNo", SelectedIndex].Value;
            EmailAddressNo = (Int32)dataGridViewInbox["EmailAddressNo", SelectedIndex].Value;
        }

        private void btnShowMoreEmails_Click(object sender, EventArgs e)
        {
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
        }

        private void dataGridViewInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 SelectedIndex = dataGridViewInbox.CurrentCell.RowIndex;
            EmailAddressNo = (Int32)dataGridViewInbox["EmailAddressNo", SelectedIndex].Value;
            EmailNo = (Int32)dataGridViewInbox["EmailNo", SelectedIndex].Value;
        }
    }
}
