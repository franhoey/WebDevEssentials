using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class DebugExample
    {
        private const int MOD = 25;

        public string Begin()
        {
            int startingPoint = CalculateStartingPoint();
            int modulus = startingPoint%MOD;

            int finalValue = modulus*22;

            return string.Format("The final value is {0}", finalValue);
        }

        private int CalculateStartingPoint()
        {
            var currentDate = DateTime.Now;
            int milliSeconds = currentDate.Millisecond;
            return milliSeconds;
        }
    }
}