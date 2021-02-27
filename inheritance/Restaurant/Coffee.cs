using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMililiters = 50;
        private const decimal CoffePrice = 3.50M;
        

        public Coffee(string name, double coffeine)
            : base(name, CoffePrice, CoffeeMililiters)
        {
            this.Coffeine = coffeine;
            
        }
        public double Coffeine { get; set; }

    }
}
