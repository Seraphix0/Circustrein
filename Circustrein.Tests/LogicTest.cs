using System;
using Xunit;
using System.Collections.Generic;
using Circustrein;
using System.Linq;

namespace Circustrein.Tests
{
    public class LogicTest
    {
        [Fact]
        public void FoodChain()
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal(Consumption.Carnivore, 3),
                new Animal(Consumption.Herbivore, 2),
                new Animal(Consumption.Carnivore, 2),
                new Animal(Consumption.Herbivore, 3)
            };

            List<Wagon> wagons = new List<Wagon>
            {
                new Wagon(new Animal(Consumption.Carnivore, 3)),
                new Wagon(new Animal(Consumption.Herbivore, 2)),
                new Wagon(new Animal(Consumption.Carnivore, 2))
            };

            wagons[1].Animals.Add(new Animal(Consumption.Herbivore, 3));


            LogicDivision division = new LogicDivision(animals);
            Assert.True(wagons.SequenceEqual(division.Wagons));
        }
    }
}
