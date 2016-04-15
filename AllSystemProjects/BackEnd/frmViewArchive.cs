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
    public partial class frmViewArchive : Form
    {
        Int32 EmailAddressNo = 0;
        Int32 ArchiveNo = 0;
        Int32 EmailNo = 0;

        public frmViewArchive()
        {
            InitializeComponent();
        }

        private void frmViewArchive_Load(object sender, EventArgs e)
        {
            LoadEmails();
        }

        private void LoadEmails()
        {
            
            //create instance of the EmailCollection
            clsEmailCollection Emails = new clsEmailCollection();

            //set the data source to the list of emails in the collection class
            dataGridViewInbox.DataSource = FillGridArchive();

            //hide the emailAddressNo
            dataGridViewInbox.Columns["EmailAddressNo"].Visible = false;
            //hide the timestamp
            dataGridViewInbox.Columns["EmailTimeStamp"].Visible = false;
            //hide the archive no
            dataGridViewInbox.Columns["ArchiveNo"].Visible = false;

            dataGridViewInbox.Columns["EmailNo"].Visible = false;

            try
            {
                //this safeguards us incase somebody clicks the "view email" button before selecting a row
                Int32 SelectedIndex = 0;
                //this puts the emailno and emailaddressno ready for the parameters to frmViewEmail
                ArchiveNo = Convert.ToInt32(dataGridViewInbox["ArchiveNo", SelectedIndex].Value);

                EmailAddressNo = Convert.ToInt32(dataGridViewInbox["EmailAddressNo", SelectedIndex].Value);

                EmailNo = Convert.ToInt32(dataGridViewInbox["EmailNo", SelectedIndex].Value);
            }
            catch
            {
                MessageBox.Show("There are no Emails in the archive!");
                this.Close();
            }
        }

        private List<clsEmail> FillGridArchive()
        {
            //instance of the database connection class
            clsDataConnection DB = new clsDataConnection();
            List<clsEmail> allEmails = new List<clsEmail>();

            //exectue the stored procedure
            DB.Execute("sproc_tblArchive_SelectAll");
            //get the count
            Int32 RecordCount = DB.Count;
            //set up index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the email class
                clsEmail AEmail = new clsEmail();
                //create instance of clsEmailCollection class
                clsEmailCollection ACollectionEmail = new clsEmailCollection();
                //get the archive number
                AEmail.ArchiveNo = DB.DataTable.Rows[Index]["ArchiveNo"].ToString();
                //get the email subject
                AEmail.EmailSubject = DB.DataTable.Rows[Index]["EmailSubject"].ToString();
                //get the primary key
                AEmail.EmailNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailNo"]);
                //get the email Content
                AEmail.EmailContent = DB.DataTable.Rows[Index]["EmailContent"].ToString();
                //get the email address recieving
                AEmail.EmailAddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailAddressNo"]);
                //passess the EmailAddressNo to get the EmailAddress
                AEmail.EmailAddress = ACollectionEmail.GetEmailAddress(AEmail.EmailAddressNo);
                //add the Email to the private data
                allEmails.Add(AEmail);
                //add to the index
                Index++;
            }
            return allEmails;
        }

        private void btnViewEmail_Click(object sender, EventArgs e)
        {
            FrmViewEmail newViewEmail = new FrmViewEmail();
            newViewEmail.Show();
            newViewEmail.ViewArchiveEmail(EmailAddressNo, ArchiveNo);
        }

        private void btnRestoreEmail_Click(object sender, EventArgs e)
        {
            //try
            //{
                clsDataConnection NewConnection = new clsDataConnection();
                NewConnection.AddParameter("ArchiveNo", ArchiveNo);
                NewConnection.Execute("sproc_tblEmailAndArchive_PutArchiveBackInEmail");
                MessageBox.Show("Successful Transfer!");
                this.Refresh();
            //}
            //catch
            //{
            //    MessageBox.Show("Unfortunately there was an error. Please try again.");
            //}
        }

        private void dataGridViewInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 SelectedIndex = dataGridViewInbox.CurrentCell.RowIndex;
            EmailAddressNo = (Int32)dataGridViewInbox["EmailAddressNo", SelectedIndex].Value;
            EmailNo = (Int32)dataGridViewInbox["EmailNo", SelectedIndex].Value;
            ArchiveNo = Convert.ToInt32(dataGridViewInbox["ArchiveNo", SelectedIndex].Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
