using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    internal class EmailSender : INotificationService
    {

        public void SendNotification(string message)
        {
            // logic for sendemail like connecting email server, auth, etc.
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
