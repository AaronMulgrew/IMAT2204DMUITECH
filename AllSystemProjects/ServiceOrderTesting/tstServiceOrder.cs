using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace ServiceOrderTesting
{
    /// <summary>
    /// Summary description for tstServiceOrder
    /// </summary>
    [TestClass]
    public class tstServiceOrder
    {      
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
            //create instance of class that is to be created
            clsServiceOrder AnOrder = new clsServiceOrder();
            //test to see that class exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void ServicePropertyOK()
        {
            //creat instance of the class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //create test data to assign to the property
            string SomeService = "CPU Repair";
            //assign the data to the property
            AnOrder.Service = SomeService;
            //test to see if both values are the same
            Assert.AreEqual(AnOrder.Service, SomeService);
        }
        [TestMethod]
        public void OrderNoOK()
        {
            //create instance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //create some test data to assign to property
            Int32 OrderNo = 120;
            //assign data to property
            AnOrder.OrderNo = OrderNo;
            //test to see if both values are the same
            Assert.AreEqual(AnOrder.OrderNo, OrderNo);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "CPU Repair";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ServiceMinLessOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsFalse(OK); 
        }
        [TestMethod]
        public void ServiceMinBoundary()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "C";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ServiceMinPlusOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "CP";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ServiceMaxLessOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "abcdefghijklmnopqrs";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ServiceMaxBoundary()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "abcdefghijklmnopqrst";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ServiceMaxPlusOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "abcdefghijklmnopqrstu";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ServiceMid()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "abcdefghij";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod] 
        public void ServiceExtremeMax()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "";
            //pad the data with characters.PadRight is a built in method that allows us to pad out an existing string with a set number of a specific character.
            SomeService = SomeService.PadRight(129, 'a');
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ValidNoOK()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeNumber = "123";
            //invoke the methoid
            OK = AnOrder.ValidNo(SomeNumber);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoLessOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "0";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoBoundary()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "1";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "2";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "999999999";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMaxBoundary()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "1000000000";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "1000000001";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMid()
        {
            //create insatance of class
            clsServiceOrder AnOrder = new clsServiceOrder();
            //boolean value to store result of validation., which is intitialised to false
            Boolean OK = false;
            //create some test data to assign to property
            string SomeService = "5000000000";
            //invoke the methoid
            OK = AnOrder.Valid(SomeService);
            //test to see if result is ok
            Assert.IsTrue(OK);
        }
       [TestMethod]
        public void FinMethodOK()
        {
           //create instance of class we want to create
            clsServiceOrder AnOrder = new clsServiceOrder();
           //boolean var to store result of validation
            Boolean Found = false;
           //create test data to use with the method
            Int32 OrderNo = 1;
           //invoke method
            Found = AnOrder.Find(OrderNo);
           //test to see that result is correcrt
            Assert.IsTrue(Found);
        }
       
     }
}
