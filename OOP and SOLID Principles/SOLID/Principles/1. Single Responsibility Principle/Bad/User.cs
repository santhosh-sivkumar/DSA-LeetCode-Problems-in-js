using Single_Reponsibility_Principle_Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// user class is responsible for both user registration and sending email, which violates the Single Responsibility Principle. It should only be responsible for user registration, and the email sending logic should be handled by a separate class (EmailSender).
namespace Single_Reponsibility_Principle_Bad
{
    internal class User
    {

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public string Username { get; set; }
        public string Email { get; set; }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public void Register()
        {
            // logic to register the user like, validating email, if existing then redirecting to login, saving to database, etc.


            // Send Email

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(Email, "Welcome to our platform!");
        }
    }
}
