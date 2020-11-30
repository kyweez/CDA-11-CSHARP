using System;
using System.Windows.Forms;

namespace WinFormAppMDI
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public delegate void DelegateInput(string _str);
        public delegate void DelegateCancel();
        public event DelegateInput ValidInput;
        public event DelegateCancel CancelInput;

        /// <summary>
        /// Triggered when the cancel button is clicked. Close the form.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Triggered when the validate button is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            ValidInput?.Invoke(textBoxInput.Text);
            Close();
        }

        /// <summary>
        /// Triggered when the input form is closed
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CancelInput?.Invoke();
        }

        /// <summary>
        /// Triggered when the enter key is pressed.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">KeyPressEventArgs</param>
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBoxInput.Text.Length == 0)
                    errorProviderInput.SetError(textBoxInput, "Can't be empty !");
                else
                {
                    ValidInput?.Invoke(textBoxInput.Text);
                    Close();
                }
            }
        }

        /// <summary>
        /// Triggered when the textBox content changes
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            errorProviderInput.Clear();
            if (textBoxInput.Text.Length == 0)
            {
                errorProviderInput.SetError(textBoxInput, "Can't be empty !");
                buttonValidate.Enabled = false;
            }
            else
                buttonValidate.Enabled = true;
        }
    }
}