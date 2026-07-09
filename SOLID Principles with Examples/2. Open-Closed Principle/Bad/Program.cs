using Open_Closed_Principle_Bad;

// ====================== BAD (Violates OCP) ======================
// Shape.CalculateArea() uses a switch on ShapeType.
// To add a Triangle, you must open Shape.cs and add a new case — modifying working code.
// Classes should be OPEN for extension but CLOSED for modification.

var circle = new Shape { Type = ShapeType.Circle, Radius = 5 };
Console.WriteLine($"[Circle]    Area: {circle.CalculateArea()}");

var rectangle = new Shape { Type = ShapeType.Rectangle, Width = 4, Length = 6 };
Console.WriteLine($"[Rectangle] Area: {rectangle.CalculateArea()}");

// To add a Triangle you would have to:
//   Step 1 — Open ShapeType.cs  → add Triangle to the enum       (modifying existing file)
//   Step 2 — Open Shape.cs      → add a new case in the switch   (modifying existing file)
// You touch existing, working code every time a new shape is needed.