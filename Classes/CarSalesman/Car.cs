using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }


        public Car(string model, Engine engine, string weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string Model, Engine engine)
        {
            this.Model = Model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public override string ToString()
        {
            return $"{this.Model}:\n  {this.Engine.Model}:\n    Power: {this.Engine.Power}\n    Displacement: {this.Engine.Displacement}\n" +
                $"    Efficiency: {this.Engine.Efficiency}\n  Weight: {this.Weight}\n  Color: {this.Color}" ;
            
        }
    }
}
