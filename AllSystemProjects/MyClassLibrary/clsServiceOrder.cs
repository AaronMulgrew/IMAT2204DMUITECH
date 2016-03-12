using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsServiceOrder
    {
        //private data member for OrderNo property
        private Int32 orderNo;

        private DateTime orderDate;

        public string Service { get; set; }

        public int OrderNo
        {
            get
            {
                //return privaste data
                return orderNo;
            }
            set
            {
                //set value of private data memeber
                orderNo = value;
            }
        }

        public bool Valid(string SomeService)
        {
            //we want to check whether something has actually been  entered
            //boolean variable indidcates that all is good
            //Boolean OK = true;
            //if name of Service Type is not blank
            if (SomeService == "")
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
            //set private data member to test data value
            orderNo = 21;
            //always return true;
            return true;
        }


        public DateTime OrderDate
        {
            get
            {
                //return privaste data
                return orderDate;
            }
            set
            {
                //set value of private data memeber
                orderDate = value;
            }
        }
    }
}

