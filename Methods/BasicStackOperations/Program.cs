using System;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] nums = Console.ReadLine().Split();
            bool isContains = false;
            int n = int.Parse(input[0]);
            int p = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int min = int.MaxValue;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(nums[i]);
                stack.Push(number);
            }
            for (int i = 0; i < p; i++)
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(c) )
                {
                    Console.WriteLine("true");
                }
                else 
                {
                    for (int i = 0; i < stack.Count; i++)
                    {
                        int small = stack.Peek();
                        if (small <= min)
                        {
                            min = small;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
            
        }
    }
}
