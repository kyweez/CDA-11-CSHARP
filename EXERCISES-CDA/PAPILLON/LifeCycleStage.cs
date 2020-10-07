namespace PAPILLON
{
    public abstract class LifeCycleStage
    {
        /// <summary>
        ///     This abstract method call needs to be defined by children classes
        ///     It's called in order to move the lepidoptera
        /// </summary>
        /// <returns>bool</returns>
        public abstract bool Move();

        /// <summary>
        /// This abstract method call needs to be defined by children classes
        /// It's called in order to evolve the lepidoptera
        /// </summary>
        public abstract LifeCycleStage Evolve();
    }
}