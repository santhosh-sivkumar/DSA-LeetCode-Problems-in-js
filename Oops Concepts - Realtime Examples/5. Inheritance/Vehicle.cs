using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("The vehicle is starting.");
        }

        public virtual void Stop() 
        { 
            Console.WriteLine("The vehicle is stopping."); 
        }
    }
}
