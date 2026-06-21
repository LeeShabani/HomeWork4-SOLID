using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    public interface IMessageSender
    {
        void send(string to, string message);
    }

    public class EmailSenderr : IMessageSender
    {
        public void send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to} : {message}");
        }
    }
    public class SmsSender : IMessageSender
    {
        public void send(string to, string message)
        {
            Console.WriteLine($"Sms sent to {to} : {message}");
        }
    }

    public class NotificationServicee
    {
        private readonly IMessageSender _messageSender;
        public NotificationServicee(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void send(string to, string message)
        {
            _messageSender.send(to, message);
        }
    }
}
