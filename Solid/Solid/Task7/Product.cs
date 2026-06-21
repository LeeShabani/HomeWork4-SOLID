using Solid.Task7.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7
{

    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        private readonly IDiscount _discount;

        public Product(string name, decimal price, IDiscount discount)
        {
            Name = name;
            Price = price;
            _discount = discount;
        }

        public decimal GetFinalPrice()
        {
            return _discount.Apply(Price);
        }
    }
}
