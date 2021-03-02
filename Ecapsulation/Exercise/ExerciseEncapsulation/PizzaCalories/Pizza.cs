using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int nameMinLenght = 1;
        private const int nameMaxLenght = 15;
        private const int maxTopping = 10;

        private string name;
        private Dough dough;

        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (value.Length < nameMinLenght || value.Length > nameMaxLenght)
                {
                    throw new ArgumentException(
                        $"Pizza name should be between {nameMinLenght} and {nameMaxLenght} symbols.");
                }
                name = value; 
            }

        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == maxTopping)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [{0}..{maxTopping}].");
            }
            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            return this.dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
        }

    }
}
