using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    queue.Peek();
                    queue.Enqueue(queue.Peek());
                    queue.Dequeue();
                    
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
