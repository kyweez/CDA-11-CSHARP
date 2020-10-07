using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAPILLON
{
        public class Caterpillar : LifeCycleStage
    {
        /*********************************** FIELDS ***********************************/

        /// None

        /******************************** CONSTRUCTORS ********************************/

        /// None

        /********************************* PROPERTIES *********************************/

        /// None

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     This method writes on the stdout that an the caterpillar is moving and returns true.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("The caterpillar is walking");
            return true;
        }

        /// <summary>
        ///     This method evolves the caterpillar into a chrysalis and returns true.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Evolve(Lepidoptera _lepidoptera)
        {
            _lepidoptera.CurrentStage = new Chrysalis();
            return true;
        }
    }
}