using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> odds = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    odds.Enqueue(nums[i]);
                }
            }
            while (odds.Count > 1)
            {
                Console.Write($"{odds.Dequeue()}, ");
            }
            Console.Write(odds.Peek());
        }
    }
}
