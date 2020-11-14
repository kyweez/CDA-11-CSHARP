using System;

namespace ClassLibraryLoan_v1.LoanExceptions
{
    public class InvalidRepaymentDurationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid repayment duration"
        /// </summary>
        public InvalidRepaymentDurationException() : base("Invalid repayment duration")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "LoanClassLibrary.LoanExceptions.cs";
        }
    }
}