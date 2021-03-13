using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public static class Validator
    {
        public static void ThrowNumberIsValid(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
    }
}
