using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BUSINESS_CLASS_LIBRARY
{
    public class StudentList : IList
    {
        /***************************** ATTRIBUTES ****************************/
        private List<Person> personTab;

        /**************************** CONSTRUCTORS ***************************/
        public StudentList()
        {
            personTab = new List<Person>();
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/

        /// <summary>
        ///     This method creat a new entry in le personTab List
        ///     Return false if the given argument is null or if the entry already exists
        /// </summary>
        /// <param name="_person">Person</param>
        /// <returns>bool</returns>
        public bool Create(Person _person)
        {
            if (_person == null || !IsUniqueFirstName(personTab, _person.FirstName))
                return false;
            personTab.Add(_person);
            return true;
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

        /// <summary>
        ///     IList implementation :
        ///     Get the element at the specified index
        /// </summary>
        /// <param name="index">int </param>
        /// <returns>Leaf</returns>
        public Person this[int index]
        {
            get => personTab.ElementAt(index);
        }

        /// <summary>
        ///     IList implementation :
        ///     Gets the number of elements contained in the System.Collections.ICollection.
        /// </summary>
        /// <returns>int</returns>
        public int Count
        {
            get => personTab.Count;
        }

        /// <summary>
        ///     IList implementation :
        ///     This methods delete all elements in the person table
        /// </summary>
        public void Clear()
        {
            personTab.Clear();
        }


        /************************** UNUSED INTERFACES **************************/
        public bool IsReadOnly => throw new NotImplementedException();
        public bool IsFixedSize => throw new NotImplementedException();
        public object SyncRoot => throw new NotImplementedException();
        public bool IsSynchronized => throw new NotImplementedException();
        object IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Add(object value) => throw new NotImplementedException();
        public bool Contains(object value) => throw new NotImplementedException();
        public int IndexOf(object value) => throw new NotImplementedException();
        public void Insert(int index, object value) => throw new NotImplementedException();
        public void CopyTo(Array array, int index) => throw new NotImplementedException();
        public IEnumerator GetEnumerator() => throw new NotImplementedException();
        public void RemoveAt(int index) => throw new NotImplementedException();
        public void Remove(object value) => throw new NotImplementedException();
    }
}