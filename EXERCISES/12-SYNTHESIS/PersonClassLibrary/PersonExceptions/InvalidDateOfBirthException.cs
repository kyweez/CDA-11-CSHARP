using System;

namespace PersonClassLibrary.PersonExceptions
{
    public class InvalidDateOfBirthException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message.
        /// Message : "Invalid date of birth"
        /// </summary>
        public InvalidDateOfBirthException() : base("Invalid date of birth")
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "PersonClassLibrary.Person.cs";
        }
    }
}