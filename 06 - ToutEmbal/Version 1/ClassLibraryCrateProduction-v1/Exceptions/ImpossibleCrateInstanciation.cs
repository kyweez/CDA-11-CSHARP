using System;

namespace ClassLibraryCrateProduction_v1.Exceptions
{
    public class ImpossibleCrateInstanciation : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a Crate object can't be instanciated
        /// </summary>
        public ImpossibleCrateInstanciation() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryCrateProduction_v1";
        }

        /// <summary>
        /// Instanciate a new exception when a Crate object can't be instanciated
        /// </summary>
        /// <param name="message">string</param>
        public ImpossibleCrateInstanciation(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryCrateProduction_v1";
        }

        /// <summary>
        /// Instanciate a new exception when a Crate object can't be instanciated
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public ImpossibleCrateInstanciation(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryCrateProduction_v1";
        }
    }
}