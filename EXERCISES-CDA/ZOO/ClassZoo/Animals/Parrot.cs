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
            Console.WriteLine("OK guys, I'm a parrot and I can talk. But let's listen to the guard");
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}