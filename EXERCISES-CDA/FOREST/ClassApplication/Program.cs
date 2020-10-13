using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREST.ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************************** Spring tree creation *****************************/
            Tree springTree = new Tree(15000);
            springTree.AddLeaf(EnumColor.Green, EnumLeafShape.Oblong, 4);
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
            Console.WriteLine("WINTER IS COMING");
            for (int i = 0; i < springTree.Count; i++) //Count -> Propriete
            {
                Leaf f = springTree[i];
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("____________________________\n");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
