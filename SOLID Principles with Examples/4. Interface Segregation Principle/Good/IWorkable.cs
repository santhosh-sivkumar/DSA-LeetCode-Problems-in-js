using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FIX: Split the big interface into two small, focused interfaces.
// Each class only implements the interface(s) that make sense for it.

namespace Interface_Segregation_Principle_Good
{
    internal interface IWorkable
    {
        void Work();
    }
}
