using System;

namespace ClassLibraryPerson
{
    public class ImpossibleAgeException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when an age isn't valid
        /// </summary>
        public ImpossibleAgeException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryPerson";
        }

        /// <summary>
        /// Instanciate a new exception when an age isn't valid
        /// </summary>
        /// <param name="message">string</param>
        public ImpossibleAgeException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryPerson";
        }

        /// <summary>
        /// Instanciate a new exception when an age isn't valid
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public ImpossibleAgeException(string message, Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibraryPerson";
        }
    }
}