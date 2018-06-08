using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circustrein
{
    public class LogicDivision
    {
        public LogicDivision(List<Animal> manifest)
        {
            Wagons = ProcessManifest(manifest);
        }

        public List<Wagon> Wagons;

        public List<Wagon> ProcessManifest(List<Animal> manifest)
        {
            List<Wagon> wagons = new List<Wagon>
            {
                new Wagon()
            };
            
            foreach (Animal animal in manifest.ToList())
            {
                bool wagonAvailable = false;
                foreach (Wagon wagon in wagons.ToList())
                {
                    // Check if carnivore of bigger size exists in wagon
                    if (wagon.Animals.Find(x => (x.Consumption == Consumption.Carnivore) && (x.Size >= animal.Size)) == null)
                    {
                        // Check if self is carnivore of bigger size than existing load in wagon
                        if (animal.Consumption == Consumption.Carnivore)
                        {
                            if (wagon.Animals.Find(x => x.Size <= animal.Size) != null)
                            {
                                continue;
                            }
                        }

                        if (wagon.Capacity >= animal.Size)
                        {
                            wagon.Animals.Add(animal);
                            wagon.Capacity -= animal.Size;
                            wagonAvailable = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                if (!wagonAvailable)
                {
                    wagons.Add(new Wagon(animal));
                }
            }

            return wagons;
        }
    }
}
