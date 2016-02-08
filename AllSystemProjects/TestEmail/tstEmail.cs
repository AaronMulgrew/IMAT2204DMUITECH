using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestEmail
{
    [TestClass]
    public class tstEmail
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of clsEmail
            clsEmail AEmail = new clsEmail();
            //check if not null
            Assert.IsNotNull(AEmail);
        }
    }
}
