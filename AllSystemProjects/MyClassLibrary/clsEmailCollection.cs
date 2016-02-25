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
            //instance of the email class
            clsEmail AnEmail = new clsEmail();
            //set the email address
            AnEmail.EmailAddress = "mulgrewaaron1@gmail.com";
            //add the email to the private list
            allEmails.Add(AnEmail);
            //re-initialise the AnEmail object to accept a new item
            AnEmail = new clsEmail();
            //set another email address
            AnEmail.EmailAddress = "azz7008@gmail.com";
            //add the second email address to the private list
            allEmails.Add(AnEmail);
            //private list now contains 2 emails
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
