using System;

namespace P02._DrawingShape_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager drawer = new DrawingManager();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorTop = 5;
            Console.CursorLeft = 5;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Circle circle = new Circle();
            drawer.Draw(circle);

            
        }
    }
}
