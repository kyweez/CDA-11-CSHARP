using System;

namespace ClassLibraryPerson
{
    public class Person
    {
        private string Name
        {
            get;
            set;
        }

        public byte Age
        {
            get;
            set;
        }

        public delegate void DelegateMajorLegalAge(Person sender);

        public Person(string _name, byte _age)
        {
            Name = _name;
            Age = _age;
        }

        public Person(string _name) : this(_name, 0)
        {            
        }

        public Person() : this("John Doe")
        {
        
        }
    }
}
