using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Strategies
{
    public class QuickSort : IsortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Quick sort O(n + log(n)) (best case) worst case O(n^2)");
            return list;
        }
    }
}
