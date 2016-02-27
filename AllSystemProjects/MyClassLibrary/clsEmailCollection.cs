using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{


    public class clsEmailCollection
    {


        //private data member for the allemails list
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
                //get the email name
                AEmail.EmailAddress = DB.DataTable.Rows[Index]["EmailAddress"].ToString();
                //get the primary key
                AEmail.EmailNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailNo"]);
                //add the Email to the private data
                allEmails.Add(AEmail);
                //add to the index
                Index++;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return all count properties
                return allEmails.Count;
            }
            set
            {
                //look at this later
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
    }
}
