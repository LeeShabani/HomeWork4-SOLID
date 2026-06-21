using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7.Discount
{
    public interface IDiscount
    {
        decimal Apply(decimal value);
    }
}
