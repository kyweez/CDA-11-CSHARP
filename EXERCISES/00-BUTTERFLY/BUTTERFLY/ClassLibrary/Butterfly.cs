using System;

namespace BUTTERFLY.ClassLibrary
{
    public class Butterfly : LifeCycleStage
    {
        /********************************* ATTRIBUTES *********************************/
        private bool isFlying;

        /******************************** CONSTRUCTORS ********************************/
        public Butterfly() => isFlying = false;

        public Butterfly(bool _isFlying) => IsFlying = _isFlying;

        /********************************* PROPERTIES *********************************/
        public bool IsFlying
        {
            get => isFlying;

            set => isFlying = value;
        }

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     This method prints on the stdout if the butterfly is moving either by flying 
        ///     or walking. The the method returns true
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            if (IsFlying)
            {
                Console.WriteLine("The butterfly is flying");
                return true;
            }
            else
            {
                Console.WriteLine("The butterfly is walking");
                return true;
            }
        }

        /// <summary>
        ///     Prints on the stdout that a butterfly can't evolve and returns the same object
        /// </summary>
        /// <returns>bool</returns>
        public override LifeCycleStage Evolve()
        {
            Console.WriteLine("I can't evolve, do you want me to die ???");
            return this;
        }
    }
}