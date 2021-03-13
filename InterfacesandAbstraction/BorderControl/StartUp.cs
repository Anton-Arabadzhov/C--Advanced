using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentiable> myList = new List<IIdentiable>();


            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (data.Length == 2)
                {
                    var model = data[0];
                    var id = data[1];

                   
                    myList.Add(new Robots(model, id));


                }
                else if (data.Length == 3)
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var id = data[2];
                    
                    myList.Add(new Citizens(name, age, id));
                }

            }

            string num = Console.ReadLine();

            var filtered = myList.Where(p => p.Id.EndsWith(num)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
