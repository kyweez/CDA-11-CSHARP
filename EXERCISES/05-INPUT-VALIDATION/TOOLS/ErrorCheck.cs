using System.Windows.Forms;

namespace TOOLS
{
    public class ErrorCheck
    {
        /// <summary>
        ///     This method trigger the error Probvider and set it to the good value
        ///     It puts the focus on the invalid text box
        /// </summary>
        /// <param name="_textBox"></param>
        /// <param name="_error"></param>
        /// <param name="_errorProvider"></param>
        /// <returns>void</returns>
        private static void TriggerTextBoxError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            _errorProvider.SetError(_textBox, _error);
            _textBox.Focus();
        }

        /// <summary>
        ///     This method returns a boolean by checking if there is an error in the text box "Name"
        ///     If so, call the TriggerTextBoxError method
        /// </summary>
        /// <param name="_textBox">TextBox</param>
        /// <param name="_error">string</param>
        /// <param name="_errorProvider">ErrorProvider</param>
        /// <returns>bool</returns>
        public static bool HasNameError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidName(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        /// <summary>
        ///     This method returns a boolean by checking if there is an error in the text box "Date"
        ///     If so, call the TriggerTextBoxError method
        /// </summary>
        /// <param name="_textBox">TextBox</param>
        /// <param name="_error">string</param>
        /// <param name="_errorProvider">ErrorProvider</param>
        /// <returns>bool</returns>
        public static bool HasDateError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidDate(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        /// <summary>
        ///     This method returns a boolean by checking if there is an error in the text box "Amount"
        ///     If so, call the TriggerTextBoxError method
        /// </summary>
        /// <param name="_textBox">TextBox</param>
        /// <param name="_error">string</param>
        /// <param name="_errorProvider">ErrorProvider</param>
        /// <returns>bool</returns>
        public static bool HasAmountError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidAmount(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }

        /// <summary>
        ///     This method returns a boolean by checking if there is an error in the text box "ZipCode"
        ///     If so, call the TriggerTextBoxError method
        /// </summary>
        /// <param name="_textBox">TextBox</param>
        /// <param name="_error">string</param>
        /// <param name="_errorProvider">ErrorProvider</param>
        /// <returns>bool</returns>
        public static bool HasZipCodeError(TextBox _textBox, string _error, ErrorProvider _errorProvider)
        {
            if (CheckData.IsValidZipCode(_textBox.Text))
                return false;
            TriggerTextBoxError(_textBox, _error, _errorProvider);
            return true;
        }
    }
}