using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double BaseWeightGain = 0.30;

        private static HashSet<string> AllowedFood = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Meat)
        };

        public Cat(string name,
            double weight, 
            string livingRegion, 
            string breed) 
            : base(name, weight,AllowedFood, BaseWeightGain, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

       

    }
}
