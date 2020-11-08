using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanClassLibrary.LoanExceptions
{
    public class InvalidRepaymentPeriodicityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid repayment periodicity"
        /// </summary>
        public InvalidRepaymentPeriodicityException() : base("Invalid repayment periodicity")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "LoanClassLibrary.LoanExceptions.cs";
        }
    }
}
