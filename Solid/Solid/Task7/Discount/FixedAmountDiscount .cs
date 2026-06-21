using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7.Discount
{
    public class FixedAmountDiscount : IDiscount
    {
        private readonly decimal _amount;

        public FixedAmountDiscount(decimal amount)
        {
            _amount = amount;
        }
        public decimal Apply(decimal value)
        {
            decimal finalPrice = value - _amount;

            if (finalPrice < 0)
                return 0;

            return finalPrice;
        }
    }
}
