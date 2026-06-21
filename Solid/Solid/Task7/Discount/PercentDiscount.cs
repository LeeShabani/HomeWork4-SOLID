using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7.Discount
{
    public class PercentDiscount : IDiscount
    {
        private readonly decimal _percent;
        public PercentDiscount(decimal percent)
        {
            _percent = percent;
        }
        public decimal Apply(decimal value)
        {
            return value - (value * _percent / 100);
        }
    }
}
