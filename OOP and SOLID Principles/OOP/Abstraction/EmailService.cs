using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class EmailService
    {
        private void Connect()
        {
            Console.WriteLine("Connecting to Email Server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating Email User...");
        }

        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending Email...");
            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from Email Server...");
        }   
    }
}
