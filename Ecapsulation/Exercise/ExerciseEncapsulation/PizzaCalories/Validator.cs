using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validator
    {
        public static void ThrowifNumberIsNotInRange(int min, int max, int number, string exceptionMessage)
        {
            if (number < min || number > max)
            {
                throw new ArgumentException(exceptionMessage);

            }
        }

        public static void ThrowIfValidIsNotAllowed(HashSet<string> allowedValues,
            string value, string exceptionMessage)
        {
            if (!allowedValues.Contains(value))
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
