using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: This one big interface forces ALL workers (including robots) to implement Eat().
// A Robot cannot eat — it is forced to implement a method that does not apply to it.
// This violates the Interface Segregation Principle.

namespace Interface_Segregation_Principle_Bad
{
    internal interface IWorker
    {
        void Work();
        void Eat();   // <-- Robots should NOT have to implement this
    }
}
