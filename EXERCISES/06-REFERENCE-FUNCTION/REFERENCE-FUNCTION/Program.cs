using System;

namespace REFERENCE_FUNCTION
{
    class Program
    {
        /// <summary>
        ///     This methods returns the sum of 2 numbers and store the substraction in another out number (by reference)
        /// </summary>
        /// <param name="_a">double</param>
        /// <param name="_b">double</param>
        /// <param name="_substraction">out double</param>
        /// <returns></returns>
        public static double AddSub(double _a, double _b, out double _substraction)
        {
            _substraction = _a - _b;
            return _a + _b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Argument given as a reference :\n");

            double a = 50;
            double b = 20;
            double addition;
            double substraction;

            addition = AddSub(a, b, out substraction);

            Console.WriteLine($"a value : {a}");
            Console.WriteLine($"b value : {b}\n");
            Console.WriteLine($"a + b   : {addition}");
            Console.WriteLine($"a - b   : {substraction}");

        }
    }
}
