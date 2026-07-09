using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Reponsibility_Principle_Bad
{
    internal class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            // logic to send email
            Console.WriteLine($"Email sent to {email} with message: {message}");
        }
    }
}
