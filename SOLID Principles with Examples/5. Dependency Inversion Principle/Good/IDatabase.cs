using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FIX: Introduce an abstraction (interface) that both the high-level and low-level classes depend on.
// OrderService depends on IDatabase — not on any specific database class.
// This means you can swap MySQL for MongoDB without touching OrderService at all.

namespace Dependency_Inversion_Principle_Good
{
    internal interface IDatabase
    {
        void Save(string data);
    }
}
