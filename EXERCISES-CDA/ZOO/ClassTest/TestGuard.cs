using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO.ClassTest
{
    class TestGuard
    {
        public static Guard InitializingGuardWithNoParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a guard without parameter");
            Console.ResetColor();
            return new Guard();
        }

        public static Guard InitializingGuardWithGoodParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a guard with good parameters");
            Console.ResetColor();
            Console.WriteLine("Last name     : DOE");
            Console.WriteLine("First name    : John");
            Console.WriteLine("Date of birth : 2005-12-01");
            return new Guard("DOE", "John", DateTime.Parse("2005-12-01"));
        }
        public static Guard InitializingGuardWithBadParameter()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nInitialize a guard with bad parameters");
            Console.ResetColor();
            Console.WriteLine("Last name     : DOE");
            Console.WriteLine("First name    : John");
            Console.WriteLine("Date of birth : 2025-12-01");
            return new Guard("DOE", "John", DateTime.Parse("2025-12-01"));
        }

        public static void InitializingGuards()
        {
            Guard firstGuard = TestGuard.InitializingGuardWithNoParameter();
            Console.WriteLine("\nFirst guard last name     : " + firstGuard.LastName);
            Console.WriteLine("First guard first name    : " + firstGuard.FirstName);
            Console.WriteLine("First guard date of birth : " + firstGuard.DateOfBirth);
            Console.WriteLine("\n---------------------------------------------------------");


            Guard secondGuard = TestGuard.InitializingGuardWithGoodParameter();
            Console.WriteLine("\nSecond guard last name     : " + secondGuard.LastName);
            Console.WriteLine("Second guard first name    : " + secondGuard.FirstName);
            Console.WriteLine("Second guard date of birth : " + secondGuard.DateOfBirth);
            Console.WriteLine("\n---------------------------------------------------------");


            Guard thirdGuard = TestGuard.InitializingGuardWithBadParameter();
            Console.WriteLine("\nThird guard last name     : " + thirdGuard.LastName);
            Console.WriteLine("Third guard first name    : " + thirdGuard.FirstName);
            Console.WriteLine("Third guard date of birth : " + thirdGuard.DateOfBirth);
            Console.WriteLine("\n---------------------------------------------------------");
        }

        public static void MovingGuards()
        {
            Guard guard = TestGuard.InitializingGuardWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to move the guard :\n");
            Console.ResetColor();
            guard.Move();
        }

        public static void TalkingGuards()
        {
            Guard guard = TestGuard.InitializingGuardWithGoodParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nLet's try to talk with the guard :\n");
            Console.ResetColor();
            guard.Talk();
        }

        public static void TestGuardMethods()
        {
            TestGuard.MovingGuards();
            Console.WriteLine("\n---------------------------------------------------------");
            TestGuard.TalkingGuards();
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}
