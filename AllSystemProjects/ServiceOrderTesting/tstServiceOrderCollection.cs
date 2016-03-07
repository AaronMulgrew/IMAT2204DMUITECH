using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;


namespace ServiceOrderTesting
{
    /// <summary>
    /// Summary description for tstServiceOrderCollection
    /// </summary>
    [TestClass]
    public class tstServiceOrderCollection
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
            //create instance of class we want to create
            clsServiceOrderCollection AllCounties = new clsServiceOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCounties);
        }

       [TestMethod]
        public void CountPropertyOK()
        {
           //create instance of class we want to create
            clsServiceOrderCollection AllOrders = new clsServiceOrderCollection();
           //create some test data to assign to the property
            Int32 SomeOrder = 1;
           //assign data to the property
            AllOrders.Count = SomeOrder;
           //test to see that the 2 values are same
            Assert.AreEqual(AllOrders.Count, SomeOrder);
        }
        [TestMethod]
        public void AllOrdersOK()
       {
            //create instance of class we want to create
           clsServiceOrderCollection Orders = new clsServiceOrderCollection();
            //create some test data to assign to property
            //the data needs to be a list of objects in this case
           List<clsServiceOrder> TestList = new List<clsServiceOrder>();
            //add an item to the list
            //create item of test data
           clsServiceOrder TestItem = new clsServiceOrder();
            //set its properties
           TestItem.OrderNo = 1;
           TestItem.Service = "Antivirus";
            //add item to the test list
           TestList.Add(TestItem);
            //assign data to the property
           Orders.AllOrders = TestList;
            //test to see that the two values are the same
           Assert.AreEqual(Orders.AllOrders, TestList);
       }

    
    }
}
