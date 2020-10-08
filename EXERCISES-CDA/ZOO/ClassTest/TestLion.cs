using System;

namespace ZOO.ClassTest
{
    class TestLion
    {
        public static Lion InitializingLionWithNoParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a lion without parameter");
            Console.ResetColor();
            return new Lion();
        }

        public static Lion InitializingLionWithGoodParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a lion with good parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth : 2005-12-01");
            Console.WriteLine("Born in zoo   : true");
            return new Lion(DateTime.Parse("2005-12-01"), true);
        }
        public static Lion InitializingLionWithBadParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a lion with bad parameters");
            Console.ResetColor();
            Console.WriteLine("Date of birth : 2025-12-01");
            Console.WriteLine("Born in zoo   : true");
            return new Lion(DateTime.Parse("2025-12-01"), true);
        }

        public static void InitializingLions()
        {
            Lion firstLion = TestLion.InitializingLionWithNoParameter();
            Console.WriteLine("\nFirst lion date of birth  : " + firstLion.DateOfBirth);
            Console.WriteLine("First lion is born in zoo ? " + firstLion.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");


            Lion secondLion = TestLion.InitializingLionWithGoodParameter();
            Console.WriteLine("\nSecond lion date of birth  : " + secondLion.DateOfBirth);
            Console.WriteLine("Second lion is born in zoo ? " + secondLion.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");


            Lion thirdLion = TestLion.InitializingLionWithBadParameter();
            Console.WriteLine("\nThird lion date of birth  : " + thirdLion.DateOfBirth);
            Console.WriteLine("Third lion is born in zoo ? " + thirdLion.IsBornInZoo);
            Console.WriteLine("\n---------------------------------------------------------");
        }

        public static void MovingLions()
        {
            Lion lion = TestLion.InitializingLionWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to move the lion :\n");
            Console.ResetColor();
            lion.Move();
        }

        public static void EatingLions()
        {
            Lion lion = TestLion.InitializingLionWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to feed the lion :\n");
            Console.ResetColor();
            lion.Eat();
        }

        public static void TestLionMethods()
        {
            TestLion.MovingLions();
            Console.WriteLine("\n---------------------------------------------------------");
            TestLion.EatingLions();
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}