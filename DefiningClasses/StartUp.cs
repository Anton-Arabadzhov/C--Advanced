using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

           // int n = int.Parse(Console.ReadLine());

           // List<Person> people = new List<Person>();

           // for (int i = 0; i < n; i++)
           // {
            //    string[] personData = Console.ReadLine().Split(" ");
            //    string name = personData[0];
            //    int age = int.Parse(personData[1]);
//
            //    Person currPerson = new Person(name, age);
           //     people.Add(currPerson);
           // }

           // List<Person> filteredPeople = people
            //    .Where(p => p.Age > 30)
            //    .OrderBy(p => p.Name)
            //    .ToList();

           // foreach (Person item in filteredPeople)
           // {
           //     Console.WriteLine($"{item.Name} - {item.Age}");
           // }


            // add and find the oldest family member

             int n = int.Parse(Console.ReadLine());
             Family family = new Family();

             for (int i = 0; i < n; i++)
             {
                  string[] personData = Console.ReadLine().Split(" ");
                 string name = personData[0];
                  int age = int.Parse(personData[1]);

                Person currPerson = new Person(name, age);
                family.AddMember(currPerson);
              }

              Person oldestMember = family.GetOldestMember();
               Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
