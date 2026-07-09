using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} creeps silently.");
        }
    }
}
