using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsEmailCollection
    {
        //private data member for the allemails list
        private List<clsEmail> allEmails;

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
                return allEmails;
            }

            set
            {
                allEmails = value;
            }
        }
    }
}
