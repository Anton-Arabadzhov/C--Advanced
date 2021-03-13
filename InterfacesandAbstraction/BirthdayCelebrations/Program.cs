using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var type = data[0];

                if (type == nameof(Citizen))
                {
                    var name = data[1];
                    var age = int.Parse(data[2]);
                    var id = data[3];
                    var date = data[4];
                    birthables.Add(new Citizen(name, age, id, date));
                }
                else if (type == nameof(Pet))
                {
                    var name = data[1];
                    var date = data[2];

                    birthables.Add(new Pet(name, date));
                }


            }

            var filterYear = Console.ReadLine();

            var filtered = birthables.Where(p => p.Birthdate.EndsWith(filterYear)).ToList();
            
                foreach (var item in filtered)
                {

                    Console.WriteLine(item.Birthdate);
                }
            
            
           
            
        }
    }
}
