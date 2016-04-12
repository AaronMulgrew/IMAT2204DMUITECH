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
           // //create instance of the class 
            clsEmailAddressCollection AllEmails = new clsEmailAddressCollection();
            //check to see exists
            Assert.IsNotNull(AllEmails);
        }


        [TestMethod]
        public void GetEmailAddressOK()
        {
            //create instance of the class
            clsEmailCollection AllEmails = new clsEmailCollection();
            string LocalEmailAddress = "mulgrewaaron1@gmail.com";
            //check to see if it works ok
            string DatabaseEmailAdddress = AllEmails.GetEmailAddress(1);

            Assert.AreEqual(LocalEmailAddress, DatabaseEmailAdddress);

        }

        //[TestMethod]
        //public void CountEmailPropertyOK()
        //{
        //    //create instance of the class
        //    clsEmailAddressCollection AllEmails = new clsEmailAddressCollection();
        //    //count some database data
        //    Int32 SomeCount = 9;
        //    //assign the data
        //    AllEmails.CountEmailAddresses = SomeCount;
        //    //test to see if equal
        //    Assert.AreEqual(AllEmails.CountEmailAddresses, SomeCount);
        //}

        [TestMethod]
        public void ListEmailsAndCountOK()
        {
            //create an instance of the class we want to create
            clsEmailCollection AllAddresses = new clsEmailCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsEmail> TestList = new List<clsEmail>();
            //add an item to the list
            //create the item of test data
            clsEmail TestItem = new clsEmail();
            //set its properties
            TestItem.EmailAddress = "mulgrewaaron1@gmail.com";
            TestItem.EmailAddressNo = 1;
            TestItem.EmailSubject = "blahblah";
            TestItem.EmailContent = "blahblahblahblah";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AllEmails = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.CountEmails, TestList.Count);

        }




        [TestMethod]
        public void AllEmailsOK()
        {
            //create instance of the class
            clsEmailAddressCollection Emails = new clsEmailAddressCollection();
            //create some test data
            List<clsEmail> TestList = new List<clsEmail>();
            //add an item to the list
            clsEmail TestItem = new clsEmail();
            //set the properties
            TestItem.EmailAddressNo = 1;
            TestItem.EmailAddress = "mulgrewaaron1@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data
            Emails.AllEmailAddresses = TestList;
            //test to see that the two are the same
            Assert.AreEqual(Emails.AllEmailAddresses, TestList);
        }


        [TestMethod]
        public void CountEmailAddressMatchesList()
        {
            //create instance of the class
            clsEmailAddressCollection Emails = new clsEmailAddressCollection();
            //create some test data
            List<clsEmail> TestList = new List<clsEmail>();
            //add an item to the list
            clsEmail TestItem = new clsEmail();
            //set the properties
            TestItem.EmailAddressNo = 1;
            TestItem.EmailAddress = "mulgrewaaron1@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data
            Emails.AllEmailAddresses = TestList;
            //test to see that the two are the same
            Assert.AreEqual(Emails.CountEmailAddresses, TestList.Count);
        }

        [TestMethod]
        public void CheckIfUpdatedEmails()
        {
            clsEmailCollection Emails = new clsEmailCollection();

            Emails.UpdateEmails();

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
