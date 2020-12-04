using ClassLibraryCooking;
using System;

namespace ConsoleAppThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake bananaBread = new Cake();
            bananaBread.InformUserAboutInflation += new Cake.DelegateInflateDone(BananaBread_InformUserAboutInflation);
            bananaBread.InformUserAboutCook += new Cake.DelegateCookDone(BananaBread_InformUserAboutInflation);
            bananaBread.Finish();
        }

        private static void BananaBread_InformUserAboutInflation(int size)
        {
            Console.WriteLine($"The cake is inflated at {size}%");        
        }
    }
}
