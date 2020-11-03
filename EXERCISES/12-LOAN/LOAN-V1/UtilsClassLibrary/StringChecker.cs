using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtilsClassLibrary
{
    public static class StringChecker
    {
        /// <summary>
        /// This method checks whether the given string is a valid name or not.
        /// </summary>
        /// <param name="_name">string</param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException">If the string given as an argument is null</exception>
        public static bool IsValidName(string _name)
        {
            try
            {
                return Regex.IsMatch(_name, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$");
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("IsValidName : The argument can't be null", e);
            }
        }

        public static bool IsValidAmount(string _amount)
        {
            if (!float.TryParse(_amount, out float result))
                return false;
            else if (result < 0)
                return false;
            else
                return true;
        }
    }
}