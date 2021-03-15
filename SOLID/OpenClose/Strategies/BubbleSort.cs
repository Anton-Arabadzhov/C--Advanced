using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Strategies
{
    public class BubbleSort : IsortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Quick sort O(n + log(n))");
            return list;
        }
    }
}
