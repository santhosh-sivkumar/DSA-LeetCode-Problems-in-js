using Dependency_Inversion_Principle_Bad;

// ====================== BAD (Violates DIP) ======================
// OrderService creates its own MySqlDatabase with 'new MySqlDatabase()' inside the constructor.
// High-level class (OrderService) is tightly coupled to a low-level class (MySqlDatabase).
// To switch to MongoDB, you must open OrderService.cs and change it — modifying working code.

var orderService = new OrderService();
orderService.PlaceOrder("Order #1001 - 2x Laptop");

// To switch databases you would have to:
//   Open OrderService.cs
//   Change: database = new MySqlDatabase();
//   To:     database = new MongoDatabase();
// You are forced to modify a class that should never need to change for a database swap.
