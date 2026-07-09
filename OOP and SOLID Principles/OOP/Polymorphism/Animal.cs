using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Polymorphism means "many forms".
// The same method name (MakeSound) behaves differently depending on the actual object type.
// This is decided at runtime — called Runtime Polymorphism (method overriding).

namespace Polymorphism
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        // virtual = can be overridden by a subclass
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a generic animal sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves.");
        }
    }
}
