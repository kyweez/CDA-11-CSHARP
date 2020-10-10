using System;

namespace ZOO.ClassTest
{
    class TestAllClasses
    {
        public static void All()
        {
            Console.WriteLine("TEST 1 : Guards initialization");
            Console.WriteLine("______________________________\n");
            TestGuard.InitializingGuards();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 2 : Guards methods");
            Console.WriteLine("______________________________\n");
            TestGuard.TestGuardMethods();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 3 : Lions initialization");
            Console.WriteLine("______________________________\n");
            TestLion.InitializingLions();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 4 : Lions methods");
            Console.WriteLine("______________________________\n");
            TestLion.TestLionMethods();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 5 : Parrots initialization");
            Console.WriteLine("______________________________\n");
            TestParrot.InitializingParrots();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 6 : Parrots methods");
            Console.WriteLine("______________________________\n");
            TestParrot.TestParrotMethods();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 7 : Rabbits initialization");
            Console.WriteLine("______________________________\n");
            TestRabbit.InitializingRabbits();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TEST 8 : Rabbits methods");
            Console.WriteLine("______________________________\n");
            TestRabbit.TestRabbitMethods();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}