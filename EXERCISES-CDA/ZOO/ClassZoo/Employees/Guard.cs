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
                dateOfBirth = DateTime.Compare(value, DateTime.Now) < 1 ? value : DateTime.Now;
            }
        }

        /****************************** METHODS ******************************/


        /// <summary>
        /// Redifining Move method for the Guard. The method returns a boolean and print something on the stdout
        /// </summary>
        /// <returns>bool</returns>
        public bool Move()
        {
            Console.WriteLine("The guard is moving !");
            return true;
        }

        /// <summary>
        /// Redifining Talk method for the Guard. The method returns a void and print something on the stdout
        /// </summary>
        /// <returns>void</returns>
        public void Talk()
        {
            Console.WriteLine("PLEASE ANIMALS, IT MIGHT BE WEIRD, BUT LISTEN TO ME AND RUN FROM THE OLDER TO THE YOUNGER !");
        }

        /// <summary>
        /// Redifining Talk method for the Guard with a parameter. The method returns a void and print something on the stdout
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>void</returns>
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}