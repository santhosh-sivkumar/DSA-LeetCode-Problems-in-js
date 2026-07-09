using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Good
{
    // HumanWorker implements BOTH interfaces because humans can work AND eat
    internal class HumanWorker : IWorkable, IEatable
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
