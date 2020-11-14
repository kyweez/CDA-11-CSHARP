using System;

namespace ClassLibraryLoan_v1.LoanExceptions
{
    public class InvalidInterestRateException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid rate interest"
        /// </summary>
        public InvalidInterestRateException() : base("Invalid rate interest")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "LoanClassLibrary.LoanExceptions.cs";
        }
    }
}