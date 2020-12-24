using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int pushesh = comand[0];
            int pops = comand[1];
            int contained = comand[2];
            Queue<int> queue = new Queue<int>();
            int[] pushes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < pushes.Length; i++)
            {
                queue.Enqueue(pushes[i]);
            }
            for (int i = 0; i < pops; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count > 0)
            {

                if (queue.Contains(contained))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
