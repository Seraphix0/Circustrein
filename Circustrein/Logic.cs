using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Logic
    {
        private LogicManifest manifest;
        private LogicDivision division;

        public Logic ()
        {
            manifest = new LogicManifest();
            division = new LogicDivision(manifest.Animals);

            PrintDivision(division.Wagons);
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey();
        }

        public void PrintDivision(List<Wagon> division)
        {
            int wagoncount = 0;
            foreach (Wagon wagon in division)
            {
                Console.WriteLine($"Wagon {wagoncount}");
                wagoncount += 1;

                int animalcount = 0;
                foreach (Animal animal in wagon.Animals)
                {
                    string sizeName = "";
                    if (animal.Size == 1)
                    {
                        sizeName = "Small";
                    }
                    else if (animal.Size == 3)
                    {
                        sizeName = "Medium";
                    }
                    else if (animal.Size == 5)
                    {
                        sizeName = "Large";
                    }

                    Console.WriteLine($"- Animal {animalcount} | {animal.Consumption.ToString()} | {sizeName}");
                    animalcount += 1;
                }
            }
        }
    }
}
