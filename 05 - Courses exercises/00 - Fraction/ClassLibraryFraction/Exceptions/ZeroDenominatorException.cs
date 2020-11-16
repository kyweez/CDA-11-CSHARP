using System;

namespace ClassLibraryFraction.Exceptions
{
    public class ZeroDenominatorException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a denominator is equal to 0
        /// </summary>
        public ZeroDenominatorException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }

        /// <summary>
        /// Instanciate a new exception when a denominator is equal to 0
        /// </summary>
        /// <param name="message">string</param>
        public ZeroDenominatorException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }

        /// <summary>
        /// Instanciate a new exception when a denominator is equal to 0
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public ZeroDenominatorException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryFraction";
        }
    }
}