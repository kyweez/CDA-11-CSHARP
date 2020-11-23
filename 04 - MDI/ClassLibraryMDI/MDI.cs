using System;

namespace ClassLibraryMDI
{
    public class MDI
    {
        #region ############### PROPERTIES ###############
        public DateTime CurrentDateTime
        {
            get;
            private set;
        }

        public ProgramNameEnum LastProgramLaunched
        {
            get;
            private set;
        }
        #endregion

        #region ############### PROPERTIES ###############
        public MDI()
        {
            CurrentDateTime = DateTime.Now;
            LastProgramLaunched = 0;
        }
        #endregion

        #region ############### METHODS ###############
        public void UpdateCurrentDateTime()
        {
            CurrentDateTime = DateTime.Now;
        }
        #endregion
    }
}