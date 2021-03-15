﻿using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Rules
{
    public class BlackFridayRule : IPriceRules
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Price / 3;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("BlackFriday");
        }
    }
}
