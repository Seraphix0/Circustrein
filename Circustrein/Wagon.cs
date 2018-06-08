using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        public Wagon()
        {
            Animals = new List<Animal>();
            Capacity = 10;
        }

        public Wagon(Animal animal)
        {
            Animals = new List<Animal>();
            Animals.Add(animal);
            Capacity = 10 - animal.Size;
        }

        public List<Animal> Animals { get; set; }
        public int Capacity { get; set; }
    }
}
