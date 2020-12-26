﻿using System;
using System.Linq;

namespace Predicate

{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> IsFirstLetterCapital =
                str => str[0] == str.ToUpper()[0];

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => IsFirstLetterCapital(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
