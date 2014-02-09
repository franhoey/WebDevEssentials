using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EmployeeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void CalculatePayCalculationIsCorrect()
        {
            decimal salary = 15000;
            decimal expectedPay = salary/12;

            //Setup
            var objUnderTest = new Employee()
                {
                    AnnualSalary = salary
                };

            //Execute
            var result = objUnderTest.CalculatePay();

            //Test
            Assert.AreEqual(expectedPay, result);
        }
    }
}
