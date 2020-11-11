using System;

namespace ClassLibraryButterfly
{
    public class Caterpillar : LifeCycleStage
    {
        #region ############### METHODS ###############
        /// <summary>
        ///     Prints on the stdout that the caterpillar is walking and returns true.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            Console.WriteLine("The caterpillar is walking");
            return true;
        }

        /// <summary>
        ///     Evolves the caterpillar into a chrysalis and returns the new object.
        /// </summary>
        /// <returns>bool</returns>
        public override LifeCycleStage Evolve()
        {
            Console.WriteLine("Youhou I'm a chrysalis !");
            return new Chrysalis();
        }
        #endregion
    }
}