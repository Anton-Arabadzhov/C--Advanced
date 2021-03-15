using Liskov.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    public class Robot : IWorker
    {
       
        public void Work()
        {
            Console.WriteLine("Work Robot");
        }
    }
}
