using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Good
{
    // Low-level class — implements the abstraction
    internal class MySqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database.");
        }
    }
}
