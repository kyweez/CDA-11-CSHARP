using System;

namespace ClassLibraryButterfly
{
    public class Chrysalis : LifeCycleStage
    {
        #region ############### METHODS ###############
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
        ///     This method evolves the chrysalis into a butterfly and returns the new object.
        /// </summary>
        /// <returns>bool</returns>
        public override LifeCycleStage Evolve()
        {
            Console.WriteLine("Youhou I'm a butterfly !");
            return new Butterfly();
        }
        #endregion
    }
}