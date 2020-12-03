using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCrateProduction_v1
{
    public class CrateProduction
    {
        private List<Crate> Crates
        {
            get;
            set;
        }

        public string ProductionName
        {
            get;
            private set;
        }

        public int NumberOfCratesToProduce
        {
            get;
            private set;
        }

        public int HourlyOutput
        {
            get;
            private set;
        }

        public ProductionStatusEnum ProductionStatus
        {
            get;
            private set;
        }

        public int GetCurrentNumberOfCrates()
        {
            throw new NotImplementedException(); 
        }

        public int GetNumberOfFaultyCrates()
        {
            throw new NotImplementedException(); 
        }
        
        public int GetNumberOfValidCrates()
        {
            throw new NotImplementedException(); 
        }

        public int GetNumberOfProducedCrates()
        {
            throw new NotImplementedException();
        }

        public float GetFaultyRate()
        {
            throw new NotImplementedException();
        }

        public float GetHourlyFaultyRate()
        {
            throw new NotImplementedException();
        }
    }
}
