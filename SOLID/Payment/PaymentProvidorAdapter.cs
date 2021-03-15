using AdaptedPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptedPattern
{
    class PaymentProvidorAdapter : IPaymentProvidor
    {
        private BoricaPaymentProvidor providor;
        public PaymentProvidorAdapter(BoricaPaymentProvidor providor)
        {
            this.providor = providor;
        }
        public bool ChechAvaliableMoney(string accountName)
        {
            providor.CheckMoneyLeft(42);
            return true;
        }

        public bool PayAmount(decimal amount)
        {
           return providor.PayMoney(amount);
        }
    }
}
