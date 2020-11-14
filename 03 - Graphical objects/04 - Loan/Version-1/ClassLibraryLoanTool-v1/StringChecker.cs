using System;
using System.Text.RegularExpressions;

namespace ClassLibraryLoanTool_v1
{
    #region ############### METHODS ###############
    public static class StringChecker
    {
        /// <summary>
        /// This method checks whether the given string is a valid amount or not.
        /// </summary>
        /// <param name="_amount">string</param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException">If the string given as an argument is null</exception>
        public static bool IsValidAmount(string _amount)
        {
            try
            {
                if (_amount == "")
                    return true;
                if (!float.TryParse(_amount, out float result))
                    return false;
                if (!Regex.IsMatch(_amount, @"^([1-9]{1})[0-9]{0,8}([\.\,]{1}?[0-9]{1,2})?$"))
                    return false;
                else if (result < 1)
                    return false;
                else
                    return true;
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("IsValidAmount : The argument can't be null", e);
            }
        }

        /// <summary>
        /// This method checks whether the given string is a valid name or not.
        /// </summary>
        /// <param name="_name">string</param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException">If the string given as an argument is null</exception>
        public static bool IsValidName(string _name)
        {
            if (_name == "")
                return true;
            try
            {
                return Regex.IsMatch(_name, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$");
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("IsValidName : The argument can't be null", e);
            }
        }
    }
    #endregion
}