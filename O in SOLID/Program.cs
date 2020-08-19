using System;
using System.Collections.Generic;

namespace O_in_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle() { Radius = 10 });
            shapes.Add(new Square() { Height=4 });
            shapes.Add(new Triangle() { FirstSide=1, SecondSide=2,ThirdSide=2 });
            AreaDisplay temp = new AreaDisplay();
            temp.ShowArea(shapes);
        }
    }
}
