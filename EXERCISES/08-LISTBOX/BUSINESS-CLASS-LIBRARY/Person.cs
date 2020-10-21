using System.Text.RegularExpressions;

namespace BUSINESS_CLASS_LIBRARY
{
    public class Person
    {
        private const string regexFirstName = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";

        /***************************** ATTRIBUTES ****************************/
        private string firstName;

        /**************************** CONSTRUCTORS ***************************/
        public Person(string _firstName)
        {
            firstName = Regex.IsMatch(_firstName, regexFirstName) ? _firstName : "Undefined";
        }

        /***************************** PROPERTIES ****************************/
        public string FirstName
        {
            get => firstName;
        }

        /****************************** METHODS ******************************/

    }
}
