using System;
using System.Collections;
using System.Collections.Generic;
using ZOO.ClassLibrary.Animals;
using ZOO.ClassLibrary.Employees;

namespace ZOO.UtilsLibrary.Script
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

            Console.WriteLine("It's a huge mess, we need the zoo guardian to arrange animals from older to younger");
            Guard georges = new Guard("O'MALLEY", "Georges", DateTime.Parse("1970-12-01"));
            Console.WriteLine("But, by the way, here is the guard :");
            Console.WriteLine("Guard last name     : " + georges.LastName);
            Console.WriteLine("Guard first name    : " + georges.FirstName);
            Console.WriteLine("Guard date of birth : " + georges.DateOfBirth.ToString("dd / MM / yyyy"));
            Console.WriteLine("\nSuddenly, " + georges.FirstName + " shouts :\n");
            georges.Talk();
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("Animal are sorted by " + georges.FirstName);
            animalTab.Sort();
            Console.WriteLine("\nSummary of the new order:");
            for (int i = 0; i < animalTab.Count; i++)
            {
                Console.WriteLine($"Animal {i + 1} was born on the {animalTab[i].DateOfBirth:dd/MM/yyyy}");
            }
            Console.WriteLine("\nAnimals can finally move out :");
            foreach (Animal dontWannaBurn in animalTab)
            {
                dontWannaBurn.Move();
            }
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("Well, all animals are safe ! Now " + georges.FirstName + " needs to leave though \n");
            georges.Move();
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("Lets try to stop the fire and ask for help... Can we count on the parrot ?\n");
            string sos = "PLEASE, CALL THE FIREGUARDS";
            foreach (Animal canHeTalk in animalTab)
            {
                if (canHeTalk is Parrot theNoisyParrot)
                {
                    Console.Write("Parrot : ");
                    theNoisyParrot.Talk(sos);
                    Console.Write($"{georges.FirstName} : ");
                    georges.Talk($"He's right {sos}");
                }
            }
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("It's time to feed the animals :");
            foreach (Animal wannaEatTheParrot in animalTab)
            {
                wannaEatTheParrot.Eat();
            }
            Console.WriteLine("\nPress any key to continue the story...\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();

            Console.WriteLine("Fireguards finally came, the zoo is safe, let's sing a song !\n");
            ArrayList parrotAndGeorge = new ArrayList();
            parrotAndGeorge.Add(animalTab[2]);
            parrotAndGeorge.Add(georges);
            string song = "Ah Ah Ah staying aliiiiive !!!";
            foreach (Object singer in parrotAndGeorge)
            {
                if (singer is Parrot theNoisyParrot)
                {
                    Console.Write("Parrot : ");
                    theNoisyParrot.Talk(song);
                }
                else if (singer is Guard georgesWannaBeMadonna)
                {
                    Console.Write($"{georges.FirstName} : ");
                    georgesWannaBeMadonna.Talk(song);
                }
            }
            Console.WriteLine("\nPress any key to close the program\n");
            Console.WriteLine("......................................\n");
            Console.ReadKey();
        }
    }
}