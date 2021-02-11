using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }

        public double Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine(string model, double power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

    }
}
