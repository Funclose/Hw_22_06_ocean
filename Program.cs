using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22_06_ocean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SeaCreature> creatures = new List<SeaCreature>()
            {
                new SeaCreature("Dolphin", "Tursiops truncatus", "Tropical and temperate oceans"),
                new SeaCreature("Sea Turtle", "Cheloniidae", "Tropical and subtropical oceans"),
                new SeaCreature("Octopus", "Octopoda", "All oceans, especially coral reefs")
            };
            Oceanarium oceanarium = new Oceanarium("Marine world", creatures);

            Console.WriteLine($"Welcome to {oceanarium.Name}");
            Console.WriteLine($"all marine creature: ");

            foreach(SeaCreature creature in creatures) 
            {
                Console.WriteLine(creature);
            }

        }
    }
}
