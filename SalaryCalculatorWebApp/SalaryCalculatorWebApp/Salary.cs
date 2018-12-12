using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculatorWebApp
{
    [Serializable]
    public class Salary
    {
        public decimal basicSalary;
        public decimal medicalAllowancePercentage;
        public decimal conveyancePercentage;

        public decimal GetTotalSalary()
        {
            decimal result = basicSalary + basicSalary*(medicalAllowancePercentage/100) +
                             basicSalary*(conveyancePercentage/100);
            return result;
        }

    }
}