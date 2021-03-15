using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    public class Sorter
    {
        
        private IsortingStrategy sortStrategy;
        public Sorter(IsortingStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }





        public List<int> Sort(List<int> list)
        {
            return sortStrategy.Sort(list);
        }
    }
}
