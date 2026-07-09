using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle_Bad
{
    internal class Square: Rectangle
    {
        public override int Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
