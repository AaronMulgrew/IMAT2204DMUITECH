using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsCustomerSavedSearch
    {
        public string SavedSearch (string AgeFrom, string AgeTo, string Location)
        {
            clsDataConnection DataConnection = new clsDataConnection();
            DataConnection.AddParameter("AgeFrom", AgeFrom);
            DataConnection.AddParameter("AgeTo", AgeTo);
            DataConnection.AddParameter("Location", Location);
            DataConnection.Execute("sproc_tblCustomer_GetEmailAddressFromAgeAndLocation");

            string EmailAddress = "";

            //get the count
            Int32 RecordCount = DataConnection.Count;
            //set up index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                EmailAddress = DataConnection.DataTable.Rows[Index]["EmailAddress"].ToString();
            }

            return EmailAddress;
        }
    }
}
