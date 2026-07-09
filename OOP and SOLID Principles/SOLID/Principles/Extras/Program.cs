using Open_Closed_Principle_Bad;

var shape = new Shape
{
    Type = ShapeType.Circle,
    Radius = 5
};

var area = shape.CalculateArea();
Console.WriteLine($"Area of the shape: {area}");