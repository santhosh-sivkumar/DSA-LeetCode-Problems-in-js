using Liskov_Substitution_Principle_Good;

// ====================== GOOD (Follows LSP) ======================
// Rectangle and Square no longer inherit from each other.
// Both independently extend the abstract Shape class.
// Either can substitute for Shape — no surprises, no wrong results.

void PrintArea(Shape shape)
{
    Console.WriteLine($"Area: {shape.Area()}");
}

var rectangle = new Rectangle(5, 10);
Console.WriteLine("[Rectangle] 5 × 10 → expected 50:");
PrintArea(rectangle);   // Correct: 50

Console.WriteLine();

var square = new Square(5);
Console.WriteLine("[Square] side 5 → expected 25:");
PrintArea(square);      // Correct: 25 — Square and Rectangle are independent, no conflict.