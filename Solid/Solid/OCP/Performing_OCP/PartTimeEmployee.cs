using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Performing_OCP
{
    public class PartTimeEmployee : ISalaryCalculator
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary + 500;
        }
    }
}
