using ClassLibraryPerson;
using System;

namespace ConsoleAppMajorityEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("Roger");
                p.SpecificLifeStage += P_SpecificLifeStage;

                for (int i = 0; i < 20; i++)
                {
                    p.GettingOlder();
                    Console.WriteLine($"{p.Name} is {p.Age} years old");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"This program didn't work : {e}");
            }
        }

        private static void P_SpecificLifeStage(string _lifeStage)
        {
            Console.WriteLine(_lifeStage);       
        }
    }
}