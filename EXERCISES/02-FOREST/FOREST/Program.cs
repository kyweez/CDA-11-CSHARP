using FOREST.ClassLibrary;
using System;

namespace FOREST
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************************** Spring tree creation *****************************/
            Tree springTree = new Tree(15000);
            springTree.AddLeaf(EnumLeafColor.Green, EnumLeafShape.Oblong, 6);
            Console.WriteLine("\nPress any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

            /**************************** Print Tree information ****************************/
            Console.WriteLine(springTree.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

            /****************************** This is the Autumn ******************************/
            springTree.ChangeToAutumnColors();
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

            /**************************** Print Tree information ****************************/
            Console.WriteLine(springTree.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

            /******************************* Winter is coming *******************************/

            // This exemple has no sense, the only goal was to work on class indexer
            Console.WriteLine("WINTER IS COMING\n################\n");
            for (int i = springTree.Count - 1; i >= 0; i--)
                springTree.LeafFall(springTree[i]);
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

            /**************************** Print Tree information ****************************/
            Console.WriteLine("The tree is nude");
            Console.WriteLine(springTree.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}