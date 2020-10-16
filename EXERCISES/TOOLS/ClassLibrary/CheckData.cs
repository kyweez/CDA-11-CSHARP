using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOOLS.ClassLibrary
{
    public static class CheckData
    {
        private const string regexName = @"^[[:alpha:]]+([\-\' ][[:alpha:]]+)*$";
        private const string regexDate = @"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$";
        private const string regexZipCode = @"/^(?:[0-8]\d|9[0-8])\d{3}$/";

        /// <summary>
        /// Checks if the input name match to the name regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidName(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexName);
        }

        /// <summary>
        /// Checks if the input date is a valid date
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidDate(string _valueToCheck)
        {
            if (!Regex.IsMatch(_valueToCheck, regexDate))
                return false;
            return DateTime.TryParse(_valueToCheck, out DateTime result) && result > DateTime.Now;
        }

        /// <summary>
        /// Checks if the input amount is a valid double number
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool IsValidAmount(string _valueToCheck)
        {
            return double.TryParse(_valueToCheck, out double number) && number > 0;
        }

        /// <summary>
        /// Checks if the input zipcode match to the zipcode regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool CheckZipCode(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexZipCode);
        }

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