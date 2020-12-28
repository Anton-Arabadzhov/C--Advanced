using System;
using System.Linq;

namespace CostumMinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minFunc = num =>
            {
                int min = int.MaxValue;

                foreach (var item in num)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(minFunc(nums));
        }
    }
}
