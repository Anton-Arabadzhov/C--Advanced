using System;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries) ;
            string[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries) ;
            
            int n = int.Parse(input[0]);
            int p = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int min = int.MaxValue;
            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(nums[i]);
                stack.Enqueue(number);
            }
            for (int i = 0; i < p; i++)
            {
                stack.Dequeue();
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(c))
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
                            stack.Dequeue();
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
