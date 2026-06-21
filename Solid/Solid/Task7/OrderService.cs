using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Task7.MessageSender;

namespace Solid.Task7
{
    public class OrderService
    {
        private readonly IMessageSender _messageSender;

        public OrderService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public Invoice Buy(string customerEmail, List<Product> products)
        {
            Invoice invoice = new Invoice(customerEmail, products);

            _messageSender.send(customerEmail, "Your order has been registered.");

            return invoice;
        }
    }
}
