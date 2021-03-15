using AdaptedPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptedPattern
{
    class BoricaPaymentProvidor : IBoricaPayment
    {
        public decimal CheckMoneyLeft(int Id)
        {
            return 42;
        }

        public bool PayMoney(decimal amount)
        {
            return true;
        }
    }
}
