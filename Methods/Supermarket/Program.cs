using System;
using System.Collections.Generic;


namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine(names.Dequeue().ToString());
                    }
                }
                else
                {
                    names.Enqueue(command);
                }

                command = Console.ReadLine();
            }
            int num = names.Count;
            Console.WriteLine($"{num}");
        }
    }
}
