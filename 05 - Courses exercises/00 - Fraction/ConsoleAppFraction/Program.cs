using ClassLibraryFraction;
using System;
using System.Reflection;

namespace ConsoleAppFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor test
            // Case numerator = 10 & denominator = 12
            try
            {
                Fraction f0 = new Fraction(10, 12);
                Console.WriteLine("f0 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f0 can't be instanciated : " + e.Message);
            }

            // Case numerator = 0 & denominator = 12
            try
            {
                Fraction f1 = new Fraction(0, 12);
                Console.WriteLine("f1 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f1 can't be instanciated : " + e.Message);
            }

            // Case numerator = 10 & denominator = 0
            try
            {
                Fraction f2 = new Fraction(10, 0);
                Console.WriteLine("f2 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f2 can't be instanciated : " + e.Message);
            }

            // Case numerator = 0 & denominator = 0
            try
            {
                Fraction f3 = new Fraction(0, 0);
                Console.WriteLine("f3 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f3 can't be instanciated : " + e.Message);
            }

            // Case numerator = 0 & denominator = -0
            try
            {
                Fraction f4 = new Fraction(0, -0);
                Console.WriteLine("f4 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f4 can't be instanciated : " + e.Message);
            }

            // Case numerator = 0 & denominator = -10
            try
            {
                Fraction f5 = new Fraction(0, -10);
                Console.WriteLine("f5 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f5 can't be instanciated : " + e.Message);
            }

            // Case numerator = -12 & denominator = -10
            try
            {
                Fraction f6 = new Fraction(-12, -10);
                Console.WriteLine("f6 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f6 can't be instanciated : " + e.Message);
            }

            // Case numerator = 12
            try
            {
                Fraction f7 = new Fraction(12);
                Console.WriteLine("f7 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f7 can't be instanciated : " + e.Message);
            }

            // Case numerator = 0
            try
            {
                Fraction f8 = new Fraction(0);
                Console.WriteLine("f8 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f8 can't be instanciated : " + e.Message);
            }

            // Case numerator = -10
            try
            {
                Fraction f9 = new Fraction(-10);
                Console.WriteLine("f9 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f9 can't be instanciated : " + e.Message);
            }

            // Case numerator = -0
            try
            {
                Fraction f10 = new Fraction(-0);
                Console.WriteLine("f10 is well instanciated");
            }
            catch (Exception e)
            {
                Console.WriteLine("f10 can't be instanciated : " + e.Message);
            }
            #endregion
            
            #region Reverse test
            // Case numerator = 10 & denominator = 12
            try
            {
                Fraction f11 = new Fraction(10, 12);
                f11.Reverse();
                Console.WriteLine($"f11 is well reversed");
            }
            catch (Exception e)
            {
                Console.WriteLine("f11 can't be reversed : " + e.Message);
            }

            // Case numerator = 0 & denominator = 12
            try
            {
                Fraction f12 = new Fraction(0, 12);
                f12.Reverse();
                Console.WriteLine($"f12 is well reversed");
            }
            catch (Exception e)
            {
                Console.WriteLine("f12 can't be reversed : " + e.Message);
            }
            #endregion

            #region Evaluate test
            // Case numerator = 20 & denominator = 2 & no modification of the private field denominator
            try
            {
                Fraction f14 = new Fraction(20, 2);
                Console.WriteLine($"f14 evaluation worked. Result : {f14.Evaluate()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("f14 can't be evaluated : " + e.Message);
            }

            // Case numerator = 20 & denominator = 18 & no modification of the private field denominator
            try
            {
                Fraction f15 = new Fraction(20, 18);
                Console.WriteLine($"f15 evaluation worked. Result : {f15.Evaluate()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("f15 can't be evaluated : " + e.Message);
            }

            // Case numerator = 20 & denominator = 18 & private field denominator set to 0
            try
            {
                Fraction f16 = new Fraction(20, 18);
                typeof(Fraction).GetField("denominator", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(f16, 0);
                Console.WriteLine($"f15 evaluation worked. Result : {f16.Evaluate()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("f16 can't be evaluated : " + e.Message);
            }
            #endregion
        }
    }
}