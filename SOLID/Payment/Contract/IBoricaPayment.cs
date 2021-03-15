using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptedPattern.Contract
{
    public interface IBoricaPayment
    {
        bool PayMoney(decimal amount);
        decimal CheckMoneyLeft(int Id);
    }
}
