using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Strategies
{
    public class MurgeSort : IsortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Merge sort good but not fast");
            return list;
        }
    }
}
