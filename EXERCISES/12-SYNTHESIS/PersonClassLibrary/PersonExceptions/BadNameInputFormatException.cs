using System;

namespace PersonClassLibrary.PersonExceptions
{
    public class BadNameInputFormatException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid name format"
        /// </summary>
        public BadNameInputFormatException() : base("Invalid name format")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "PersonClassLibrary.Person.cs";
        }
    }
}