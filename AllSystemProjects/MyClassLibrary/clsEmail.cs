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

        public bool Valid(string EmailAddress)
        {
            if (EmailAddress.Length == 0)
            {
                return false;
            }
            else if (EmailAddress.Length > 255)
            {
                return false;
            }
            else if (!EmailAddress.Contains("@"))
            {
                return false;
            }
            else if (EmailAddress.Contains("@"))
            {
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
            try
            {
                Int32 DateNowYear = Convert.ToInt32(DateTime.Now.Year);
                Int32 DateNowYearMin = DateNowYear - 30;
                Int32 TimeStampInt = Convert.ToInt32(TimeStamp);
                if (TimeStampInt < DateNowYearMin)
                {
                    return false;
                }
                else if (TimeStampInt > DateNowYear)
                {
                    return false;
                }
                return true;
            }

            catch
            {
                return false;
            }

        }

        public DateTime TimeStamp { get; set; }
    }
}
