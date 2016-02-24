using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsInvoice
    {
        public string Address { get; set; }
        public int AddressNo { get; set; }

        public bool Valid(string someAddress)
        {
            //boolean flag to indicate that all is Ok
            Boolean OK = true;
            //if the name of the address is not blank
            if (someAddress == "")
            {
                //flag the error
                OK = false;
            }
            //if the name of the address is more than 50 characters
            if (someAddress.Length > 50)
            {
                //flag the error
                OK = false;
            }
            return OK;
        }

        public bool Vlid(string someAddress)
        {
            throw new NotImplementedException();
        }
    }
}