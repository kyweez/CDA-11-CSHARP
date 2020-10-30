using PersonClassLibrary.PersonExceptions;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PersonClassLibrary
{
    public class Person
    {
        #region Constants
        private const string REGEX_NAME = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";
        #endregion

        #region Properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SexType Sex { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Person constructor
        /// </summary>
        /// <param name="_lastName">string</param>
        /// <param name="_firstName">string</param>
        /// <param name="_dateOfBirth">string</param>
        /// <param name="_sex">SexType</param>
        /// <exception cref="ArgumentNullException">Input or pattern is null</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred</exception>
        /// <exception cref="BadNameInputFormatException">Input names don't fit to the given regex</exception>
        /// <exception cref="InvalidDateOfBirthException">The input date of birth is not valid</exception>
        public Person(string _lastName, string _firstName, DateTime _dateOfBirth, SexType _sex)
        {
            try
            {
                //if (!Regex.IsMatch(_lastName, REGEX_NAME) || Regex.IsMatch(_firstName, REGEX_NAME))
                //    throw new BadNameInputFormatException();
                if (_dateOfBirth > DateTime.Now || _dateOfBirth.Year < 1900)
                    throw new InvalidDateOfBirthException();
                LastName = new CultureInfo(CultureInfo.CurrentCulture.Name).TextInfo.ToTitleCase(_lastName);
                FirstName = new CultureInfo(CultureInfo.CurrentCulture.Name).TextInfo.ToTitleCase(_firstName);
                DateOfBirth = _dateOfBirth;
                Sex = _sex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}