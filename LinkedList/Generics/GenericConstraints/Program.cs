using System;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Camperor<int, int> comparer = new Camperor<int, int>();

            Console.WriteLine(comparer.IsFirstBigger(11,6));
        }
    }
}
