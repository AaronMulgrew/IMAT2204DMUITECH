using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsServiceOrder
    {
        public string Service { get; set; }

        public int OrderNo { get; set; }

        public bool Valid(string SomeService)
        {
            //we want to check whether something has actually been  entered
            //boolean variable indidcates that all is good
            //Boolean OK = true;
            //if name of Service Type is not blank
            if(SomeService == "")
            {
                //show error
                 return false;
            }
                //if name of service is more than 20 characters
            if (SomeService.Length > 20)
            {
                //show error
               return false;
            }
            return true;
        }

        public bool ValidNo(string SomeNumber)
        {
            return true;
        }

        public bool Find(int OrderNo)
        {
            //always return true;
            return true;
        }
    }
}
