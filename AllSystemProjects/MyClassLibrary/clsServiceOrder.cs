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

        //private data member for OrderDate property
        private DateTime orderDate;

        //private data memebr for Service property
        private string service;

        

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
        

        //public proeprtyy for Order Date
        public DateTime OrderDate
        {
            get
            {
                //return private data
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        //public property for service
        public string Service
        {
            get
            {
                //return private data
                return service;
            }
            set
            {
                service = value;
            }
        }
        
    }
}

