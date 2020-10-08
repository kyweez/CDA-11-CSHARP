using System;

namespace ZOO.ClassTest
{
    class TestParrot
    {
        public static Parrot InitializingParrotWithNoParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a parrot without parameter");
            Console.ResetColor();
            return new Parrot();
        }

        public static Parrot InitializingParrotWithGoodParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a parrot with good parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth : 2005-12-01");
            Console.WriteLine("Born in zoo   : true");
            return new Parrot(DateTime.Parse("2005-12-01"), true);
        }
        public static Parrot InitializingParrotWithBadParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a parrot with bad parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth : 2025-12-01");
            Console.WriteLine("Born in zoo   : true");
            return new Parrot(DateTime.Parse("2025-12-01"), true);
        }

        public static void InitializingParrots()
        {
            Parrot firstParrot = TestParrot.InitializingParrotWithNoParameter();
            Console.WriteLine("\nFirst parrot date of birth  : " + firstParrot.DateOfBirth);
            Console.WriteLine("First parrot is born in zoo ? " + firstParrot.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");


            Parrot secondParrot = TestParrot.InitializingParrotWithGoodParameter();
            Console.WriteLine("\nSecond parrot date of birth  : " + secondParrot.DateOfBirth);
            Console.WriteLine("Second parrot is born in zoo ? " + secondParrot.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");


            Parrot thirdParrot = TestParrot.InitializingParrotWithBadParameter();
            Console.WriteLine("\nThird parrot date of birth  : " + thirdParrot.DateOfBirth);
            Console.WriteLine("Third parrot is born in zoo ? " + thirdParrot.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");
        }

        public static void MovingParrots()
        {
            Parrot parrot = TestParrot.InitializingParrotWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to move the parrot :\n");
            Console.ResetColor();
            parrot.Move();
        }

        public static void EatingParrots()
        {
            Parrot parrot = TestParrot.InitializingParrotWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to feed the parrot :\n");
            Console.ResetColor();
            parrot.Eat();
        }

        public static void TalkingParrots()
        {
            Parrot parrot = TestParrot.InitializingParrotWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to talk with the parrot :\n");
            Console.ResetColor();
            parrot.Talk();
        }

        public static void TestParrotMethods()
        {
            TestParrot.MovingParrots();
            Console.WriteLine("\n---------------------------------------------------------");
            TestParrot.TalkingParrots();
            Console.WriteLine("\n---------------------------------------------------------");
            TestParrot.EatingParrots();
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}