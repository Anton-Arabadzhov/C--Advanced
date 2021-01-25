using System;
using System.Collections.Generic;

namespace Traficjam
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();

            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    if (cars.Count >= pass)
                    {
                        for (int i = 0; i < pass; i++)
                        {
                            Console.WriteLine($"{cars.Peek()} passed!");
                            cars.Dequeue();
                            count++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < cars.Count; i++)
                        {
                            Console.WriteLine($"{cars.Peek()} passed!");
                            cars.Dequeue();
                            count++;
                        }
                    }
                    
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
