using System;

namespace ClassLibraryButterfly
{
    public class Egg : LifeCycleStage
    {
        #region ############### METHODS ###############
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
        #endregion
    }
}