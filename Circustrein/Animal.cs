using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Animal
    {
        public Animal(Consumption consumption, int size)
        {
            Consumption = consumption;

            // Map size
            if (size == 1)
            {
                Size = 1;
            }
            else if (size == 2)
            {
                Size = 3;
            }
            else if (size == 3)
            {
                Size = 5;
            }
        }

        public Consumption Consumption { get; set; }

        public int Size { get; set; }
    }
}
