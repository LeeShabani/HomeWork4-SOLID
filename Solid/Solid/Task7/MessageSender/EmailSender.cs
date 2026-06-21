using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7.MessageSender
{
    public class EmailSender : IMessageSender
    {
        public void send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
