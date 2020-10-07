using System;

namespace PAPILLON
{
    public class Lepidoptera
    {
        /*********************************** FIELDS ***********************************/

        private readonly DateTime dateOfBirth;
        private LifeCycleStage currentStage;

        /******************************** CONSTRUCTORS ********************************/

        public Lepidoptera()
        {
            dateOfBirth = DateTime.Now;
            CurrentStage = new Egg();
        }

        public Lepidoptera(Lepidoptera _lepidoptera)
        {
            dateOfBirth = _lepidoptera.DateOfBirth;
            CurrentStage = _lepidoptera.CurrentStage;
        }

        /********************************* PROPERTIES *********************************/

        public DateTime DateOfBirth
        {
            get => default;
        }

        public LifeCycleStage CurrentStage { get; set; }

        /*********************************** METHODS **********************************/

        public bool Move()
        {
            return CurrentStage.Move();
        }

        public bool Evolve()
        {
            return CurrentStage.Evolve(this);
        }
    }
}