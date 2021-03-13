using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        public int MyProperty { get; set; }

        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
            
        }
        
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}
