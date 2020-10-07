using System;

namespace BUTTERFLY
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
            Lepidoptera lepidoptereCutty = new Lepidoptera();
            Console.WriteLine("Egg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the egg");
            Console.ResetColor();
            Console.WriteLine("=========================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the egg");
            Console.ResetColor();
            Console.WriteLine("===========================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the caterpillar");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the caterpillar");
            Console.ResetColor();
            Console.WriteLine("===================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the chrysalis");
            Console.ResetColor();
            Console.WriteLine("===============================\n");
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the chrysalis");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to move the butterfly");
            Console.ResetColor();
            Console.WriteLine("===============================\n");
            lepidoptereCutty.Move();
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
            lepidoptereCutty.CurrentStage = butterflyCanfly;
            lepidoptereCutty.Move();
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's try to evolve the butterfly");
            Console.ResetColor();
            Console.WriteLine("=================================\n");
            lepidoptereCutty.Evolve();
            Console.WriteLine("\nEgg class         : " + lepidoptereCutty.ToString());
            Console.WriteLine("Egg stage class   : " + lepidoptereCutty.CurrentStage.ToString());
            Console.WriteLine("Egg date of birth : " + lepidoptereCutty.DateOfBirth);


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