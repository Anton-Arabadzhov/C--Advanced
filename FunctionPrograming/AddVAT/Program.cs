using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x =>
                {
                    int num = int.Parse(x);
                    return num * 1.2;
                })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
