using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainers> trainers = new List<Trainers>();


            while (command != "Tournament")
            {
                string[] splittedCom = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splittedCom[0];
                string pokemonName = splittedCom[1];
                string pokemonEle = splittedCom[2];
                int pokemonHealth = int.Parse(splittedCom[3]);
                Trainers trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer != null)
                {
                    trainer.Pokemon.Add(new Pokemon(pokemonName, pokemonEle, pokemonHealth));


                }
                else
                {
                    Trainers newTrainer = new Trainers(trainerName);
                    newTrainer.Pokemon.Add(new Pokemon(pokemonName, pokemonEle, pokemonHealth));
                    trainers.Add(newTrainer);

                }





                command = Console.ReadLine();
            }


            command = Console.ReadLine().TrimEnd();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (!trainer.Pokemon.Any( x=>x.Element == command))
                    {
                        foreach (var element in trainer.Pokemon)
                        {
                            element.Health -= 10;
                        }
                    }
                    else
                    {
                        trainer.NumberOfBadges++;
                    }
                }

                command = Console.ReadLine().TrimEnd();
            }

            foreach (var pokemon in trainers)
            {
                pokemon.Pokemon.RemoveAll(x => x.Health <= 0);
            }
            int num = 0;
            foreach (var trainer in trainers)
            {

                
                if (trainer.NumberOfBadges > num)
                {

                    num = trainer.NumberOfBadges;
                }

            }

            foreach (var trainer in trainers)
            {
                if (trainer.NumberOfBadges == num)
                {
                    Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemon.Count}");
                    
                }
            }
            foreach (var trainer in trainers)
            {
                if (trainer.NumberOfBadges != num)
                {
                    Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemon.Count}");
                }
            }
           

            
            
        }
    }
}
