using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    internal class SmsSender: INotificationService
    {
        public void SendNotification(string message)
        {
            // logic for sending SMS like connecting to SMS gateway, auth, etc.
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
