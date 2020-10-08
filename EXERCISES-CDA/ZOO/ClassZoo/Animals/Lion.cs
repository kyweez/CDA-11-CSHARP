using System;

namespace ZOO
{
    public class Lion : Animal
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
            Console.WriteLine("The lion is eating !");
        }

        public override bool Move()
        {
            Console.WriteLine("The lion is flying, just kidding he is running !");
            return true;
        }
    }
}