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

        private void textBoxInput_TextChanged(object sender, EventArgs e)
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

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            ValidInput?.Invoke(textBoxInput.Text);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CancelInput?.Invoke();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}