using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOO.ClassTest;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}
