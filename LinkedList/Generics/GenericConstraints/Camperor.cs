using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class Camperor<TFirst, TSecond>
        where TFirst: IComparable
        where TSecond: IComparable
    {
        public bool IsFirstBigger(TFirst first, TSecond second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
