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

        //private data memebr for CustomerNo property
        private Int32 customerNo;

        private Decimal orderPrice;

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
            //craetew instance of db connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for Order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute sproc
            DB.Execute("sproc_tblServiceOrder_FilterByOrderNo");
            //if one record is found (there shoudl be either one or zero)
            if (DB.Count == 1)
            {
                //copy data from database to private data members
                orderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                service = Convert.ToString(DB.DataTable.Rows[0]["Service"]);
                orderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                orderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                customerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                //return that evrything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
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


        //public property for customer number
        public Int32 CustomerNo
        {
            get
            {
                //return private data
                return customerNo;
            }
            set
            {
                customerNo = value;
            }
        }

        public Decimal OrderPrice
        {
            get
            {
                //return private daat
                return orderPrice;
            }
            set
            {
                orderPrice = value;
            }
        }   
    }
}

