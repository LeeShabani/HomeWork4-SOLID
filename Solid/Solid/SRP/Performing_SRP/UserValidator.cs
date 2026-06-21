using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.SRP
{
    public class UserValidator
    {
        public void validate(string username, string email)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Not a valid Username or Email");
            }
        }
    }
}
