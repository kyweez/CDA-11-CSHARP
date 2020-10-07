using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPILLON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("==                     START                    ==");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Egg instanciation");
            Console.WriteLine("=================\n");
            Lepidoptera lepidoptereCutty = new Lepidoptera();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to move the egg");
            Console.WriteLine("=========================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to evolve the egg");
            Console.WriteLine("===========================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to move the caterpillar");
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to evolve the caterpillar");
            Console.WriteLine("===================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to move the chrysalis");
            Console.WriteLine("===============================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to evolve the chrysalis");
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to move the butterfly");
            Console.WriteLine("===============================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to make fly the butterfly");
            Console.WriteLine("===================================\n");
            Butterfly butterflyCanfly = new Butterfly();
            butterflyCanfly.IsFlying = true;
            lepidoptereCutty.CurrentStage = butterflyCanfly;
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Let's try to evolve the butterfly");
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
        }
    }
}
