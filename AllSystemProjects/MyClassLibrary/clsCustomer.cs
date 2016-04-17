using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer ID
        private Int32 customerID;
        private string address;
        private string city;
        private string postCode;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string gender;
        private Int32 phoneNumber;
        private DateTime dateOfBirth;

        public string PostCode
        {
            get
            {
                //return the private data
                return postCode;
            }

            set
            {
                //set the value of the private data member
                postCode = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return dateOfBirth;
            }

            set
            {
                //set the value of the private data member
                dateOfBirth = value;
            }
        }

        public string Address
        {
            get
            {
                //return the private data
                return address;
            }

            set
            {
                //set the value of the private data member
                address = value;
            }
        }

        public string City
        {
            get
            {
                //return the private data
                return city;
            }

            set
            {
                //set the value of the private data member
                city = value;
            }
        }

        public int CustomerID
        {
            get
            {
                //return the private data
                return customerID;
            }

            set
            {
                //set the value of the private data member
                customerID = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                //return the private data
                return emailAddress;
            }

            set
            {
                //set the value of the private data member
                emailAddress = value;
            }
        }

        public string Gender
        {
            get
            {
                //return the private data
                return gender;
            }

            set
            {
                //set the value of the private data member
                gender = value;
            }
        }

        public string FirstName
        {
            get
            {
                //return the private data
                return firstName;
            }

            set
            {
                //set the value of the private data member
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return lastName;
            }

            set
            {
                //set the value of the private data member
                lastName = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                //return the private data
                return phoneNumber;
            }

            set
            {
                //set the value of the private data member
                phoneNumber = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance od the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data member to the test data value
                customerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                firstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                lastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                emailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                gender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                phoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                city = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                postCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                //always return true
                return true;
            }
            else
            {
                //if no record was found
                return false;
            }

        }



        public bool ValidFirstName(string SomeFirstName)
        {
            Boolean OK = true;

            if (SomeFirstName == "")
            {
                OK = false;
            }

            if (SomeFirstName.Length > 20)
            {
                OK = false;
            }

            return OK;
        }

        public bool ValidLastName(string SomeLastName)
        {
            Boolean OK = true;

            if (SomeLastName == "")
            {
                OK = false;
            }

            if (SomeLastName.Length > 20)
            {
                OK = false;
            }

            return OK;

        }

        public bool ValidGender(string SomeGender)
        {
            Boolean OK = true;

            if (SomeGender.Length < 4)
            {
                OK = false;
            }

            if (SomeGender.Length > 6)
            {
                OK = false;
            }

            if (SomeGender.Length == 5)
            {
                OK = false;
            }
            return OK;

        }


        public bool ValidPostCode(string SomePostCode)
        {
            Boolean OK = true;

            if (SomePostCode.Length < 7)
            {
                OK = false;
            }

            if (SomePostCode.Length > 8)
            {
                OK = false;
            }
            return OK;
        }

        public bool ValidAddress(string SomeAddress)
        {
            Boolean OK = true;

            if (SomeAddress.Length <= 10)
            {
                OK = false;
            }

            if (SomeAddress.Length >= 21)
            {
                OK = false;
            }
            return OK;
        }

        public bool ValidCity(string SomeCity)
        {
            Boolean OK = true;

            if (SomeCity == "")
            {
                OK = false;
            }

            if (SomeCity.Length >= 93)
            {
                OK = false;
            }

            return OK;

        }

        public bool ValidEmail(string SomeEmail)
        {
            Boolean OK = true;

            if (SomeEmail.Length <= 13)
            {
                OK = false;
            }

            if (SomeEmail.Length > 70)
            {
                OK = false;
            }

            return OK;

        }

        public bool ValidCustomerPhoneNumber(string SomePhoneNumber)
        {
            Boolean OK = true;

            if (SomePhoneNumber.Length < 10)
            {
                OK = false;
            }

            if (SomePhoneNumber.Length > 11)
            {
                OK = false;
            }

            return OK;
        }

        public bool ValidCustomerDOB(string DateOfBirth)
        {
            Boolean OK = true;
            DateTime DateTemp;

            DateTemp = Convert.ToDateTime(DateOfBirth);
            if (DateTemp < DateTime.Now.Date)
            {
                OK = false;
            }

            DateTemp = Convert.ToDateTime(DateOfBirth);
            if (DateTemp > DateTime.Now.Date)
            {
                OK = false;
            }
            return OK;
        }





    }
}