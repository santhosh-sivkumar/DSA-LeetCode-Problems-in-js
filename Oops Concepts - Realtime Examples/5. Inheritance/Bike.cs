using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bike : Vehicle
    {
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("The bike is starting");
        }
        public override void Stop()
        {
            Console.WriteLine("The bike is stopping");
        }
    }
}
