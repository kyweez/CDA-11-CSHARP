using PersonClassLibrary.PersonExceptions;
using System;
using System.Text.RegularExpressions;

namespace PersonClassLibrary
{
    public class Person
    {
        #region Constants
        private const string REGEX_NAME = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";
        #endregion

        #region Attributes
        private string lastName;
        private string firstName;
        private readonly DateTime dateOfBirth;
        private SexType sex;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new person object
        /// </summary>
        /// <param name="_lastName">string</param>
        /// <param name="_firstName">string</param>
        /// <param name="_dateOfBirth">string</param>
        /// <param name="_sex">SexType</param>
        /// <exception cref="ArgumentNullException">Input or pattern is null</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred</exception>
        /// <exception cref="BadNameInputFormatException">Input names don't fit to the given regex</exception>
        /// <exception cref="BadDateStringFormatException">The input string doesn't have a good format</exception>
        /// <exception cref="InvalidDateOfBirthException">The input date of birth is not valid</exception>
        public Person(string _lastName, string _firstName, string _dateOfBirth, SexType _sex)
        {
            try
            {
                if (!Regex.IsMatch(_lastName, REGEX_NAME) || Regex.IsMatch(_firstName, REGEX_NAME))
                    throw new BadNameInputFormatException();
                if (!DateTime.TryParse(_dateOfBirth, out DateTime result))
                    throw new BadDateStringFormatException();
                else if (result > DateTime.Now || result.Year < 1900)
                    throw new InvalidDateOfBirthException();
                lastName = _lastName;
                firstName = _firstName;
                dateOfBirth = result;
                sex = _sex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}