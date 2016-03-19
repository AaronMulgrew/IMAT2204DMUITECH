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
        Int32 EmailAddressNo;
        public frmViewInbox()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            FrmViewEmail newViewEmail = new FrmViewEmail();
            newViewEmail.Show();
            newViewEmail.NewEmail(EmailAddressNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void FrmViewInbox_Load(object sender, EventArgs e)
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
            Int32 SelectedIndex = 1;
            EmailAddressNo = (Int32)dataGridViewInbox["EmailAddressNo", SelectedIndex].Value;

        }


        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
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
        }
    }
}
