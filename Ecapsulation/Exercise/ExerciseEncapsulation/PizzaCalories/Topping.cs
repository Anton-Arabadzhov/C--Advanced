using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int ToppingMinWeight = 1;
        private const int ToppingMaxWeight = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowIfValidIsNotAllowed(
                    new HashSet<string> { "meat", "veggies", "cheese", "sauce" },
                    value.ToLower(),
                    $"Cannot place {value} on top of your pizza.");
                

                
                this.name = value;
            }
        }
       

        public int Weight
        {
            get => weight;
            private set 
            {
                Validator.ThrowifNumberIsNotInRange(
                    ToppingMinWeight,
                    ToppingMaxWeight,
                    value,
                    $"{this.Name} weight should be in the range [{ToppingMinWeight}..{ToppingMaxWeight}].");
                this.weight = value;
            }
            
        }


        public double GetCalories()
        {
            var modifier = GetModifier();
            return this.Weight * 2 * modifier;
        }

        private double GetModifier()
        {
            var nameToLower = this.Name.ToLower();
            if (nameToLower == "meat")
            {
                return 1.2;
            }

            if (nameToLower == "veggies")
            {
                return 0.8;
            }

            if (nameToLower == "cheese")
            {
                return 1.1;
            }

            return 0.9;
        }
    }
}
