using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine v12 = new Engine(580, 1200);
            Tire[] tires = new Tire[]
                {
                    new Tire(2018, 2.3),
                    new Tire(2018, 2.5),
                    new Tire(2018, 2.8),
                    new Tire(2018, 3.1),
                };

            Car Bmw = new Car("BMW", "318i", 1990, 200, 30, v12, tires);

            Console.WriteLine(Bmw.Engine.HorsePower);

            foreach (var tire in Bmw.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }
        }
    }
}
