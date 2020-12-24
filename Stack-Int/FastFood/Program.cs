using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int max = queue.Max();

            while (queue.Count > 0)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Peek();
                    queue.Dequeue();
                    
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(max);
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
