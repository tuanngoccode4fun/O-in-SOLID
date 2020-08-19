using System;
using System.Collections.Generic;
using System.Text;

namespace O_in_SOLID
{
   public class AreaDisplay
    {
        public void ShowArea(List<Shape> shapes)
        {
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.Area());
            }
        }
    }
}
