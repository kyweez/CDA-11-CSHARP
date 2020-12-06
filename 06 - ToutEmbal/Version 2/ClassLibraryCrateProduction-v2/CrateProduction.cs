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
            ProductionStatusChange += CrateProduction_ProductionStatusChange;
        }
        #endregion

        #region ############### EVENTS ###############
        public delegate void DelegateProduction(CrateProduction sender); //A voir si on laisse le sender
        public event DelegateProduction ProductionStatusChange;
        public delegate void DelegateCreatedCrate(int crateNumber);
        public event DelegateCreatedCrate FaultyCrateAdded;
        public event DelegateCreatedCrate ValidCrateAdded;



        private void CrateProduction_ProductionStatusChange(CrateProduction sender)
        {
            if (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                ProduceThread = new Thread(new ThreadStart(RunProduction));
                ProduceThread.Start();
            }
        }
        #endregion

        #region ############### METHODS ###############
        private void CreateCrate()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (!isFinished())
            {
                if (randomNumber > 2 && CurrentNumberOfValidCrates < NumberOfValidCratesToProduce)
                {
                    ValidCrateAdded(++CurrentNumberOfValidCrates);
                    if (isFinished())
                        ChangeStatusToFinished();
                }
                else
                    FaultyCrateAdded(++CurrentNumberOfFaultyCrates);
            }
        }

        private bool isFinished()
        {
            return (CurrentNumberOfValidCrates == NumberOfValidCratesToProduce);
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
        #endregion

        #region ############### STATUS CHANGE METHODS ###############
        private void ChangeStatusToFinished()
        {
            if (ProductionStatus != ProductionStatusEnum.notStarted)
            {
                ProductionStatus = ProductionStatusEnum.finished;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

        private void ChangeStatusToPaused()
        {
            if (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                ProductionStatus = ProductionStatusEnum.paused;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

        private void ChangeStatusToRestarted()
        {
            if (ProductionStatus == ProductionStatusEnum.paused)
            {
                ProductionStatus = ProductionStatusEnum.restarted;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

            private void ChangeStatusToStarted()
        {
            if (ProductionStatus == ProductionStatusEnum.notStarted)
            {
                ProductionStatus = ProductionStatusEnum.started;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }



        #endregion

    }
}
