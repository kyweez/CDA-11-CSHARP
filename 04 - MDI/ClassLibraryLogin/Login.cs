using System;

namespace ClassLibraryLogin
{
    public class Login
    {
        #region ############### PROPERTIES ###############
        private string LoginString
        {
            get;
            set;
        }

        private string PasswordString
        {
            get;
            set;
        }

        public bool IsValidLogin
        {
            get;
            private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public Login()
        {
            LoginString = "admin";
            PasswordString = "admin";
            IsValidLogin = false;
        }
        #endregion

        #region ############### METHOD ###############
        /// <summary>
        /// This method compares the login/password pair to the current object properties and set a new value to IsValidLogin property
        /// If IsValidLogin is set to true, send an AuthenticationSuccess event.
        /// </summary>
        /// <param name="_login">string</param>
        /// <param name="_password">string</param>
        /// <exception cref="ArgumentNullException">Triggers if either login or password is null</exception>
        public void ConnectionAttempt(string _login, string _password)
        {
            if (_login == null)
                throw new ArgumentNullException("The input login is null");
            if (_password == null)
                throw new ArgumentNullException("The input password is null");
            IsValidLogin = (_login == LoginString && _password == PasswordString);
        }

        /// <summary>
        /// This method sets the IsValidLogin property to false
        /// </summary>
        public void Disconnect()
        {
            IsValidLogin = false;
        }
        #endregion
    }
}