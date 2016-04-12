using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
//this is a third party library (free to use) used to retrieve emails
using S22.Imap;

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
            //this returns the output
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
            //this retrieves the email subject.
            EmailSubject = DB.DataTable.Rows[0]["EmailSubject"].ToString();
        }

        public void UpdateEmails()
        {
            using (ImapClient client = new ImapClient("imap.gmail.com", 993, "dmuitech@gmail.com", "DeMonfortUniversity2015", AuthMethod.Auto, true))
            {
                int EmailAddressNo = 0;

                var uids = client.Search(SearchCondition.All());
                var messages = client.GetMessages(uids);

                foreach (var mail in messages)
                {
                    
                    //set up the data connection
                    clsDataConnection DB = new clsDataConnection();

                    DB.AddParameter("EmailContent", mail.Body);
                    DB.Execute("sproc_tblEmail_CheckIfExists");
                    //Int32 Result = Convert.ToInt32(DB.DataTable.Rows[0]["EmailNo"]);
                    if (DB.DataTable.Rows.Count == 0)
                    {
                        clsDataConnection DB5 = new clsDataConnection();
                        string from = Convert.ToString(mail.From);
                        //this uses substrings to extract the data we need from the email
                        string output = from.Substring(from.IndexOf("<") + 1, from.IndexOf(">") - from.IndexOf("<") - 1);
                        DB5.AddParameter("EmailAddress", output);
                        DB5.Execute("sproc_tblEmail_CheckEmailAddress");
                        if (DB.DataTable.Rows.Count == 0)
                        {
                            clsDataConnection DB3 = new clsDataConnection();
                            DB3.AddParameter("EmailAddress", output);
                            DB3.Execute("sproc_tblEmailAddress_InsertNewEmailAddress");
                        }
                        clsDataConnection DB4 = new clsDataConnection();
                        DB4.AddParameter("EmailAddress", output);
                        DB4.Execute("sproc_tblEmail_CheckEmailAddress");
                        EmailAddressNo = Convert.ToInt32(DB4.DataTable.Rows[0]["EmailAddressNo"]);

                        //new data connection for new parameters
                        clsDataConnection DB2 = new clsDataConnection();

                        var header = mail.Headers["Subject"];

                        string body = mail.Body;

                        DB2.AddParameter("EmailSubject", header);

                        DB2.AddParameter("EmailContent", body);

                        DB2.AddParameter("EmailAddressNo", EmailAddressNo);

                        DB2.Execute("sproc_tblEmail_InsertNewEmail");
                    }
                }
            }
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