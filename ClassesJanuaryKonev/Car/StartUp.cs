using System;
using System.Collections.Generic;

namespace DefiningClasses
{ 
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);
                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }

            HashSet<Person> result = family.GetPplAbove30();

            foreach (var person in result)
            {
                Console.WriteLine(person);
            }
           
        }
    }
}
