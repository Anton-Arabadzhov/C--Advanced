using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrWhiteSpace(string str, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exceptionMessage);

            }

        }
        public static void ThrowIfStatsIsNotValid(int stats, int minValue, int maxValue, string exceptionMessage)
        {
            if (minValue > stats || stats > maxValue)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

    }
}
