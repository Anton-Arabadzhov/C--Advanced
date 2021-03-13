using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var age = int.Parse(data[1]);
                if (data.Length == 3)
                {
                    var group = data[2];
                    buyers.Add(name,new Rebel(name, age, group));
                }
                else
                {
                    var id = data[2];
                    var birth = data[3];
                    buyers.Add(name,new Citizen(name, age, id, birth));

                }
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                if (buyers.ContainsKey(line))
                {
                    buyers[line].BuyFood();
                }
                
            }
            var total = buyers.Select(p => p.Value.Food).Sum();

            Console.WriteLine(total);
        }
    }
}
