using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit lapin1 = new Rabbit();
            Rabbit lapin2 = new Rabbit(DateTime.Parse("2025-05-31"), true, 10);
            Console.WriteLine("DATE     : " + lapin1.DateOfBirth);
            Console.WriteLine("BORN     : " + lapin1.IsBornInZoo);
            Console.WriteLine("LONGUEUR : " + lapin1.EarLengthCm);
            Console.ReadKey();            
            Console.WriteLine("DATE     : " + lapin2.DateOfBirth);
            Console.WriteLine("BORN     : " + lapin2.IsBornInZoo);
            Console.WriteLine("LONGUEUR : " + lapin2.EarLengthCm);
            Console.ReadKey();

        }
    }
}
