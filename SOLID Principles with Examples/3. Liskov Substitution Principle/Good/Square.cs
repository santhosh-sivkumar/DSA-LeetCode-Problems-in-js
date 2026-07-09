using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle_Good
{
    internal class Square:Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
