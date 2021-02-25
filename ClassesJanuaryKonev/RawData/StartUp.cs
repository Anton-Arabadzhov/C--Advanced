using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tirePres1 = double.Parse(input[5]);
                int tireAge1 = int.Parse(input[6]);
                double tirePres2 = double.Parse(input[7]);
                int tireAge2 = int.Parse(input[8]);
                double tirePres3 = double.Parse(input[9]);
                int tireAge3 = int.Parse(input[10]);
                double tirePres4 = double.Parse(input[11]);
                int tireAge4 = int.Parse(input[12]);

                Engine engine = new Engine();
                engine.EnginePower = enginePower;
                engine.EngineSpeed = engineSpeed;
                Cargo cargo = new Cargo();
                cargo.CargoWeight = cargoWeight;
                cargo.CargoType = cargoType;
                
                    
                Tire tire1 = new Tire(tirePres1, tireAge1);
                Tire tire2 = new Tire(tirePres2, tireAge2);
                Tire tire3 = new Tire(tirePres3, tireAge3);
                Tire tire4 = new Tire(tirePres4, tireAge4);
                List<Tire> tires = new List<Tire>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);

                Car newCar = new Car(model, engine, cargo, tires);
                myCars.Add(newCar);

            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                myCars.Where(c => c.Cargo.CargoType == "fragile")
                    .Where(c => c.Tire.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
                
            }
            else if (command == "flamable")
            {
                
                    myCars.Where(c => c.Cargo.CargoType == "flamable")
                    .Where(c => c.Engine.EnginePower > 250)
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
               
            }


        }
    }
}
