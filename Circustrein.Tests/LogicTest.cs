using System;
using Xunit;
using System.Collections.Generic;
using Circustrein;
using System.Linq;

namespace Circustrein.Tests
{
    public class LogicTest
    {
        /*
        Kudde's							
        H1 H3  H5 C1  C3 C5  Wagons Verdeling
        5	3	1	0	0	0	2	H5H3H1H1, H3H3H1H1H1
        0	0	3	1	3	2	6	C5,C5,C3H5,C3H5,C3H5,C1
        5	5	5	2	2	2	8	C5,C5,C3H5,C3H5,C1H5H3,C1H5H3,H5H3H1H1,H3H3H1H1H1
        */

        [Fact]
        public void FoodChain1()
        {
            List<Animal> animals = new List<Animal>();

            // Herbivores
            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 1));
            };

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 2));
            };

            animals.Add(new Animal(Consumption.Herbivore, 3));

            LogicDivision division = new LogicDivision(animals);
            Assert.True(division.Wagons.Count() == 2);
        }

        [Fact]
        public void FoodChain2()
        {
            List<Animal> animals = new List<Animal>();

            // Herbivores
            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 3));
            };

            // Carnivores
            animals.Add(new Animal(Consumption.Carnivore, 1));

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Consumption.Carnivore, 2));
            };

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Consumption.Carnivore, 3));
            };

            LogicDivision division = new LogicDivision(animals);
            Assert.True(division.Wagons.Count() == 6);
        }

        [Fact]
        public void FoodChain3()
        {
            List<Animal> animals = new List<Animal>();

            // Herbivores
            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 1));
            };

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 2));
            };

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Consumption.Herbivore, 3));
            };

            // Carnivores
            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Consumption.Carnivore, 1));
            };

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Consumption.Carnivore, 2));
            };

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Consumption.Carnivore, 3));
            };

            LogicDivision division = new LogicDivision(animals);
            Assert.True(division.Wagons.Count() == 8);
        }
    }
}
