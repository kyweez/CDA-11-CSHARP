using System;

namespace PAPILLON
{
    public class Chrysalis : LifeCycleStage
    {
        /*********************************** FIELDS ***********************************/

        /// None

        /******************************** CONSTRUCTORS ********************************/

        /// None

        /********************************* PROPERTIES *********************************/

        /// None

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     This method writes on the stdout that a chrysalis can't move and returns false.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("A chrysalis can't move !");
            return false;
        }

        /// <summary>
        ///     This method evolves the chrysalis into a butterfly and returns true.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Evolve(Lepidoptera _lepidoptera)
        {
            _lepidoptera.CurrentStage = new Butterfly();
            return true;
        }
    }
}