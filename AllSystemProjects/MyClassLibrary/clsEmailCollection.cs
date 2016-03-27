using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
//this is a 3rd party library to get IMAP messages in
using AE.Net.Mail;

namespace MyClassLibrary
{
    public class clsEmailCollection
    {

        //private data member for the allemailAddresses list
        private List<clsEmail> allEmails = new List<clsEmail>();

        //public constructor
        public clsEmailCollection()
        {
            //instance of the database connection class
            clsDataConnection DB = new clsDataConnection();
            //exectue the stored procedure
            DB.Execute("sproc_tblEmail_SelectAll");
            //get the count
            Int32 RecordCount = DB.Count;
            //set up index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the email class
                clsEmail AEmail = new clsEmail();
                //get the email subject
                AEmail.EmailSubject = DB.DataTable.Rows[Index]["EmailSubject"].ToString();
                //get the primary key
                AEmail.EmailNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailNo"]);
                //get the email Content
                AEmail.EmailContent = DB.DataTable.Rows[Index]["EmailContent"].ToString();
                //get the email address recieving
                AEmail.EmailAddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailAddressNo"]);
                //passess the EmailAddressNo to get the EmailAddress
                AEmail.EmailAddress = GetEmailAddress(AEmail.EmailAddressNo);
                //add the Email to the private data
                allEmails.Add(AEmail);
                //add to the index
                Index++;
            }
        }

        public string GetEmailAddress(Int32 EmailAddressNo)
        {
            //instance of the database connection class
            clsDataConnection DB = new clsDataConnection();
            //this adds the parameter EmailAddressNo
            DB.AddParameter("EmailNo", EmailAddressNo);
            //this executes the stored procedure for the email address
            DB.Execute("sproc_tblEmailAddress_GetEmailAddress");
            //this retrieves one email address from the Table "tblEmailAddress", index only needs to be 0
            string EmailAddress = DB.DataTable.Rows[0]["EmailAddress"].ToString();
            return EmailAddress;
        }

        public void GetOneEmail(Int32 EmailNo, out string EmailSubject, out string EmailContent)
        {
            //instance of the database connection class
            clsDataConnection DB = new clsDataConnection();
            //this adds the parameter EmailNo
            DB.AddParameter("EmailNo", EmailNo);
            //this executes the stored procedure for the email address
            DB.Execute("sproc_tblEmail_GetEmail");
            //this retrieves one email content and subject from the Table "tblEmailAddress", index only needs to be 0
            EmailContent = DB.DataTable.Rows[0]["EmailContent"].ToString();
            //FIX THISSSSSSISISISISSISSSISIISIS
            EmailSubject = DB.DataTable.Rows[0]["EmailSubject"].ToString();
        }

        public Array UpdateEmails()
        {
            // Connect to the IMAP server. The 'true' parameter uses SSL
            ImapClient ic = new ImapClient("imap.gmail.com", "dmuitech@gmail.com", "DeMonfortUniversity2015", AuthMethods.Login, 993, true);
            // Select a mailbox.
            ic.SelectMailbox("INBOX");
            // Get 11 messages
            // MailMessage
            AE.Net.Mail.MailMessage[] mm = ic.GetMessages(0, 10);
            return mm;
        }


        public List<clsEmail> AllEmails
        {
            get
            {
                //return the private data member
                return allEmails;
            }

            set
            {
                //assign the incoming value to the private data member
                allEmails = value;
            }
        }

        public int CountEmails
        {
            get
            {
                return AllEmails.Count;
            }
            set
            {

            }
        }

    }




    public class clsEmailAddressCollection
    {

        //private data member for the allemailAddresses list
        private List<clsEmail> allEmailAddresses = new List<clsEmail>();

        ////public constructor
        public clsEmailAddressCollection()
        {
            //instance of the database connection class
            clsDataConnection DB = new clsDataConnection();
            //exectue the stored procedure
            DB.Execute("sproc_tblEmailAddress_SelectAll");
            //get the count
            Int32 RecordCount = DB.Count;
            //set up index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the email class
                clsEmail AEmailAddress = new clsEmail();
                //get the email Address
                AEmailAddress.EmailAddress = DB.DataTable.Rows[Index]["EmailAddress"].ToString();
                //get the primary key
                AEmailAddress.EmailAddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailAddressNo"]);
                //add the Email to the private data
                allEmailAddresses.Add(AEmailAddress);
                //add to the index
                Index++;
            }
        }

        //public property for count
        public int CountEmailAddresses
        {
            get
            {
                //return all count properties
                return allEmailAddresses.Count;
            }
            set
            {
                //look at this later
            }
        }

        public List<clsEmail> AllEmailAddresses
        {
            get
            {
                //return the private data member
                return allEmailAddresses;
            }

            set
            {
                //assign the incoming value to the private data member
                allEmailAddresses = value;
            }
        }



    }
}