using System;

namespace ClassLibraryTemperature_v2.Exceptions
{
    public class WrongTemperatureArgumentException : Exception
    {
        public WrongTemperatureArgumentException() : base()
        {
            HelpLink = "https://docs.microsoft.com/en-us/dotnet/";
            Source = "ClassLibraryTemperature_v2";
        }

        public WrongTemperatureArgumentException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com/en-us/dotnet/";
            Source = "ClassLibraryTemperature_v2";
        }

        public WrongTemperatureArgumentException(string message, Exception innerException) : base(message, innerException)
        {
            HelpLink = "https://docs.microsoft.com/en-us/dotnet/";
            Source = "ClassLibraryTemperature_v2";
        }
    }
}