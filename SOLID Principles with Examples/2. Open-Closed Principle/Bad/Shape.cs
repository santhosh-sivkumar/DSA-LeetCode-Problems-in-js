using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_Bad
{
    internal class Shape
    {
        public double Radius { get; set; }  
        public double Length { get; set; }
        public double Width { get; set; }

        public ShapeType Type { get; set; }

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Radius * Radius;
                case ShapeType.Rectangle:
                    return Length * Width;
                default:
                    throw new NotSupportedException("Shape type not supported");
            }
        }
    }
}
