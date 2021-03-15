namespace P03._ShoppingCart
{
    using P03._ShoppingCart_Before.Contracts;
    using P03._ShoppingCart_Before.Rules;
    using System.Collections.Generic;
    using System.Linq;

    public class Cart
    {
        private readonly List<OrderItem> items;
        private readonly List<IPriceRules> promotionRules = new List<IPriceRules>()
        {
            new HappyFrideyRules(),
            new SpecialRule(),
            new BlackFridayRule()
            
        };

        public Cart()
        {
            this.items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return new List<OrderItem>(this.items); }
        }

        public string CustmerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            this.items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;

            foreach (var item in this.items)
            {
                var promotionRules = this.promotionRules.FirstOrDefault(r => r.IsMatch(item));
                if (promotionRules == null)
                {
                    total += item.Price;
                }
                else
                {
                    total += promotionRules.CalculatePrice(item);
                }
            }

            return total; 
        }
    }
}
