using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //setup
            int myvalue = 3;

            //Execute
            int newValue = myvalue*myvalue;

            //Test output
            Assert.AreEqual(4, newValue);

        }
    }
}
