using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{


    public class clsEmailCollection
    {
        //contstructor
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
                clsEmail AnEmail = new clsEmail();
                //get the email name
                AnEmail.EmailAddress = DB.DataTable.Rows[Index]["EmailAddress"].ToString();
                //get the primary key
                AnEmail.EmailNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmailNo"]);
                //add to the index
                Index++;
            }
        }


        //private data member for the allemails list
        private List<clsEmail> allEmails = new List<clsEmail>();

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
