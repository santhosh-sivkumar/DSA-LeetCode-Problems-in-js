using Polymorphism;

// All three are stored as Animal (base type),
// but each one behaves according to its OWN class — this is Polymorphism.

List<Animal> animals = new List<Animal>
{
    new Dog("Bruno"),
    new Cat("Whiskers"),
    new Dog("Rex")
};

// We call the same method on every animal — each responds differently
foreach (Animal animal in animals)
{
    animal.MakeSound();
    animal.Move();
    Console.WriteLine();
}
