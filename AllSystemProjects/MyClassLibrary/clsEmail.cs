using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsEmail
    {
        //getter and setter
        //public string EmailAddressFromEmailNo
        //{
        //    get
        //    {
        //        clsDataConnection DB = new clsDataConnection();
        //        DB.Execute("sproc_tblEmailAddress_GetEmailAddress");
        //        return EmailAddressFromEmailNo;
        //    }
        //}

        public string EmailAddress { get; set; }


        //getter and setter
        public int EmailAddressNo { get; set; }

        //getter and setter
        public int EmailNo { get; set; }

        //valid function
        public bool Valid(string EmailAddress)
        {
            //this runs if the length is 0
            if (EmailAddress.Length == 0)
            {
                return false;
            }
            //this runs if the length is above 255
            else if (EmailAddress.Length > 255)
            {
                return false;
            }
            //this runs if the email address does not contain an @ symbol
            else if (!EmailAddress.Contains("@"))
            {
                return false;
            }
            //this runs of the email address does contain an @ symbol
            else if (EmailAddress.Contains("@"))
            {
                //must contain both @ symbol and a . symbol
                //both of the constraints must be met in order to be true
                if (EmailAddress.Contains("."))
                {
                    return true;
                }
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool TimeStampValid(string TimeStamp)
        {
            //this tries everything and catches it if not true
            try
            {
                //converts the current date to an int
                Int32 DateNowYear = Convert.ToInt32(DateTime.Now.Year);
                //takes 30 away from the current year
                Int32 DateNowYearMin = DateNowYear - 30;
                //converts timestamp to int
                Int32 TimeStampInt = Convert.ToInt32(TimeStamp);
                //if timestamp is less than 30 behind current year
                if (TimeStampInt < DateNowYearMin)
                {
                    return false;
                }
                //this runs if the timestamp is more than the current year
                else if (TimeStampInt > DateNowYear)
                {
                    return false;
                }
                //this returns true if all has run ok
                return true;
            }

            //this catches any possible errors in the test
            catch
            {
                return false;
            }

        }

        public bool EmailSubjectValid(string EmailSubject)
        {
            //if the email subject is less than three
            if (EmailSubject.Length < 3)
            {
                return false;
            }
            //if the email subject is more than 100
            else if (EmailSubject.Length > 100)
            {
                return false;
            }
            return true;
        }

        public string EmailContent { get; set; }

        public DateTime EmailTimeStamp { get; set; }

        public string EmailSubject { get; set; }

        public string ArchiveNo { get; set; }
    }
}
