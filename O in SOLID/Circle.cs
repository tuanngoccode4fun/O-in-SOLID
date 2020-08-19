using System;
using System.Collections.Generic;
using System.Text;

namespace O_in_SOLID
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
