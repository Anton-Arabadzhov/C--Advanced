using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingGeneric
{
    public class Generic<T>
    {
        public  void PrintElement<T>(T element)
        {
            Console.WriteLine("Generics are cool " + element);
        }
    }
}
