using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TraveledDistance { get; set; }

        public bool Drive(double distance)
        {
            double neededFuel = (FuelConsumptionPerKilometer * distance);
            if (neededFuel > this.FuelAmount)
            {
                return false;
            }
            else
            {

                this.FuelAmount -= neededFuel;
                this.TraveledDistance += distance;
                return true;
            }

        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }


    }
}
