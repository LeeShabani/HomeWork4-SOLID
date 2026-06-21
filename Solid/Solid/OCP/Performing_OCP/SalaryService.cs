using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Performing_OCP
{
    public class SalaryService
    {
        public decimal CalculateSalary(ISalaryCalculator salaryCalculator,decimal baseSalary)
        {
            return salaryCalculator.Calculate(baseSalary);
        }
    }
}
