using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Performing_SRP
{
    public class UserRepository
    {
        public void Save(string Username , string Email)
        {
            Console.WriteLine("User Saved in DB");
        }
    }
}
