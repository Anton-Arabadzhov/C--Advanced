using System;
using System.Collections.Generic;
using System.Linq;

namespace Names_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            names = names.Select(n => $"Sir {n}").ToList();
            Action<string[]> printNames = a => Console.WriteLine(string.Join(Environment.NewLine, a));
            printNames(names.ToArray());
        }
    }
}
