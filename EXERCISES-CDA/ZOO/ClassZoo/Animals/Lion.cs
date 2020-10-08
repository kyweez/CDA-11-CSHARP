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