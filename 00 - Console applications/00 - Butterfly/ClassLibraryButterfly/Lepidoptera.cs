using System;

namespace ClassLibraryButterfly
{
    public class Lepidoptera
    {
        #region ############### FIELDS ###############
        private DateTime dateOfBirth;
        private LifeCycleStage currentStage;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public Lepidoptera()
        {
            dateOfBirth = DateTime.Now;
            currentStage = new Egg();
        }

        public Lepidoptera(Lepidoptera _lepidoptera)
        {
            dateOfBirth = _lepidoptera.DateOfBirth;
            currentStage = _lepidoptera.CurrentStage;

        }
        #endregion

        #region ############### PROPERTIES ###############
        public DateTime DateOfBirth
        {
            get => dateOfBirth;

        }

        public LifeCycleStage CurrentStage
        {
            get => currentStage;

            set => currentStage = value;
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// Move the lepidopteria (if it can) and returns a boolean
        /// </summary>
        /// <returns>bool</returns>
        public bool Move()
        {
            return CurrentStage.Move();
        }

        /// <summary>
        /// Evolve the lepidopteria to its next evolution stage (unless it's a butterfly)
        /// </summary>
        /// <returns>LifeCycleStage</returns>
        public LifeCycleStage Evolve()
        {
            return CurrentStage = CurrentStage.Evolve();
        }
        #endregion
    }
}