using System;

namespace ClassLibraryLogin
{
    public static class Login
    {
        public static bool isValidConnection(string _login, string _password)
        {
            if (_login == null)
                throw new ArgumentNullException("The input login is null");
            if (_password == null)
                throw new ArgumentNullException("The input password is null");
            return (_login == "admin" && _password == "admin");
        }
    }
}