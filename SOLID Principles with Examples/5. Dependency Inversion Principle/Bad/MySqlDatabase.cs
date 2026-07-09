using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Bad
{
    // Low-level class — the actual database implementation
    internal class MySqlDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database.");
        }
    }
}
