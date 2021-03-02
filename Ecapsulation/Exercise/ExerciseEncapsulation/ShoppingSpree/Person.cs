using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private  List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }
       

        public string Name
        {
            get { return name; }
            private set 
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty");
                name = value;
            }
        }
        

        public decimal Money
        {
            get { return money; }
            private set
            {
                Validator.ThrowIsCurrectMoney(value, "Money cannot be negative");
                money = value; 
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Price > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            this.bag.Add(product);
            this.Money -= product.Price;
        }

        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ", this.bag.Select(p=>p.Name))}";
        }


    }
}
