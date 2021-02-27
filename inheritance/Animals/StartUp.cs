using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {

                
                var line = Console.ReadLine();

                if (line == "Beast!")
                {
                    break;
                }

                var data = Console.ReadLine().Split();

                var name = data[0];
                var age = int.Parse(data[1]);
                var gender = data[2];
                if (string.IsNullOrEmpty(name) ||
                    age < 0 ||
                    string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                
                if (line == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (line == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (line == "Frog")
                {
                    var frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else if (line == "Tomcat")
                {
                    var tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }
                else if (line == "Kitten")
                {
                    var kitten = new Kitten(name, age);
                    animals.Add(kitten);

                }

            }
            foreach (var pet in animals)
            {
                Console.WriteLine(pet);
                Console.WriteLine(pet.ProduceSound());
            }
        }
    }
}
