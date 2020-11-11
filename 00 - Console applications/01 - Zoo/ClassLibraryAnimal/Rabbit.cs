using System;

namespace ClassLibraryAnimal
{
    public class Rabbit : Animal
    {
        #region ############### FIELDS ###############
        private int earLengthCm;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public Rabbit() : base()
        {
            earLengthCm = 0;
        }

        public Rabbit(DateTime _dateOfBirth, bool _isBornInZoo, int _earLengthCm) : base(_dateOfBirth, _isBornInZoo)
        {
            EarLengthCm = _earLengthCm;
        }
        #endregion

        #region ############### PROPERTIES ###############
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
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// Redifining Eat method for the Rabbit. The method doesn't return anything and print something on the stdout
        /// </summary>
        /// <returns>void</returns>
        public override void Eat()
        {
            Console.WriteLine("The rabbit is eating !");
        }

        /// <summary>
        /// Redifining Move method for the Rabbit. The method returns a boolean and print something on the stdout
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("The rabbit is running !");
            return true;
        }
        #endregion
    }
}