using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Bad
{
    // HumanWorker can do both — this is fine
    internal class HumanWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating lunch.");
        }
    }
}
