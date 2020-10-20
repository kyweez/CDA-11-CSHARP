using System.Collections.Generic;

namespace BUSINESS_CLASS_LIBRARY
{
    class StudentList
    {
        /***************************** ATTRIBUTES ****************************/
        private List<Person> personTab;

        /**************************** CONSTRUCTORS ***************************/
        public StudentList()
        {
            personTab = new List<Person>();
        }

        /***************************** PROPERTIES ****************************/
        public List<Person> PersonTab
        {
            get => personTab;
        }

        /****************************** METHODS ******************************/
        /// <summary>
        ///     This method creat a new entry in le personTab List
        ///     Return false if the given argument is null or if the entry already exists
        /// </summary>
        /// <param name="_person">Person</param>
        /// <returns>bool</returns>
        public bool Create(Person _person)
        {
            if (_person == null || IsUniqueFirstName(personTab, _person.FirstName))
                return false;
            personTab.Add(_person);
            return true;
        }

        /// <summary>
        ///     This methods delete all elements in the person table
        /// </summary>
        public void DeleteAll()
        {
            personTab.Clear();
        }

        /// <summary>
        ///     This method check if the input firstame is unique
        /// </summary>
        /// <param name="_personTab">List\<Person\></param>
        /// <param name="_firstName">string</param>
        /// <returns></returns>
        private static bool IsUniqueFirstName(List<Person> _personTab, string _firstName)
        {
            if (_personTab.FindIndex(element => element.FirstName == _firstName) != -1)
                return false;
            return true;
        }
    }
}