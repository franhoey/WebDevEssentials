using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EmployeeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTests
{
    [TestClass]
    public class OvertimeEmployeeTests
    {
        [TestMethod]
        public void StandardPayCalculationIsCorrect()
        {
            decimal salary = 15000;
            decimal expectedPay = salary/12;

            //Setup
            var objUnderTest = new OvertimeEnabledEmployee()
                {
                    AnnualSalary = salary
                };

            //Execute
            var result = objUnderTest.CalculatePay();

            //Test
            Assert.AreEqual(expectedPay, result);
        }

        [TestMethod]
        public void PayCalculationIsCorrectIncludesOvertime()
        {
            decimal salary = 15000;
            decimal overtimeRate = 30; //£
            int overtimeHours = 5;

            decimal expectedPay = (salary / 12) + (overtimeRate * overtimeHours);


            //Setup
            var objUnderTest = new OvertimeEnabledEmployee()
            {
                AnnualSalary = salary,
                OvertimeRate = overtimeRate,
                UnpaidOvertimeHours = 5
            };

            //Execute
            var result = objUnderTest.CalculatePay();

            //Test
            Assert.AreEqual(expectedPay, result);
        }
    }
}
