using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ");
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumprion = double.Parse(carData[2]);

                Car currCar = new Car()
                {
                    Model = model,
                FuelAmount = fuelAmount,
                FuelConsumptionPerKilometer = fuelConsumprion
                };

                cars.Add(currCar);
            }
            

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitedCom = command.Split();
                string carModel = splitedCom[1];
                double amountOfKm = double.Parse(splitedCom[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModel);
                bool isDrive = car.Drive(amountOfKm);

                if (!isDrive)
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }

                    command = Console.ReadLine();
            }
            foreach (Car car1 in cars)
            {
                Console.WriteLine($"{car1.Model} {car1.FuelAmount:f2} {car1.TravelledDistance}");
            }
        }
    }
}
