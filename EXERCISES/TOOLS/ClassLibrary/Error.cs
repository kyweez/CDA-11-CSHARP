using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOOLS.ClassLibrary
{
    public class ErrorCheck
    {
        private static void TriggerTextBoxError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            _errorProvider.SetError(_textBox, _error);
            _textBox.Focus();
        }

        public static bool HasNameError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidName(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        public static bool HasDateError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidDate(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        public static bool HasAmountError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidAmount(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        public static bool HasZipCodeError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidZipCode(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }
    }
}