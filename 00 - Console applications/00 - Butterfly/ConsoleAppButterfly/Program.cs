using ClassLibraryButterfly;
using System;

namespace ConsoleAppButterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==================================================");
            Console.WriteLine("======                 START                ======");
            Console.WriteLine("==================================================\n");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Egg instanciation");
            Console.ResetColor();
            Console.WriteLine("=================\n");
            Lepidoptera lepidopteraCutty = new Lepidoptera();
            Console.WriteLine("Egg class         : " + lepidopteraCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidopteraCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidopteraCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the egg");
            Console.ResetColor();
            Console.WriteLine("=========================\n");
            lepidopteraCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the egg");
            Console.ResetColor();
            Console.WriteLine("===========================\n");
            lepidopteraCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidopteraCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidopteraCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidopteraCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the caterpillar");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidopteraCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the caterpillar");
            Console.ResetColor();
            Console.WriteLine("===================================\n");
            lepidopteraCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidopteraCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidopteraCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidopteraCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the chrysalis");
            Console.ResetColor();
            Console.WriteLine("===============================\n");
            lepidopteraCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the chrysalis");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidopteraCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidopteraCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidopteraCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidopteraCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the butterfly");
            Console.ResetColor();
            Console.WriteLine("===============================\n");
            lepidopteraCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to make fly the butterfly");
            Console.ResetColor();
            Console.WriteLine("===================================\n");
            Butterfly butterflyCanfly = new Butterfly();
            butterflyCanfly.IsFlying = true;
            lepidopteraCutty.CurrentStage = butterflyCanfly;
            lepidopteraCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the butterfly");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidopteraCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidopteraCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidopteraCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidopteraCutty.DateOfBirth);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n==================================================");
            Console.WriteLine("======                  END                 ======");
            Console.WriteLine("==================================================\n");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to close the window\n");
            Console.ReadKey();
        }
    }
}