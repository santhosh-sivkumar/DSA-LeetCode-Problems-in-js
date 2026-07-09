using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: OrderService (high-level) directly creates a MySqlDatabase (low-level) inside it.
// They are tightly coupled — if you ever want to switch to MongoDB or a different database,
// you have to come inside OrderService and change it. That breaks the class.

namespace Dependency_Inversion_Principle_Bad
{
    internal class OrderService
    {
        private MySqlDatabase database;

        public OrderService()
        {
            // OrderService is creating its own dependency — tightly coupled!
            database = new MySqlDatabase();
        }

        public void PlaceOrder(string orderDetails)
        {
            // logic to validate and process the order

            database.Save(orderDetails);
            Console.WriteLine("Order placed successfully.");
        }
    }
}
