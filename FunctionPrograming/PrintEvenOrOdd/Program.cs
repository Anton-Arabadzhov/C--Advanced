using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = nums[0];
            int end = nums[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> numbers = new List<int>();

                for (int i = start; i < end; i++)
                {
                    numbers.Add(i);
                }
                return numbers;
            };
            List<int> numbers = generateList(start, end);
            Func<int, bool> evenPredicate
            numbers = numbers.Where();

            //Predicate<int> evenPredicate = n => n % 2 == 0;
            
        }
    }
}
