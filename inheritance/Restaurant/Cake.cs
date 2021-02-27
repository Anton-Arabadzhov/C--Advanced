using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double defaultCalories = 1000;
        private const double cakeGrams = 250;
        private const decimal cakePrice = 5;

        public Cake(string name)
            :base(name,cakePrice,cakeGrams,defaultCalories)
        {
            
        }
        
        
        
    }
}
