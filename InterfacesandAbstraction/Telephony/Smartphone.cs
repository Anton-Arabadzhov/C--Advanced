using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling , IBrowzing
    {
        public string Browzing(string url)
        {
            if (url.Any(x=>char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        public  string Call(string number)
        {
            Validator.ThrowNumberIsValid(number);
            return $"Calling... {number}";
        }
    }
}
