using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> customerList = new List<clsCustomer>();
        //private data member thisCustomer  
        clsCustomer thisCustomer = new clsCustomer();

        //public property for CustomerList
        public List<clsCustomer> CustomerList 
         { 
             get
             {
              //return the private data
              return customerList; 
             }
             set  
             {
             //set the private data
             customerList = value;
             }

         }

        ////public property for count 
        //public Int32 Count
        //{
        //    get
        //    {
        //        //return the count of the list 
        //        return customerList.Count;
        //    }
        //    set
        //    {
        //        //
              
        //    }

        //}

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            // objects for the data conection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to procese
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current records 
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ACustomer.PhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ACustomer.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                customerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        //public property ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return thisCustomer;
            }
            set
            {
                //set the private data 
                thisCustomer = value;
            }
        }

        public int Add()
        {
            //add the new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@FirstName", thisCustomer.FirstName);
            DB.AddParameter("@LastName", thisCustomer.LastName);
            DB.AddParameter("@DateOfBirth", thisCustomer.DateOfBirth);
            DB.AddParameter("@EmailAddress", thisCustomer.EmailAddress);
            DB.AddParameter("@Gender", thisCustomer.Gender);
            DB.AddParameter("@PhoneNumber", thisCustomer.PhoneNumber);
            DB.AddParameter("@Address", thisCustomer.Address);
            DB.AddParameter("@City", thisCustomer.City);
            DB.AddParameter("@PostCode", thisCustomer.PostCode);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}