using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptedPattern.Contract
{
    public interface IPaymentProvidor
    {
        bool PayAmount(decimal amount);
        bool ChechAvaliableMoney(string accountName);
    }
}
