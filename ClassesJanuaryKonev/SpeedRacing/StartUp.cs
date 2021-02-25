using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> myCars = new List<Car>();
            ;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelPerKm = double.Parse(input[2]);

                Car newCar = new Car()
                {
                    Model = model,
                    FuelAmount = fuel,
                    FuelConsumptionPerKilometer = fuelPerKm

                };
                myCars.Add(newCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] Data = command.Split();

                string model = Data[1];
                int distance = int.Parse(Data[2]);

                Car currentCar = myCars.FirstOrDefault(p => p.Model == model);
                bool isDrive = currentCar.Drive(distance);

                if (!isDrive)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (var car in myCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
