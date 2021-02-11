using System;

namespace ImplementingGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            Generic<int> generic = new Generic<int>();

            generic.PrintElement(5);
            generic.PrintElement("Some String");
        }
    }
}
