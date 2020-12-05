using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryCrateProduction_v2
{
    class CrateProduction
    {
        #region ############### PROPERTIES ###############
        public ProductionStatusEnum ProductionStatus
        {
            get;
            private set;
        }

        public string ProductionName
        {
            get;
            private set;
        }

        public DateTime ProductionStartDateTime
        {
            get;
            private set;
        }

        public int NumberOfValidCratesToProduce
        {
            get;
            private set;
        }

        public int CurrentNumberOfFaultyCrates
        {
            get;
            private set;
        }

        public int CurrentNumberOfValidCrates
        {
            get;
            private set;
        }

        public int HourlyOutputOfCrates
        {
            get;
            private set;
        }

        public Thread ProduceThread
        {
            get;
            private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public CrateProduction(string _productionName, int _numberOfValidCratesToProduce, int _hourlyOutputOfCrates)
        {
            ProductionStatus = 0;
            ProductionName = _productionName;
            NumberOfValidCratesToProduce = _numberOfValidCratesToProduce;
            HourlyOutputOfCrates = _hourlyOutputOfCrates;
            //Thread t = new Thread();
        }
        #endregion

        #region ############### EVENTS ###############
        #endregion

        #region ############### STATUS CHANGE METHODS ###############
        public bool StartProduction()
        {
            if (ProductionStatus != 0)
                return false;
            ProduceThread = new Thread(new ThreadStart(RunProduction));
            ProduceThread.Start();
            return true;
            
        }

        private void RunProduction()
        {
            int timeBetweenCrateCreation = (3600 * 60 * 60) / HourlyOutputOfCrates;

            while (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                Thread.Sleep(timeBetweenCrateCreation);
                CreateCrate();
            }
        }

        private void CreateCrate()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
        }


        #endregion

    }
}
