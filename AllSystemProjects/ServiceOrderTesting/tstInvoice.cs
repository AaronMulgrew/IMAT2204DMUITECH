using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace InvoiceTest
{
    /// <summary>
    /// Summary description for tstInvoice
    /// </summary>
    [TestClass]
    public class tstInvoice
    {
        public tstInvoice()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //test to see that it exists
            Assert.IsNotNull(AInvoice);
        }

        [TestMethod]
        public void AddressProperty()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            string SomeAddress = "Leicestershire";
            //assign the data to the property
            AInvoice.Address = SomeAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AInvoice.Address, SomeAddress);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            Int32 AddressNo = 1;
            //assign the data to the property
            AInvoice.AddressNo = AddressNo;
            //test to see that the two values are the same
            Assert.AreEqual(AInvoice.AddressNo, AddressNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "Leicestershire";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "a";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "aa";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "abcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "abcdefghijabcdefghijabcde";
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeAddress = "";
            //pad the string with a character
            SomeAddress = SomeAddress.PadRight(500, 'a');
            //invoke the method
            OK = AInvoice.Valid(SomeAddress);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}