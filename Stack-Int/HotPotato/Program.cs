using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string[] names = Console.ReadLine().Split(' ');
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < names.Length; i++)
            {
                queue.Enqueue(names[i]);
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                
                //  PrintQueue(queue);
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            foreach (var item in queue)
            {
                Console.WriteLine($"Last is {item}");
            }
        }
        static void PrintQueue(Queue<string> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item + ' ');
            }
        }
    }
}
