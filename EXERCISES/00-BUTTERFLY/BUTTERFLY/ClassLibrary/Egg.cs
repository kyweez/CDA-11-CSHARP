using System;

namespace BUTTERFLY.ClassLibrary
{
    public class Egg : LifeCycleStage
    {
        /*********************************** FIELDS ***********************************/
        // None

        /******************************** CONSTRUCTORS ********************************/
        // None

        /********************************* PROPERTIES *********************************/
        // None

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     Prints on the stdout that an egg can't move and returns false.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("An egg can't move !");
            return false;
        }

        /// <summary>
        ///     Evolves the egg into a caterpillar and returns the new object.
        /// </summary>
        /// <returns>bool</returns>
        public override LifeCycleStage Evolve()
        {
            Console.WriteLine("Youhou I'm a caterpillar !");
            return new Caterpillar();
        }
    }
}