using System;
using System.Collections.Generic;

namespace MinMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                int action = int.Parse(command[0]);
                if (action == 1)
                {
                    int number = int.Parse(command[1]);
                    stack.Push(number);
                }
                else if (action == 2 && stack.Count > 0)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }

                }
                else if (action == 3 && stack.Count > 0)
                {
                    foreach (var item in stack)
                    {
                        if (item >= max)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);

                }
                else if (action == 4 && stack.Count > 0)
                {
                    foreach (var item in stack)
                    {
                        if (item <= min)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
