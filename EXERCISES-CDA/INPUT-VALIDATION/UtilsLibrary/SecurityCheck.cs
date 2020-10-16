using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INPUT_VALIDATION;

namespace INPUT_VALIDATION.UtilsLibrary
{
    class SecurityCheck
    {
        // TODO: Gerer les noms composes
        private const string regexName = @"^[a-zA-Z]{1,30}$";
        private const string regexDate = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
        // TODO: Gerer la taille de la mantisse et de l'exposant negatif
        private const string regexAmount = @"^(-?)(0|([1-9][0-9]*))(\\.[0-9]+)?$";
        private const string regexZipCode = @"/^(?:[0-8]\d|9[0-8])\d{3}$/";

        /// <summary>
        /// Checks if the input name match to the name regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool CheckName(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexName);
        }

        /// <summary>
        /// Checks if the input date match to the date regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool CheckDate(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexDate);
        }

        /// <summary>
        /// Checks if the input amount match to the amount regular expression
        /// </summary>
        /// <param name="_valueToCheck">string</param>
        /// <returns>bool</returns>
        public static bool CheckAmount(string _valueToCheck)
        {
            return Regex.IsMatch(_valueToCheck, regexAmount);
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