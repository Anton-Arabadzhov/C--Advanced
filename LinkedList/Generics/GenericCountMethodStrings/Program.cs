using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> newbox = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                newbox.Add(box);

            }

            string value = Console.ReadLine();
            Box<string> nBox = new Box<string>(value);


            int count = GetGreaterThenCount(newbox, nBox);
            Console.WriteLine(count);
            
        }
        private static int GetGreaterThenCount<T>(List<Box<T>> boxes, Box<T> box)
            where T: IComparable
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
