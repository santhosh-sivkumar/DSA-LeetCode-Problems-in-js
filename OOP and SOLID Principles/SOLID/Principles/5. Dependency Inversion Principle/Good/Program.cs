using Dependency_Inversion_Principle_Good;

// ====================== GOOD (Follows DIP) ======================
// OrderService depends on IDatabase (abstraction) — not on any specific database class.
// The database is injected from outside. OrderService has no idea which database it's using.
// To swap databases — just pass a different implementation. OrderService.cs is never touched.

var mysqlOrder = new OrderService(new MySqlDatabase());
mysqlOrder.PlaceOrder("Order #1001 - 2x Laptop");  // uses MySQL

Console.WriteLine();

var mongoOrder = new OrderService(new MongoDatabase());
mongoOrder.PlaceOrder("Order #1002 - 1x Phone");   // uses MongoDB

// ^ Same OrderService class, two completely different databases.
//   Zero changes to OrderService.cs — that is the whole point.
