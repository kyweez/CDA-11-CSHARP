using System;

namespace ZOO
{
    public class Rabbit : Animal
    {
        /***************************** ATTRIBUTES ****************************/
        private int earLengthCm;

        /**************************** CONSTRUCTORS ***************************/
        public Rabbit() : base()
        {
            earLengthCm = 0;
        }

        public Rabbit(DateTime _dateOfBirth, bool _isBornInZoo, int _earLengthCm) : base(_dateOfBirth, _isBornInZoo)
        {
            EarLengthCm = _earLengthCm;
        }

        /***************************** PROPERTIES ****************************/
        public int EarLengthCm
        {
            get
            {
                return earLengthCm;
            }

            set
            {
                earLengthCm = value > 0 ? value : 0;
            }
        }


        /****************************** METHODS ******************************/
        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public override bool Move()
        {
            throw new System.NotImplementedException();
        }
    }
}