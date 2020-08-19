using System;
using System.Collections.Generic;
using System.Text;

namespace O_in_SOLID
{
    class Square : Shape
    {
        public double Height { get; set; }
        public override double Area()
        {
            return Math.Sqrt(Height);
        }
    }
}
