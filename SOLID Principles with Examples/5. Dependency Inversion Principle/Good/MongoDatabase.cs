using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Good
{
    // Another low-level class — just add a new implementation, no existing code changes needed
    internal class MongoDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MongoDB database.");
        }
    }
}
