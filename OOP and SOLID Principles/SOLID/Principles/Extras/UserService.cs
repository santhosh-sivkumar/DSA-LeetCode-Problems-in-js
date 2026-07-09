using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsiblity_Principle_Good
{
    internal class UserService
    {
        public void Register(User user)
        {
            // logic to register the user like, validating email, if existing then redirecting to login, saving to database, etc.
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform!");
        }
    }
}
