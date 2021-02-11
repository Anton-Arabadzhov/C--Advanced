using System;
using System.Collections.Generic;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string>[] array = ArrayCreator.Create(5, new List<string>() { "gogi", "Muci" });

            foreach (var item in array)
            {
                foreach (var str in item)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
