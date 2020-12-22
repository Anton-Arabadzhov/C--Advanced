using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string car = Console.ReadLine();
            int count = 0;

            while (car != "end")
            {
                if (car == "green")
                {
                    if (n < cars.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {  
                            count++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < cars.Count; i++)
                        {
                            count+=1;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            i--;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }
                
                
                car = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
