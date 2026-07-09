using Liskov_Substitution_Principle_Bad;

// ====================== BAD (Violates LSP) ======================
// Square inherits Rectangle but overrides Width/Height setters to keep both sides equal.
// When used as a Rectangle, it silently gives WRONG results — breaking the contract.
// Rule: a subclass must be substitutable for its parent without changing the expected behaviour.

void PrintArea(Rectangle shape)
{
    Console.WriteLine($"Area: {shape.GetArea()}");
}

var rectangle = new Rectangle { Width = 5, Height = 10 };
Console.WriteLine("[Rectangle] Width=5, Height=10 → expected 50:");
PrintArea(rectangle);   // Correct: 50

Console.WriteLine();

var square = new Square { Width = 5, Height = 10 };
// Setting Height=10 on Square also forces Width=10 (because it overrides both setters).
// So instead of 5×10=50 you get 10×10=100 — completely wrong!
Console.WriteLine("[Square as Rectangle] Width=5, Height=10 → expected 50, but...");
PrintArea(square);      // BROKEN: prints 100 — Square is NOT a safe substitute for Rectangle.