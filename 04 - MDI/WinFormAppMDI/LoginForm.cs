using ClassLibraryLogin;
using System;
using System.Windows.Forms;

namespace WinFormAppMDI
{
    public partial class LoginForm : Form
    {
        #region ############### PROPERTY ###############
        public Login CurrentLogin
        {
            get;
            private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public LoginForm(Login _login)
        {
            InitializeComponent();
            CurrentLogin = _login;
        }

        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// This method makes the current form unmovable
        /// </summary>
        /// <param name="m">Message</param>
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// This method tries to connect with the login and password textboxes information given by user
        /// If the authentication failed, inform and reset the form.
        /// Else, inform user and close the form
        /// </summary>
        private void TryToConnect()
        {
            CurrentLogin.ConnectionAttempt(textBoxLogin.Text, textBoxPassword.Text);
            if (!CurrentLogin.IsValidConnection)
            {
                MessageBox.Show("Authentication failure, try again !", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.ResetText();
                textBoxPassword.ResetText();
                ActiveControl = textBoxLogin;
            }
            else
            {
                MessageBox.Show("Authentication success, welcome on board !", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        #endregion

        #region ############### EVENTS ###############
        /// <summary>
        /// This event is triggered when a textbox content changes.
        /// Reset the linked erroprovider and enable/disable the OK button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if ((TextBox)sender == textBoxLogin)
                errorProviderLogin.Clear();
            if ((TextBox)sender == textBoxPassword)
                errorProviderPassword.Clear();
            if (textBoxLogin.Text.Length == 0 || textBoxPassword.Text.Length == 0)
                buttonValidate.Enabled = false;
            else
                buttonValidate.Enabled = true;
        }

        /// <summary>
        /// This event is triggered when the OK button is clicked.
        /// Try to connect with the login and password textboxes information given by user
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            TryToConnect();
        }

        /// <summary>
        /// This event is triggered when a key is pressed.
        /// If the key is return, it tries to connect with the login and password textboxes information given by user
        /// If one of them is empty, it doesn't trigger the connection but it displays erroProviders
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">KeyPressEventArgs</param
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBoxLogin.Text.Length == 0)
                    errorProviderLogin.SetError(textBoxLogin, "Can't be empty !");
                if (textBoxPassword.Text.Length == 0)
                    errorProviderPassword.SetError(textBoxPassword, "Can't be empty !");
                if (textBoxLogin.Text.Length != 0 && textBoxPassword.Text.Length != 0)
                    TryToConnect();
            }
        }
    }
    #endregion
}