using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WEDDING_V1
{
    public abstract class Person
    {
        /***************************** ATTRIBUTES ****************************/
        private string lastName;
        private string firstName;
        private DateTime dateOfBirth;

        /**************************** CONSTRUCTORS ***************************/
        public Person(string _lastName, string _firstName, DateTime _dateOfBirth)
        {
            LastName = _lastName;
            FirstName = _firstName;
            DateOfBirth = _dateOfBirth;
        }

        /***************************** PROPERTIES ****************************/
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        /****************************** METHODS ******************************/


    }
}