using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        // override = replace the parent's version with this specific one
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof! Woof!");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} runs on four legs.");
        }
    }
}
