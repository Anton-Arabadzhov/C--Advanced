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

            Queue<int> order = new Queue<int>(orders);

            int biggestOrder = 0;
            foreach (var item in order)
            {
                if (item >= biggestOrder)
                {
                    biggestOrder = item;
                }
            }
            Console.WriteLine(biggestOrder);
            while (food >= 0 )
            {
                int ord = order.Peek();

                if (ord <= food)
                {
                    food -= order.Dequeue();
                }
                else
                {
                    break;
                }
                if (order.Count == 0)
                {
                    break;
                }
            }
            if (order.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', order)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
