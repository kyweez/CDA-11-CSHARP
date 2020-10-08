using System;

namespace ZOO
{
    public abstract class Animal : IMovable
    {
        /***************************** ATTRIBUTES ****************************/
        private DateTime dateOfBirth;
        private bool isBornInZoo;

        /**************************** CONSTRUCTORS ***************************/
        protected Animal()
        {
            dateOfBirth = DateTime.Now;
            isBornInZoo = false;
        }

        protected Animal(DateTime _dateOfBirth, bool _isBornInZoo)
        {
            DateOfBirth = _dateOfBirth;
            isBornInZoo = _isBornInZoo;
        }

        /***************************** PROPERTIES ****************************/
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = DateTime.Compare(value, DateTime.Now) < 1 ? value : DateTime.Now;
            }
        }

        public bool IsBornInZoo
        {
            get
            {
                return isBornInZoo;
            }

            set
            {
                isBornInZoo = value;
            }
        }

        /****************************** METHODS ******************************/
        public abstract bool Move();
    }
}