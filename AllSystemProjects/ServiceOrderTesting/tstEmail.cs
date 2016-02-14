﻿using System;
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
        public void EmailAddressMin()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("j@c");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("wjwjjwwjjwjwjw@gmail.com");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("Skljdkdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("Sakljdkdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressExtreme()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("Skljddaqwwuiwuweuieuiueiiuewueweiukdjdldkjdkdjkldljkdjkkakjsjksjkjksjksjksjksjksjksjkjskjksjksjkjssjsjsjjsjsjsjsjsjsjsjsjjsjsjasjsjsjsjsjsjsjsjsjsjsjsjsjjallalqowpoweopwowposjksjksjkjksjsaaaaaaaajkssjkjssjsjsjssjsqjwjsjsjsjsjsaaajsjsjsjjjjjjwqasjsjsjsjsjsjsjjskjslkjdjkldjkl@gmail.com");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressInvalid()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.Valid("1212980");
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TimeStampExtremeMin()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("1900");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMinLessOne()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("1985");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMin()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("1986");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMid()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("1996");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMax()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("2016");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TimeStampMaxPlusOne()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("2017");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampExtremeMax()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("2066");
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TimeStampMaxInvalidData()
        {
            clsEmail TestEmail = new clsEmail();
            Boolean OK;
            OK = TestEmail.TimeStampValid("101010101");
            Assert.IsFalse(OK);
        }

    }
}