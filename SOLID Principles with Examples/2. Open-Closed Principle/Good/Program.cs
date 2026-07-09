using Open_Closed_Principle_Good;

// ====================== GOOD (Follows OCP) ======================
// Shape is an abstract class. Each shape extends it with its own CalculateArea().
// To add a Triangle — just CREATE a new class. Nothing existing is touched.
// OPEN for extension (add new shapes freely), CLOSED for modification (never edit Shape).

var circle = new Circle { Radius = 5 };
Console.WriteLine($"[Circle]    Area: {circle.CalculateArea()}");

var rectangle = new Rectangle { Width = 4, Height = 6 };
Console.WriteLine($"[Rectangle] Area: {rectangle.CalculateArea()}");

// To add a Triangle:
// class Triangle : Shape {
//     public double Base { get; set; }
//     public double Height { get; set; }
//     public override double CalculateArea() => 0.5 * Base * Height;
// }
// ^ Zero changes to Shape, Circle, or Rectangle. Just add a new file.