using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Strategies
{
    public class SelectionSort : IsortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Quick sort sux  O(n + log(n))");
            return list;
        }
    }
}
