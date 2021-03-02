using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exception)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exception);
            }
        }
        public static void ThrowIsCurrectMoney(decimal money, string exception)
        {
            if ( money < 0)
            {
                throw new ArgumentException(exception);
            }
        }
    }
}
