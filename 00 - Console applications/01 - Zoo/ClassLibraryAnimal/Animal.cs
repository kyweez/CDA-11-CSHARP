using InterfaceLibrary;
using System;

namespace ClassLibraryAnimal
{
    public abstract class Animal : IMovable, IComparable, IComparable<Animal>
    {
        #region ############### FIELDS ###############
        private DateTime dateOfBirth;
        private bool isBornInZoo;
        #endregion

        #region ############### CONSTRUCTORS ###############
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
        #endregion

        #region ############### PROPERTIES ###############
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

            private set
            {
                isBornInZoo = value;
            }
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// This abstract method has to be implemented in children classes
        /// </summary>
        /// <returns>bool</returns>
        public abstract bool Move();

        /// <summary>
        /// This abstract method has to be implemented in children classes
        /// </summary>
        /// <returns>bool</returns>
        public abstract void Eat();

        /// <summary>
        /// Interface implementation : Compare the local instance date of birth with the input object date of birth
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>int</returns>
        public int CompareTo(object obj)
        {
            if (!(obj is Animal _animalToCompare))
                throw new ArgumentException("obj is not the same type as this instance", "obj");
            return DateOfBirth.CompareTo(_animalToCompare.DateOfBirth);
        }

        /// <summary>
        /// Interface implementation : Compare the local instance date of birth with the input object date of birth
        /// </summary>
        /// <param name="other">object</param>
        /// <returns>int</returns>
        public int CompareTo(Animal other)
        {
            return DateOfBirth.CompareTo(other.DateOfBirth);
        }
        #endregion
    }
}