using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> costumers = new Queue<string>();
            int count = 0;
            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (costumers.Count > 0)
                    {
                        Console.WriteLine(costumers.Dequeue());
                        count--;
                    }
                }
                else
                {
                    costumers.Enqueue(name);
                    count++;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
