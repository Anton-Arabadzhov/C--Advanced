using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        public string Call(string number)
        {
            Validator.ThrowNumberIsValid(number);
            return $"Dialing... {number}";
        }
    }
}
