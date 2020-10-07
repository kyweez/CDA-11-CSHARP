using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAPILLON
{
    public class Egg : LifeCycleStage
    {
        /*********************************** FIELDS ***********************************/

        /// None

        /******************************** CONSTRUCTORS ********************************/

        /// None

        /********************************* PROPERTIES *********************************/

        /// None

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     This method writes on the stdout that an egg can't move and returns false.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("An egg can't move !");
            return false;
        }

        /// <summary>
        ///     This method evolves the egg into a caterpillar and returns true.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Evolve(Lepidoptera _lepidoptera)
        {
            _lepidoptera.CurrentStage = new Caterpillar();
            return true;
        }
    }
}