using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TOOLS
{
    public static class CheckData
    {
        private const string regexName = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";
        private const string regexZipCode = @"^(?:[0-8][0-9]|9[0-8])[0-9]{3}$";

        /// <summary>
        ///     Checks if the input name match to the name regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidName(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexName);
        }

        /// <summary>
        ///     Checks if the input date is a valid date
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidDate(string _valueToCheck)
        {
            bool dateTest;
            DateTime result;

            dateTest = DateTime.TryParseExact(_valueToCheck, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out result);
            
            return (dateTest && result > DateTime.Now);
        }

        /// <summary>
        ///     Checks if the input amount is a valid double number
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidAmount(string _valueToCheck)
        {
            return double.TryParse(_valueToCheck, out double number) && number > 0;
        }

        /// <summary>
        ///     Checks if the input zipcode match to the zipcode regular expression (v1)
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidZipCode(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexZipCode);
        }

        /// <summary>
        ///     Checks if all fields are filled and set the errorProvider (v2)
        /// </summary>
        /// <param name="_allFields"></param>
        /// <returns>bool</returns>
        public static bool FieldsAreFilled(List<TextBox> _allFields, ErrorProvider _errorProvider)
        {
            bool result;

            result = true;
            foreach (TextBox field in _allFields)
            {
                if (field.Text.Length == 0)
                {
                    result = false;
                    _errorProvider.SetError(field, "This field is empty");
                }
            }
            return result;
        }

        /// <summary>
        ///     Checks if all fields are filled
        /// </summary>
        /// <param name="_allFields"></param>
        /// <returns>bool</returns>
        public static bool FieldsAreFilled(List<TextBox> _allFields)
        {
            foreach (TextBox field in _allFields)
            {
                if (field.Text.Length == 0)
                    return false;
            }
            return true;
        }
    }
}