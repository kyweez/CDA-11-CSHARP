using System;
using System.Windows.Forms;

namespace WinFormAppMDI
{
    public partial class InputForm : Form
    {
        private int CurrentInstanceNumber
        {
            get;
            set;
        }
        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(int instanceNumber)
        {
            InitializeComponent();
            Text = $"Input number : {instanceNumber}";
            CurrentInstanceNumber = instanceNumber;
        }

        public delegate void DelegateInput(int number, string input);
        public delegate void DelegateCancel();
        public event DelegateInput ValidInput;
        public event DelegateCancel CancelInput;

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
                buttonValidate.Enabled = false;
            else
                buttonValidate.Enabled = true;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            ValidInput?.Invoke(CurrentInstanceNumber, textBoxInput.Text);
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
    }
}