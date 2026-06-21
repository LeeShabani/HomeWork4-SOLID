using Solid.SRP.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Performing_SRP
{
    public class UserRegistrationService
    {
        private readonly UserValidator _Validator;
        private readonly UserRepository _Repository;
        private readonly UserLogger _Logger;
        private readonly EmailService _emailService;

        public UserRegistrationService
            (UserValidator validator ,
            UserRepository Repository,
            UserLogger Logger,
            EmailService emailService
            )
        {
            _Validator = validator;
            _Repository = Repository;
            _Logger = Logger;
            _emailService = emailService; 
        }

        public void RegisterUser(string username , string email)
        {
            _Validator.validate(username , email);
            _Repository.Save(username , email);
            _emailService.SendWelcomeEmail(email);
            _Logger.Log("User Registered Successfully");
        }



    }
}
