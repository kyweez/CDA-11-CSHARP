using System;

namespace ZOO
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
            Console.WriteLine("PLEEEAAAASE FIREGUARDS, WE NEED HELP!");
        }
    }
}