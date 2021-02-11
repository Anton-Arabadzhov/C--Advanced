using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainers
    {
        int numberOfBadges = 0;
        
        public string Name { get; set; }

        public int NumberOfBadges 
        {
            get {return numberOfBadges; }
            set { numberOfBadges = value; }
        }

        public List<Pokemon> Pokemon { get; set; }

        public Trainers(string name)
        {
            Name = name;
            this.numberOfBadges = 0;
            this.Pokemon = new List<Pokemon>();
        }
    }
}
