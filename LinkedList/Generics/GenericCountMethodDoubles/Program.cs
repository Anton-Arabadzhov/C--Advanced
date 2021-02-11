using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> newbox = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                newbox.Add(box);

            }

            double value = double.Parse(Console.ReadLine());
            Box<double> nBox = new Box<double>(value);


            int count = GetGreaterThenCount(newbox, nBox);
            Console.WriteLine(count);
        }
        private static int GetGreaterThenCount<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(box.Value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
