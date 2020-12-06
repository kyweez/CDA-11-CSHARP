using System;
using System.Diagnostics;
using System.Threading;

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

        private Stopwatch ProductionTimer
        {
            get;
            set;
        }

        public double NumberOfValidCratesToProduce
        {
            get;
            private set;
        }

        public double CurrentNumberOfFaultyCrates
        {
            get;
            private set;
        }

        public double CurrentNumberOfValidCrates
        {
            get;
            private set;
        }

        public double HourlyOutputOfCrates
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
        public CrateProduction(string _productionName, double _numberOfValidCratesToProduce, double _hourlyOutputOfCrates)
        {
            ProductionStatus = 0;
            ProductionName = _productionName;
            NumberOfValidCratesToProduce = _numberOfValidCratesToProduce;
            HourlyOutputOfCrates = _hourlyOutputOfCrates;
            ProductionStatusChange += CrateProduction_ProductionStatusChange;
            ProductionTimer = new Stopwatch();
        }
        #endregion

        #region ############### EVENTS ###############
        public delegate void DelegateProduction(CrateProduction sender); //A voir si on laisse le sender
        public event DelegateProduction ProductionStatusChange;
        
        public delegate void DelegateCreatedCrate(double crateNumber);
        public event DelegateCreatedCrate FaultyCrateAdded;
        public event DelegateCreatedCrate ValidCrateAdded;

        private void CrateProduction_ProductionStatusChange(CrateProduction sender)
        {
            if (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                ProduceThread = new Thread(new ThreadStart(RunProduction));
                ProduceThread.Start();
                ProductionTimer.Start();
            }
            else if (ProduceThread != null)
            {
                ProductionTimer.Stop();
                ProduceThread.Abort();
            }
        }
        #endregion

        #region ############### METHODS ###############
        public double CalculateFaultyRate()
        {
            lock (this)
            {
                return CalculateFaultyRate() / ProductionTimer.ElapsedMilliseconds * 3600000;
            }
        }

        public double CalculateHourlyFaultyRate()
        {
            lock (this)
            {
                return Math.Round(CurrentNumberOfFaultyCrates / (CurrentNumberOfFaultyCrates + CurrentNumberOfValidCrates), 4);
            }
        }

        private void CreateCrate()
        {
            Random random = new Random();
            double randomNumber = random.Next(0, 100);
            if (!ProductionIsFinished())
            {
                if (randomNumber > 2 && CurrentNumberOfValidCrates < NumberOfValidCratesToProduce)
                {
                    ValidCrateAdded(++CurrentNumberOfValidCrates);
                    if (ProductionIsFinished())
                        ChangeStatusToFinished();
                }
                else
                    FaultyCrateAdded(++CurrentNumberOfFaultyCrates);
            }
        }

        private bool ProductionIsFinished()
        {
            return (CurrentNumberOfValidCrates == NumberOfValidCratesToProduce);
        }

        private void RunProduction()
        {
            int timeBetweenCrateCreation = (3600 * 60 * 60) / (int)HourlyOutputOfCrates;

            while (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                Thread.Sleep(timeBetweenCrateCreation);
                CreateCrate();
            }
        }
        #endregion

        #region ############### STATUS CHANGE METHODS ###############
        public void ChangeStatusToFinished()
        {
            if (ProductionStatus != ProductionStatusEnum.notStarted)
            {
                ProductionStatus = ProductionStatusEnum.finished;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

        public void ChangeStatusToPaused()
        {
            if (ProductionStatus == ProductionStatusEnum.started || ProductionStatus == ProductionStatusEnum.restarted)
            {
                ProductionStatus = ProductionStatusEnum.paused;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

        public void ChangeStatusToRestarted()
        {
            if (ProductionStatus == ProductionStatusEnum.paused)
            {
                ProductionStatus = ProductionStatusEnum.restarted;
                ProductionStatusChange(this);
            }
            // else
            // Create an exception
        }

        public void ChangeStatusToStarted()
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