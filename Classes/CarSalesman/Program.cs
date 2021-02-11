using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engineList = new List<Engine>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double power = double.Parse(input[1]);

                if (input.Length == 4)
                {
                    string displacement = input[2];
                    string efficiency = input[3];
                    engineList.Add(new Engine(model, power, displacement, efficiency));
                }
                else if (input.Length == 2)
                {
                    engineList.Add(new Engine(model, power));
                }
                else if (input.Length == 3)
                {
                    if (char.IsDigit(input[2][0]))
                    {
                        string displacement = input[2];
                        engineList.Add(new Engine(model, power, displacement, "n/a"));
                    }
                    else
                    {
                        string eficiency = input[2];
                        engineList.Add(new Engine(model, power, "n/a", eficiency));
                    }

                }

            }

            List<Car> cars = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string enginModel = carInfo[1];
                Engine engine = null;
                foreach (var engineM in engineList)
                {
                    if (engineM.Model == enginModel)
                    {
                        engine = engineM;
                        break;
                    }
                }
                if (carInfo.Length == 4)
                {
                    string weight = carInfo[2];
                    string color = carInfo[3];
                    cars.Add(new Car(model, engine, weight, color));

                }
                else if (carInfo.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if (carInfo.Length == 3)
                {
                    if (char.IsDigit(carInfo[2][0]))
                    {
                        string weight = carInfo[2];
                        cars.Add(new Car(model, engine, weight, "n/a"));
                    }
                    else
                    {
                        string color = carInfo[2];
                        cars.Add(new Car(model, engine, "n/a", color));
                    }
                }
            }

           // foreach (var car in cars)
           // {
            //    Console.WriteLine($"{car.Model}:");
           //     Console.WriteLine($"{car.Engine.Model}");
           //     Console.WriteLine($"Power: {car.Engine.Power}:");
            //    Console.WriteLine($"Displacement: {car.Engine.Displacement}");
           //     Console.WriteLine($"Efficiency: {car.Engine.Efficiency}");
           //     Console.WriteLine($"Weight: {car.Weight}");
          //      Console.WriteLine($"Color: {car.Color}");
           // }

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
