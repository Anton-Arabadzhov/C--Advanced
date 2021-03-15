using P03._ShoppingCart;
using System;

namespace P03._ShoppingCart_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart card = new Cart();
            OrderItem order = new OrderItem();
            order.Sku = "BlackFriday";
            order.Price = 2.22m;
            Cart card2 = new Cart();
            OrderItem order2 = new OrderItem();
            order2.Sku = "HappyFriday";

            order2.Price = 2.22m;
            Cart card3 = new Cart();
            OrderItem order3 = new OrderItem();

            order3.Sku = "Special";
            order3.Price = 2.22m;
            card.Add(order);
            card2.Add(order2);
            card3.Add(order3);
            Console.WriteLine(card.TotalAmount());
            Console.WriteLine("BlackFriday");
            Console.WriteLine(card2.TotalAmount());
            Console.WriteLine("HappyFriday");
            Console.WriteLine(card3.TotalAmount());
            Console.WriteLine("Special");
        }
    }
}
