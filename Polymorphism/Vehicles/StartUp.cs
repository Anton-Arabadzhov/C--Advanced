using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];
                string vehicleType = parts[1];
                double paramiter = double.Parse(parts[2]);





                try
                {
                    if (vehicleType == nameof(Car))
                    {
                        ProcessCommand(car, command, paramiter);

                    }
                    else if (vehicleType == nameof(Truck))
                    {
                        ProcessCommand(truck, command, paramiter);
                    }
                    else
                    {
                        ProcessCommand(bus, command, paramiter);
                    }
                }
                catch (Exception ex)
                when(ex is InvalidOperationException || ex is ArgumentException)
                {

                    Console.WriteLine(ex.Message);
                }




            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double paramiter)
        {
            if (command == "Drive")
            {
                
                vehicle.Drive(paramiter);

                    Console.WriteLine($"{vehicle.GetType().Name} travelled {paramiter} km");
                


            }
            else if (command == "DriveEmpty")
            {
                
                    ((Bus)vehicle).TurnOffAirConditioner();
                    vehicle.Drive(paramiter);
                Console.WriteLine($"{vehicle.GetType().Name} travelled {paramiter} km");
                ((Bus)vehicle).TurnOnAirConditioner();

            }
            else
            {
                vehicle.Refuel(paramiter);
            }
            
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumption = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }

            return vehicle;
        }
    }
}
