 using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] AnimalParts = line.Split();

                Animal animal = CreateAnimal(AnimalParts);
                animals.Add(animal);

                string[] foodParts = Console.ReadLine().Split();

                Food food = CreateFood(foodParts);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] parts)
        {
            string type = parts[0];
            int quatity = int.Parse(parts[1]);

            Food food = null;

            if (type == nameof(Meat))
            {
                food = new Meat(quatity);
            }
            else if (type == nameof(Fruit))
            {
                food = new Fruit(quatity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quatity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quatity);
            }
            return food;
        }

        private static Animal CreateAnimal(string[] Parts)
        {
            string type = Parts[0];

            Animal animal = null;

            string name = Parts[1];
            double weight = double.Parse(Parts[2]);

            if (type == nameof(Hen))
            {
                double wingSize = double.Parse(Parts[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(Parts[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Mouse))
            {
                string livingRegions = Parts[3];
                animal = new Mouse(name, weight, livingRegions);
            }
            else if (type == nameof(Dog))
            {
                string livingRegions = Parts[3];
                animal = new Dog(name, weight, livingRegions);
            }
            else if (type == nameof(Cat))
            {
                string livingRegions = Parts[3];
                string breed = Parts[4];
                animal = new Cat(name, weight, livingRegions, breed);

            }
            else if (type == nameof(Tiger))
            {
                string livingRegions = Parts[3];
                string breed = Parts[4];
                animal = new Tiger(name, weight, livingRegions, breed);
            }
            return animal;
        }
    }
}
