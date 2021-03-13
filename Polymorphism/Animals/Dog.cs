using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}
