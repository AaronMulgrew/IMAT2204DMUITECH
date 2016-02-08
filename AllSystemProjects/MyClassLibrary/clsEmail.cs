using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsEmail
    {
        public object EmailAddress { get; set; }


        public int EmailNo { get; set; }

        public bool Valid(string SomeEmailAddress)
        {
            if (SomeEmailAddress.Length == 0)
            {
                return false;
            }
            else if (!SomeEmailAddress.Contains("@"))
            {
                return false;
            }
            return true;
        }

        public bool TimeStampValid(string TimeStamp)
        {
            Int32 DateNowYearMin = Convert.ToInt32(DateTime.Now.Year);
            DateNowYearMin = DateNowYearMin - 30;
            Int32 TimeStampInt = Convert.ToInt32(TimeStamp);
            if (TimeStampInt < DateNowYearMin)
            {
                return false;
            }
            return true;
        }
    }
}
