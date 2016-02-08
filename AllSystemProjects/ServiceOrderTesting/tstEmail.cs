using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestEmail
{
    [TestClass]
    public class tstEmail
    {
        [TestMethod]
        public void EmailInstanceOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //check if not null
            Assert.IsNotNull(AEmail);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //test data to the property
            string SomeEmailAddress = "mulgrewaaron1@gmail.com";
            //assign the data to the property
            AEmail.EmailAddress = SomeEmailAddress;
            //test the data to see the two are equal
            Assert.AreEqual(AEmail.EmailAddress, SomeEmailAddress);
        }

        [TestMethod]
        public void EmailNoOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //test data to the property
            Int32 SomeEmailNo = 1;
            //assign the data to the property
            AEmail.EmailNo = SomeEmailNo;
            //test the data to see the two are equal
            Assert.AreEqual(AEmail.EmailNo, SomeEmailNo);
        }

        [TestMethod]
        public void EmailValidMethodOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK = false;
            //assign the data to the property
            string SomeEmail = "mulgrewaaron1@gmail.com";
            //invoke the method
            OK = AEmail.Valid(SomeEmail);
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressWithoutAt()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("mulgrewaaron1gmail.com");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMinLessOne()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("1950");
            Assert.IsFalse(OK);
        }

    }
}
