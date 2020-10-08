using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO.Utils.Script
{
    class ScriptClass
    {
        public static void Script()
        {
            Console.WriteLine("Once upon a time, in a Zoo, there were 2 rabbits, a lion and a parrot.\n");
            Console.WriteLine("  - The first rabbit was born in the Zoo on the 23/01/2020, he has small ears because he's the youngest animal");
            Console.WriteLine("  - The second rabbit was born in another Zoo on the 25/12/1980, he has huge ears because he's the oldest animal");
            Console.WriteLine("  - The lion is the king of the Zoo, he was born on the 31/12/2010 in another Zoo");
            Console.WriteLine("  - The parrot was born in the Zoo on 01/01/2011. Happy new year");

            List<Animal> animalTab = new List<Animal>();
            animalTab.Add(new Rabbit(DateTime.Parse("2020-01-23"), true, 1));
            animalTab.Add(new Rabbit(DateTime.Parse("1980-12-25"), false, 10));
            animalTab.Add(new Lion(DateTime.Parse("2010-12-31"), false));
            animalTab.Add(new Parrot(DateTime.Parse("2011-01-01"), true));

            Console.WriteLine("\nSummary :");
            for (int i = 0; i < animalTab.Count; i++)
            {
                Console.WriteLine($"Animal {i + 1} was born on the {animalTab[i].DateOfBirth:dd/MM/yyyy}");
            }
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("Damn it, the zoo is on fire ! We need to evacuate the animals :");
            foreach (Animal dontWannaBurn in animalTab)
            {
                dontWannaBurn.Move();
            }
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();
        }
    }
}
