using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.cs
{
    internal class Order
    {
        private INotificationService notificationService;

        public Order(INotificationService _notificationService)
        {
            this.notificationService = _notificationService;
        }
        public void PlaceOrder()
        {
            // logic to place order like validation for order details, inventory check, payment processing etc.
             
            
            notificationService.SendNotification("Your order has been placed successfully.");
        }
    }
}
