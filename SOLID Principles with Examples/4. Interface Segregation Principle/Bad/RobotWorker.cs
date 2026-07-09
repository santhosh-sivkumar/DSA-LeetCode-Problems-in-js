using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Bad
{
    // RobotWorker is forced to implement Eat() even though robots don't eat.
    // The only option is to throw an exception — a clear sign something is wrong.
    internal class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }

        public void Eat()
        {
            // Robots don't eat — but the interface forces us to write this method anyway!
            throw new NotImplementedException("Robots do not eat.");
        }
    }
}
