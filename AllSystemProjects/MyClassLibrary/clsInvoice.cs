using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{

    public class clsInvoice
    {
        //private data member for the InvoiceNo property
        private Int32 invoiceNo;
        //private data member for Address
        private string address;
        //private data member for Amount
        private decimal amount;
        //private data member for FirstName
        private string firstName;
        //private data member for InvoiceName
        private string invoiceName;
        //private data member for InvoiceDate
        private DateTime invoiceDate;
        //private data member for LastName
        private string lastName;
        //public property for address
        public string Address
        {
            get
            {
                //return the private data
                return address;
            }
            set
            {
                //set the private data
                address = value;
            }
        }

        //public property for amount
        public decimal Amount
        {
            get
            {
                //return the private data
                return amount;
            }
            set
            {
                //set the private data
                amount = value;
            }
        }

        //public property for first name
        public string FirstName
        {
            get
            {
                //return the private data
                return firstName;
            }
            set
            {
                //set private data
                firstName = value;
            }
        }

        //public property for invoice date 
        public DateTime InvoiceDate
        {
            get
            {
                //return the private data
                return invoiceDate;
            }
            set
            {
                //set the private data
                invoiceDate = value;
            }
        }

        //public property for invoice name
        public string InvoiceName
        {
            get
            {
                //return the private data
                return invoiceName;
            }
            set
            {
                //set the private data
                invoiceName = value;
            }
        }

        //public property for the invoice number
        public int InvoiceNo
        {
            get
            {
                //return the private data
                return invoiceNo;
            }
            set
            {
                //set the value of the private data member
                invoiceNo = value;
            }
        }

        //public property for last name
        public string LastName
        {
            get
            {
                //return the private data
                return lastName;
            }
            set
            {
                //set the private data
                lastName = value;
            }
        }

        public bool Valid(string someAddress)
        {
            //boolean flag to indicate that all is OK
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

        public int Count()
        {
            clsDataConnection DB = new clsDataConnection();

            return DB.Count;
        }

        public bool Find(int InvoiceNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the invoice no to search for
            DB.AddParameter("@InvoiceNo", InvoiceNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblInvoice_FilterByInvoiceNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                invoiceNo = Convert.ToInt32(DB.DataTable.Rows[0]["InvoiceNo"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                amount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                firstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                invoiceName = Convert.ToString(DB.DataTable.Rows[0]["InvoiceName"]);
                invoiceDate = Convert.ToDateTime(DB.DataTable.Rows[0]["InvoiceDate"]);
                lastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                //return that everything worked OK
                return true;
            }

                //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public bool Valid(string FirstName, string LastName, string Address, string Amount, string InvoiceName, string InvoiceDate)
        {
            //create a Boolean variable to flag the error 
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the addess is blank
            if (Address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is greater than 50 characters 
            if (Address.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the InvoiceDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(InvoiceDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //is the amount blank
            if (Amount.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the amount is too long
            if (Amount.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the first name blank
            if (FirstName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the first name is too long
            if (FirstName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the invoice name blank
            if (InvoiceName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the invoice name is too long
            if (InvoiceName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the last name blank
            if (LastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is too long
            if (LastName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //return the value of ok
            return OK;
        }
    }
}



