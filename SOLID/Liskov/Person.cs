using Liskov.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    public class Person : IWorker, ISleeper, IEater
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
