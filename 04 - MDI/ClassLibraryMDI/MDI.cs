using System;
using System.ComponentModel;
using System.Reflection;

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
        /// <summary>
        /// This method helps the user to find the description of an enum an returns it
        /// </summary>
        /// <returns>string</returns>
        public string GetLastProgramLaunchedDescription()
        {
            FieldInfo fi = LastProgramLaunched.GetType().GetField(LastProgramLaunched.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return LastProgramLaunched.ToString();
        }

        /// <summary>
        /// This method updates the current date
        /// </summary>
        public void UpdateCurrentDateTime()
        {
            CurrentDateTime = DateTime.Now;
        }

        /// <summary>
        /// This method updates the LastProgramLaunched property
        /// </summary>
        /// <param name="_lastProgramLaunched">ProgramNameEnum</param>
        public void UpdateLastProgramLaunched(ProgramNameEnum _lastProgramLaunched)
        {
            LastProgramLaunched = _lastProgramLaunched;
        }
        #endregion
    }
}