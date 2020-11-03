using System;

namespace LoanClassLibrary.LoanExceptions
{
    public class InvalidBorrowedCapitalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid borrowed capital"
        /// </summary>
        public InvalidBorrowedCapitalException() : base("Invalid borrowed capital")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "LoanClassLibrary.LoanExceptions.cs";
        }
    }
}