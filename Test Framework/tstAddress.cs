using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of our class clsAddress

            clsAddress AnAddress = new clsAddress();
            //check to see that the class is not null
            Assert.IsNotNull(AnAddress);
        }
    }
}
