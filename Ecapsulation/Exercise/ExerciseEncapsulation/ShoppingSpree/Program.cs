using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ppl = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            try
            {
            ppl = ReadPeople();
            products = ReadProducts();

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var parts = line.Split();

                var personName = parts[0];
                var productName = parts[1];


                var person = ppl[personName];
                var product = products[productName];
                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                
            }

            foreach (var person in ppl.Values)
            {
                Console.WriteLine(person);
            }
        }

        private static Dictionary<string, Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personalData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = personalData[0];
                var price = decimal.Parse(personalData[1]);
                result[name] = new Product(name, price);
            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personalData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = personalData[0];
                var money = decimal.Parse(personalData[1]);

                result[name] = new Person(name, money);

            }
                return result;
        }
    }
}
