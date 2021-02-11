using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> myScale = new EqualityScale<int>(5, 8);

            Console.WriteLine(myScale.AreEqual());
        }
    }
}
