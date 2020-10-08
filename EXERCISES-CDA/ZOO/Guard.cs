using System;

namespace ZOO
{
    public class Guard:IMovable, ITalkable
    {
        /***************************** ATTRIBUTES ****************************/
        private string lastName;
        private string firstName;
        private DateTime dateOfBirth;

        /**************************** CONSTRUCTORS ***************************/
        public Guard()
        {
            LastName = "";
            FirstName = "";
            DateOfBirth = DateTime.Now;
        }
        public Guard(string _lastName, string _firstName, DateTime _dateOfBirth)
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

        public bool Move()
        {
            Console.WriteLine("The guard is moving");
            return true;
        }

        public void Talk()
        {
            Console.WriteLine("The guard is talking");
        }
    }
}