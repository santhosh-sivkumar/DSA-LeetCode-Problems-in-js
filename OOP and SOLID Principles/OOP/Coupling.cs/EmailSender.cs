using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.cs
{
    internal class EmailSender :  INotificationService
    {
        public void SendNotification(string message)
        {
            // logic to send email like connecting to smtp server etc.
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
