using PersonClassLibrary.PersonExceptions;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PersonClassLibrary
{
    public class Person
    {
        #region ********** CONSTANTS **********
        private const string REGEX_NAME = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";
        #endregion

        #region ********** PROPERTIES **********
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SexType Sex { get; set; }
        #endregion

        #region ********** CONSTRUCTORS **********
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

        #region ********** METHODS **********
        /// <summary>
        /// Copy the given Person state into the the current object state
        /// </summary>
        /// <param name="_person">Person</param>
        /// <exception cref="ArgumentNullException">Input is null</exception>
        public void Copy(Person _person)
        {
            if (_person == null)
                throw new ArgumentNullException();
            LastName = _person.LastName;
            FirstName = _person.FirstName;
            DateOfBirth = _person.DateOfBirth;
            Sex = _person.Sex;
        }
        #endregion
    }
}