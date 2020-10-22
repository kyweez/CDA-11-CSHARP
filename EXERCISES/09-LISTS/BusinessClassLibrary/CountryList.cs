using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClassLibrary
{
    public class CountryList
    {
        /***************************** ATTRIBUTES ****************************/
        private Dictionary<string, bool> countries;

        /**************************** CONSTRUCTORS ***************************/
        /// <summary>
        /// Constructor 1
        /// </summary>
        public CountryList()
        {
            countries = new Dictionary<string, bool>();
        }

        /// <summary>
        /// Constructor 2 (with parameter)
        /// </summary>
        /// <param name="_countryList">List\<string\></param>
        public CountryList(List<string> _countryList)
        {
            countries = new Dictionary<string, bool>();

            if (_countryList != null)
            {
                foreach (string country in _countryList)
                    countries.Add(country, false);
            }
        }

        /***************************** PROPERTIES ****************************/
        /// <summary>
        /// countries getter
        /// </summary>
        public Dictionary<string, bool> Countries
        {
            get => countries;
            set => countries = value;
        }

        /****************************** METHODS ******************************/
        public void SetBoolAll(bool _bool)
        {
            foreach (string key in countries.Keys.ToList())
                countries[key] = _bool;
        }
    }
}
