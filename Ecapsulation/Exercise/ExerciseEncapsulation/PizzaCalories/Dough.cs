using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const string InvalidDoughExceptionMessiage = "Invalid type of Dough.";

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get => this.flourType;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "white" && valueAsLower != "wholegrain")
                {
                    throw new ArgumentException(InvalidDoughExceptionMessiage);
                }
                flourType = value;
            }
        }
        public string BakingTechnique 
        { 
            get => this.bakingTechnique;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "chewy" &&
                    valueAsLower != "crispy" &&
                    valueAsLower != "homemade")
                {
                    throw new ArgumentException(InvalidDoughExceptionMessiage);
                }
                this.bakingTechnique = value ;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                Validator.ThrowifNumberIsNotInRange(MinWeight,
                    MaxWeight,
                    value,
                    $"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                this.weight = value;
            }
        }
        public double GetCalories()
        {
            var flourTyperModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return this.Weight * 2 * flourTyperModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier()
        {
            var bakingTypeToLower = this.BakingTechnique.ToLower();
            if (bakingTypeToLower == "crispy")
            {
                return 0.9;
            }

            if (bakingTypeToLower == "chewy")
            {
                return 1.1;
            }

            return 1;
        }

        private double GetFlourTypeModifier()
        {
            var flourTypeToLowerr = this.FlourType.ToLower();
            if (flourTypeToLowerr == "white")
            {
                return 1.5;
            }
            return 1;
        }
    }
}
