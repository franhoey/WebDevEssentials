using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeExample
{
    public class Employee
    {
        const int NUMBER_ANNUAL_PAY_PERIODS = 12;

        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public decimal AnnualSalary { get; set; }

        public virtual decimal CalculatePay()
        {
            return AnnualSalary / NUMBER_ANNUAL_PAY_PERIODS;
        }
    }
}
