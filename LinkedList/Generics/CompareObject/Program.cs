using System;
using System.Collections.Generic;

namespace CompareObject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<CampereObject<string>> newbox = new List<CampereObject<string>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                CampereObject<string> box = new CampereObject<string>(input);
                newbox.Add(box);

            }
            
            string value = Console.ReadLine();
            CampereObject<string> nBox = new CampereObject<string>(value);


            int count = GetGreaterThenCount(newbox, nBox);
            Console.WriteLine(count);
        }
        private static int GetGreaterThenCount<T>(List<CampereObject<T>> boxes, CampereObject<T> box)
            where T : IComparable
        {
            int count = 0;
            foreach (CampereObject<T> item in boxes)
            {
                if (item.Value.CompareTo(box) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
