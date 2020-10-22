using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                countries.OrderBy(item => item.Key);
            }
        }

        /***************************** PROPERTIES ****************************/
        /// <summary>
        /// Countries getter
        /// </summary>
        public Dictionary<string, bool> Countries
        {
            get => countries;
        }

        /****************************** METHODS ******************************/
        
        /// <summary>
        /// Sets every value of the dictionnary items to false or true 
        /// </summary>
        /// <param name="_value">bool</param>
        public void SetBoolAll(bool _value)
        {
            foreach (string key in countries.Keys.ToList())
                countries[key] = _value;
        }

        /// <summary>
        /// Sets a value to true or false for the corresponding Key.
        /// </summary>
        /// <param name="_key">string</param>
        /// <param name="_value">bool</param>
        public void SetBoolOfDictionnaryItem(string _key, bool _value)
        {
            if (_key == null)
                return;
            try
            {
                countries[_key] = _value;
            }
            catch
            {
                throw (new ArgumentException());
            }
        }

        /// <summary>
        /// Checks if the input string is already in the list. If it's unique, returns true.
        /// </summary>
        /// <param name="_country">string</param>
        /// <returns>bool</returns>
        private bool IsUniqueCountry(string _country)
        {
            if (countries.Keys.ToList().FindIndex(item => item == _country) == -1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks if the input string is a valid country name.
        /// </summary>
        /// <param name="_country">string</param>
        /// <returns>bool</returns>
        private bool IsValidCountryName(string _country)
        {
            if (_country == null)
                return false;
            if (_country.Length > 30)
                return false;
            if (!Regex.IsMatch(_country, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$"))
                return false;
            return true;
        }

        /// <summary>
        /// Add a country to the list and set the default value to false.
        /// If the country can't be added, returns false
        /// </summary>
        /// <param name="_country">string</param>
        /// <returns>bool</returns>
        public bool AddCountry(string _country)
        {
            if (!IsValidCountryName(_country))
                return false;
            if (!IsUniqueCountry(_country))
                return false;
            countries.Add(_country, false);
            countries.OrderBy(item => item.Key);
            return true;
        }

        /// <summary>
        /// Redifine AddCountry: Add a country to the list and set the default value to value.
        /// If the country can't be added, returns false an an error message.
        /// </summary>
        /// <param name="_country">string</param>
        /// <returns>bool</returns>
        public bool AddCountry(string _country, bool _value, out string _error)
        {
            if (!IsValidCountryName(_country))
            {
                _error = "Invalid format";
                return false;
            }
            if (!IsUniqueCountry(_country))
            {
                _error = "This country already exists";
                return false;
            }
            countries.Add(_country, _value);
            countries.OrderBy(item => item.Key);
            _error = null;
            return true;
        }
    }
}