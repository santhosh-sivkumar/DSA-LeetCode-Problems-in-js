using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Good
{
    // High-level class — depends on the abstraction (IDatabase), not a concrete class
    internal class OrderService
    {
        private IDatabase database;

        // The database is injected from outside — OrderService doesn't decide which one to use
        public OrderService(IDatabase database)
        {
            this.database = database;
        }

        public void PlaceOrder(string orderDetails)
        {
            // logic to validate and process the order

            database.Save(orderDetails);
            Console.WriteLine("Order placed successfully.");
        }
    }
}
