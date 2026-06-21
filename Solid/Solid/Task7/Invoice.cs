using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7
{
    public class Invoice
    {
        public string CustomerEmail { get; }
        public List<Product> Products { get; }
        public decimal TotalPrice { get; }

        public Invoice(string customerEmail, List<Product> products)
        {
            CustomerEmail = customerEmail;
            Products = products;
            TotalPrice = products.Sum(product => product.GetFinalPrice());
        }
    }
}
