using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeExample
{
    public class OvertimeEnabledEmployee : Employee
    {
        public decimal OvertimeRate { get; set; }
        public int UnpaidOvertimeHours { get; set; }

        private decimal CalculateUnpaidOvertime()
        {
            return OvertimeRate*UnpaidOvertimeHours;
        }

        public override decimal CalculatePay()
        {
            return base.CalculatePay() + CalculateUnpaidOvertime();
        }

    }
}
