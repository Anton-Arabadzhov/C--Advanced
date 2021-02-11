using System;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Box<string> myBox = new Box<string>(input);
                Console.WriteLine(myBox.ToString());
            }
            
        }
    }
}
