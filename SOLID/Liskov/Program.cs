using Liskov.Contracts;
using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            ISleeper worker = new Person();
            IWorker robot = new Robot();

            worker.Sleep();
            robot.Work();

        }
    }
}
