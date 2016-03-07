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
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //put in some test data
            DateTime TestData = new DateTime(25 / 07 / 2012);
            //assign the data to the property
            TestEmail.EmailTimeStamp = TestData;
            //check to see the data is equal
            Assert.AreEqual(TestEmail.EmailTimeStamp, TestData);
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
        public void EmailAddressNoOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //test data to the property
            Int32 SomeEmailAddressNo = 1;
            //assign the data to the property
            AEmail.EmailAddressNo = SomeEmailAddressNo;
            //test the data to see the two are equal
            Assert.AreEqual(AEmail.EmailAddressNo, SomeEmailAddressNo);
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

        [TestMethod]
        public void EmailSubjectMinLessOne()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.EmailSubjectValid("Aa");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailSubjectMin()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.EmailSubjectValid("aaa");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailSubjectMid()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.EmailSubjectValid("aaaaaaaaaaa");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailSubjectMax()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            OK = TestEmail.EmailSubjectValid("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //check to see if result is ok
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailSubjectMaxPlusOne()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.EmailSubjectValid("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailSubjectExtremeMax()
        {
            //instance of the clsEmail
            clsEmail TestEmail = new clsEmail();
            //test data to store result of validation
            Boolean OK;
            //test data to the property
            OK = TestEmail.EmailSubjectValid("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //check to see if result is ok
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailContentOK()
        {
            //create an instance of the class
            clsEmail AnEmail = new clsEmail();
            ///create some test data
            String testData = "skslskslkslk";
            //test data to the property
            AnEmail.EmailContent = testData;
            //check to see if ok
            Assert.AreEqual(AnEmail.EmailContent, testData);
        }


        [TestMethod]
        public void EmailTimeStampOK()
        {
            //create an instance of the class
            clsEmail AnEmail = new clsEmail();
            ///create some test data (the current date)
            DateTime testData = DateTime.Now.Date;
            //test data to the property
            AnEmail.EmailTimeStamp = testData;
            //check to see if ok
            Assert.AreEqual(AnEmail.EmailTimeStamp, testData);
        }

        [TestMethod]
        public void EmailSubjectOK()
        {
            //create an instance of the class
            clsEmail AnEmail = new clsEmail();
            ///create some test data (the current date)
            String testData = "blahblahblah";
            //test data to the property
            AnEmail.EmailSubject = testData;
            //check to see if ok
            Assert.AreEqual(AnEmail.EmailSubject, testData);
        }


        [TestMethod]
        public void EmailFindMethodOK()
        {
            //create an instance of the class
            clsEmail AnEmail = new clsEmail();
            //boolean var to store result of validation
            Boolean Found = false;
            //create some test data
            Int32 EmailNo = 1;
            //invoke find method
            Found = AnEmail.Find(EmailNo);
            //test to see if result is correct
            Assert.IsTrue(Found);
        }

    }
}
