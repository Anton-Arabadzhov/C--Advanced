using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] comand = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = comand[0];
                if (action == 1)
                {
                    int element = comand[1];
                    stack.Push(element);
                }
                else if (action == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (action == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine($"{stack.Max()}");
                    }
                    
                }
                else if (action == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine($"{stack.Min()}");
                    }
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", stack)}");
            }
            
        }
    }
}
