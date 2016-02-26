using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace ServiceOrderTesting
{
    [TestClass]
    public class tstEmailCollection
    {
        [TestMethod]
        public void EmailCollectionInstanceOK()
        {
            //create instance of the class 
            clsEmailCollection AllEmails = new clsEmailCollection();
            //check to see exists
            Assert.IsNotNull(AllEmails);
        }

        [TestMethod]
        public void CountEmailPropertyOK()
        {
            //create instance of the class
            clsEmailCollection AllEmails = new clsEmailCollection();
            //count some database data
            Int32 SomeCount = 0;
            //assign the data
            AllEmails.Count = SomeCount;
            //test to see if equal
            Assert.AreEqual(AllEmails.Count, SomeCount);
        }

        [TestMethod]
        public void AllEmailsOK()
        {
            //create instance of the class
            clsEmailCollection Emails = new clsEmailCollection();
            //create some test data
            List<clsEmail> TestList = new List<clsEmail>();
            //add an item to the list
            clsEmail TestItem = new clsEmail();
            //set the properties
            TestItem.EmailNo = 1;
            TestItem.EmailAddress = "mulgrewaaron1@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data
            Emails.AllEmails = TestList;
            //test to see that the two are the same
            Assert.AreEqual(Emails.AllEmails, TestList);
        }


        [TestMethod]
        public void CountEmailMatchesList()
        {
            //create instance of the class
            clsEmailCollection Emails = new clsEmailCollection();
            //create some test data
            List<clsEmail> TestList = new List<clsEmail>();
            //add an item to the list
            clsEmail TestItem = new clsEmail();
            //set the properties
            TestItem.EmailNo = 1;
            TestItem.EmailAddress = "mulgrewaaron1@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data
            Emails.AllEmails = TestList;
            //test to see that the two are the same
            Assert.AreEqual(Emails.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoEmailsPresent()
        //{
        //    //create instance of the class
        //    clsEmailCollection Emails = new clsEmailCollection();
        //    //test to see the two values are equal
        //    Assert.AreEqual(Emails.Count, 2);
        //}


    }
}
