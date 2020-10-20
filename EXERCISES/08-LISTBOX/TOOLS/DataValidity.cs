using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TOOLS
{
    public static class DataValidity
    {
        public static bool IsValidString(string _checkedString, string _regex)
        {
            return (Regex.IsMatch(_checkedString, _regex));
        }
    }
}
