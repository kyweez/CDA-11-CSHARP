using System;

namespace ClassLibraryPerson
{
    public class Person
    {
        private const byte MAX_AGE = 150;

        #region ############### PROPERTIES ###############
        public string Name
        {
            get;
            private set;
        }

        public byte Age
        {
            get;
            private set;
        }
        #endregion

        public delegate void DelegateAge(string _lifeStage);
        public event DelegateAge SpecificLifeStage;

        #region ############### CONSTRUCTORS ###############
        public Person(string _name, byte _age)
        {
            Name = _name;
            if (_age > MAX_AGE)
                throw new ImpossibleAgeException($"Nobody can be older than {MAX_AGE}");
            Age = _age;
        }

        public Person(string _name) : this(_name, 0)
        {            
        }

        public Person() : this("John Doe")
        {
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// This method add 1 to the current person age (if possible) and send an event in some specific ages
        /// </summary>
        /// <exception cref="ImpossibleAgeException">If age is not possible to reach</exception>
        public void GettingOlder()
        {
            if (Age == Byte.MaxValue || Age == MAX_AGE - 1)
                throw new ImpossibleAgeException($"Nobody can be older than {MAX_AGE}");
            Age++;
            foreach (EnumLifeStage age in Enum.GetValues(typeof(EnumLifeStage)))
            {
                if (Age == Convert.ToByte(age) && SpecificLifeStage != null)
                    SpecificLifeStage(age.GetDescription());
            }
        }
        #endregion
    }
}