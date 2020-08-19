using System;
using System.Collections.Generic;
using System.Text;

namespace O_in_SOLID
{
    class Triangle : Shape
    {
        public double FirstSide { get; set; } 
        public double SecondSide { get; set; } 
        public double ThirdSide { get; set; }
        public override double Area()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
    }
}
