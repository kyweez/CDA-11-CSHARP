using System;
using ZOO.InterfaceLibrary;

namespace ZOO.ClassLibrary.Animals
{
    public class Parrot : Animal, ITalkable
    {
        /***************************** ATTRIBUTES ****************************/
        // NONE

        /**************************** CONSTRUCTORS ***************************/
        public Parrot() : base()
        {
        }

        public Parrot(DateTime _dateOfBirth, bool _isBornInZoo) : base(_dateOfBirth, _isBornInZoo)
        {
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/

        /// <summary>
        /// Redifining Eat method for the PArrot. The method doesn't return anything and print something on the stdout
        /// </summary>
        /// <returns>void</returns>
        public override void Eat()
        {
            Console.WriteLine("The parrot is eating !");
        }

        /// <summary>
        /// Redifining Move method for the Parrot. The method returns a boolean and print something on the stdout
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("The parrot is flying !");
            return true;
        }

        /// <summary>
        /// Redifining Talk method for the Parrot. The method returns a void and print something on the stdout
        /// </summary>
        /// <returns>void</returns>
        public void Talk()
        {
            Console.WriteLine("OK guys, I'm a parrot and I can talk. But let's listen to the guard");
        }

        /// <summary>
        /// Redifining Talk method for the Parrot with a parameter. The method returns a void and print something on the stdout
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>void</returns>
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}