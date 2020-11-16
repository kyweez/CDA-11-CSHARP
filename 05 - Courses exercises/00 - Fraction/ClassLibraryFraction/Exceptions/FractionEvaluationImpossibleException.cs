using System;

namespace ClassLibraryFraction.Exceptions
{
    class FractionEvaluationImpossibleException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a fraction can't be reversed
        /// </summary>
        public FractionEvaluationImpossibleException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }

        /// <summary>
        /// Instanciate a new exception when a fraction can't be reversed
        /// </summary>
        /// <param name="message">string</param>
        public FractionEvaluationImpossibleException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }

        /// <summary>
        /// Instanciate a new exception when a fraction can't be reversed
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public FractionEvaluationImpossibleException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }
    }
}