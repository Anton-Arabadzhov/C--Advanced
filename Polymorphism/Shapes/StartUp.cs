using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(5, 6);
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());
            Console.WriteLine(rect.Draw());
            Shape circ = new Circle(5);
            Console.WriteLine(circ.CalculateArea());
            Console.WriteLine(circ.CalculatePerimeter());
            Console.WriteLine(circ.Draw());
        }
    }
}
