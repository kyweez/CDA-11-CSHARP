using System.Text.RegularExpressions;

namespace ClassLibraryStudent
{
    public class Person
    {
        private const string regexFirstName = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";

        #region ############### FIELDS ###############
        private string firstName;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public Person(string _firstName)
        {
            firstName = Regex.IsMatch(_firstName, regexFirstName) ? _firstName : "Undefined";
        }
        #endregion

        #region ############### PROPERTIES ###############
        public string FirstName
        {
            get => firstName;
        }
        #endregion
    }
}