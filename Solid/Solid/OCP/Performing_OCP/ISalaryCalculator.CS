using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Performing_OCP
{
    public interface ISalaryCalculator
    {
        decimal Calculate(decimal baseSalary);
    }
}
