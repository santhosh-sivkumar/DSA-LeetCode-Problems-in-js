using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.cs
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
