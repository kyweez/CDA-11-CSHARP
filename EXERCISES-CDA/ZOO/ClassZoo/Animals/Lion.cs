using System;

namespace ZOO
{
    public class Lion : Animal
    {
        /***************************** ATTRIBUTES ****************************/
        // NONE

        /**************************** CONSTRUCTORS ***************************/
        public Lion() : base()
        {
        }

        public Lion(DateTime _dateOfBirth, bool _isBornInZoo) : base(_dateOfBirth, _isBornInZoo)
        {
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/

        /// <summary>
        /// Redifining Eat method for the Lion. The method doesn't return anything and print something on the stdout
        /// </summary>
        /// <returns>void</returns>
        public override void Eat()
        {
            Console.WriteLine("The lion is eating !");
        }

        /// <summary>
        /// Redifining Move method for the Lion. The method returns a boolean and print something on the stdout
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("The lion is flying, just kidding he is running !");
            return true;
        }
    }
}