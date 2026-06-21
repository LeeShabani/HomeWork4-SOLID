using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Task7.MessageSender
{
    public interface IMessageSender
    {
        void send(string to, string message);
    }
}
