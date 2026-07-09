using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.cs
{
    internal class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // logic to send SMS like connecting to SMS gateway etc.
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
