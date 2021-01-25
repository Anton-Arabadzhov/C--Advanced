using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWhitQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(array);
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();
            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    list.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }

            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
