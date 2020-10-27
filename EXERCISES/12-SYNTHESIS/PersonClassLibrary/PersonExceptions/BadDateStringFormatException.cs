using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassLibrary.PersonExceptions
{
    public class BadDateStringFormatException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid string date format"
        /// </summary>
        public BadDateStringFormatException() : base("Invalid string date format")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "PersonClassLibrary.Person.cs";
        }
    }
}