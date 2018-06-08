using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class LogicManifest
    {
        public LogicManifest ()
        {
            int[] userInput = GetUserInput();
            Animals = GetAnimalManifest(userInput[0], userInput[1]);
        }

        public List<Animal> Animals { get; set; }

        public List<Animal> GetAnimalManifest(int herbivores, int carnivores)
        {
            List<Animal> animals = new List<Animal>();
            animals.AddRange(GenerateAnimals(herbivores, Consumption.Herbivore));
            animals.AddRange(GenerateAnimals(carnivores, Consumption.Carnivore));

            return animals;
        }

        public List<Animal> GenerateAnimals(int amount, Consumption consumption)
        {
            Random rand = new Random();
            List<Animal> animals = new List<Animal>();

            if (consumption == Consumption.Herbivore)
            {
                for (int i = 0; i < 5; i++)
                {
                    animals.Add(new Animal(consumption, 1));
                    animals.Add(new Animal(consumption, 2));
                    animals.Add(new Animal(consumption, 3));
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    animals.Add(new Animal(consumption, 1));
                    animals.Add(new Animal(consumption, 2));
                    animals.Add(new Animal(consumption, 3));
                }
            }

            /*
            for (int i = 0; i < amount; i++)
            {
                animals.Add(new Animal(consumption, rand.Next(1, 4)));
            }
            */

            return animals;
        }

        public int[] GetUserInput()
        {
            Console.WriteLine("Amount of herbivores to process:");
            int herbivores = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Amount of carnivores to process:");
            int carnivores = Convert.ToInt16(Console.ReadLine());

            return new int[2] { herbivores, carnivores };
        }
    }
}
