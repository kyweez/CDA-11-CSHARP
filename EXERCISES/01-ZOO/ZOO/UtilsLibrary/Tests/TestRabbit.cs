using System;
using ZOO.ClassLibrary.Animals;

namespace ZOO.UtilsLibrary.Tests
{
    class TestRabbit
    {
        public static Rabbit InitializingRabbitWithNoParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a rabbit without parameter");
            Console.ResetColor();
            return new Rabbit();
        }

        public static Rabbit InitializingRabbitWithGoodParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a rabbit with good parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth       : 2005-12-01");
            Console.WriteLine("Born in zoo         : true");
            Console.WriteLine("Ears length (in cm) : 10");
            return new Rabbit(DateTime.Parse("2005-12-01"), true, 10);
        }
        public static Rabbit InitializingRabbitWithBadParameter_1()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a rabbit with bad parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth       : 2025-12-01");
            Console.WriteLine("Born in zoo         : true");
            Console.WriteLine("Ears length (in cm) : 10");
            return new Rabbit(DateTime.Parse("2025-12-01"), true, 10);
        }
        public static Rabbit InitializingRabbitWithBadParameter_2()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a rabbit with bad parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth       : 2005-12-01");
            Console.WriteLine("Born in zoo         : true");
            Console.WriteLine("Ears length (in cm) : 10");
            return new Rabbit(DateTime.Parse("2005-12-01"), true, -10);
        }

        public static void InitializingRabbits()
        {
            Rabbit firstRabbit = TestRabbit.InitializingRabbitWithNoParameter();
            Console.WriteLine("\nFirst rabbit date of birth  : " + firstRabbit.DateOfBirth);
            Console.WriteLine("First rabbit is born in zoo ? " + firstRabbit.IsBornInZoo);
            Console.WriteLine("First rabbit ears length    : " + firstRabbit.EarLengthCm);
            Console.WriteLine("\n---------------------------------------------------------");


            Rabbit secondRabbit = TestRabbit.InitializingRabbitWithGoodParameter();
            Console.WriteLine("\nSecond rabbit date of birth  : " + secondRabbit.DateOfBirth);
            Console.WriteLine("Second rabbit is born in zoo ? " + secondRabbit.IsBornInZoo);
            Console.WriteLine("Second rabbit ears length    : " + secondRabbit.EarLengthCm);
            Console.WriteLine("\n---------------------------------------------------------");


            Rabbit thirdRabbit = TestRabbit.InitializingRabbitWithBadParameter_1();
            Console.WriteLine("\nThird rabbit date of birth  : " + thirdRabbit.DateOfBirth);
            Console.WriteLine("Third rabbit is born in zoo ? " + thirdRabbit.IsBornInZoo);
            Console.WriteLine("Third rabbit ears length    : " + thirdRabbit.EarLengthCm);
            Console.WriteLine("\n---------------------------------------------------------");


            Rabbit fourthRabbit = TestRabbit.InitializingRabbitWithBadParameter_2();
            Console.WriteLine("\nFourth rabbit date of birth  : " + fourthRabbit.DateOfBirth);
            Console.WriteLine("Fourth rabbit is born in zoo ? " + fourthRabbit.IsBornInZoo);
            Console.WriteLine("Fourth rabbit ears length    : " + fourthRabbit.EarLengthCm);
            Console.WriteLine("\n---------------------------------------------------------");
        }

        public static void MovingRabbits()
        {
            Rabbit rabbit = TestRabbit.InitializingRabbitWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to move the rabbit :\n");
            Console.ResetColor();
            rabbit.Move();
        }

        public static void EatingRabbits()
        {
            Rabbit rabbit = TestRabbit.InitializingRabbitWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to feed the rabbit :\n");
            Console.ResetColor();
            rabbit.Eat();
        }

        public static void TestRabbitMethods()
        {
            TestRabbit.MovingRabbits();
            Console.WriteLine("\n---------------------------------------------------------");
            TestRabbit.EatingRabbits();
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}