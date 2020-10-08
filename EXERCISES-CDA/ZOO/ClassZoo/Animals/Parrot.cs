using System;

namespace ZOO
{
    public class Parrot : Animal, ITalkable
    {
        /***************************** ATTRIBUTES ****************************/
        // NONE

        /**************************** CONSTRUCTORS ***************************/
        // NONE

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/
        public void Eat()
        {
            Console.WriteLine("The parrot is eating !");
        }

        public override bool Move()
        {
            Console.WriteLine("The parrot is flying !");
            return true;
        }
        public void Talk()
        {
            Console.WriteLine("The parrot is calling for help !");
        }
    }
}