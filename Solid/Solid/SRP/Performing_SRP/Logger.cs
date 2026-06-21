using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Performing_SRP
{
    public class UserLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
