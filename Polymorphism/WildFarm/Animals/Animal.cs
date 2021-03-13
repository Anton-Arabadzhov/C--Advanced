using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight,HashSet<string> allowedFoods, double weightModiffier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFoods;
            WeightModiffier = weightModiffier;
        }

        private HashSet<string> AllowedFoods { get; set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        private double WeightModiffier { get; set; }

        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            string foodType = food.GetType().Name;
            if (!AllowedFoods.Contains(foodType))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {foodType}!");
            }

            this.FoodEaten += food.Quantity;

            this.Weight += this.WeightModiffier * food.Quantity;
        }
        
    }
}
