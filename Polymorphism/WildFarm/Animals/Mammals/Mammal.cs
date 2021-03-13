using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name,
            double weight,
            HashSet<string> allowedFoods,
            double weightModiffier,
            string livingRegion)
            : base(name, weight, allowedFoods, weightModiffier)
        {
            LivingRegion = livingRegion;
        }
        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return $"{ this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
