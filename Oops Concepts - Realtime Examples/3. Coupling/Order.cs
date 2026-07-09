using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    internal class Order
    {

        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            this._notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            // logic to place order like validating order details, checking inventory, processing payment.
            
            _notificationService.SendNotification("Order placed successfully.");

        }
    }
}
