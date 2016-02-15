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
        public void TimeStampOK()
        {
            clsEmail TestEmail = new clsEmail();
            DateTime TestData = new DateTime(25 / 07 / 2012);
            TestEmail.TimeStamp = TestData;
            Assert.AreEqual(TestEmail.TimeStamp, TestData);
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
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressWithoutAt()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("mulgrewaaron1gmail.com");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("j@c");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("wjwjjwwjjwjwjw@gmail.com");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("Skljdkdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("Sakljdkdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressExtreme()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("Skljddaqwwuiwuweuieuiueiiuewueweiukdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressInvalid()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.Valid("1212980");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TimeStampExtremeMin()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("1900");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMinLessOne()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("1985");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMin()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("1986");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMid()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("1996");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMax()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            OK = TestEmail.TimeStampValid("2016");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMaxPlusOne()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("2017");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampExtremeMax()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("2066");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMaxInvalidData()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.TimeStampValid("101010101");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

    }
}
