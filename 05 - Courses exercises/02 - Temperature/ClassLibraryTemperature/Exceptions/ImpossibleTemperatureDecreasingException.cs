using System;

namespace ClassLibraryTemperature.Exceptions
{
    public class ImpossibleTemperatureDecreasingException : Exception
    {
        public ImpossibleTemperatureDecreasingException() : base()
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature";
        }

        public ImpossibleTemperatureDecreasingException(string message) : base(message)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature";
        }

        public ImpossibleTemperatureDecreasingException(string message, Exception innerException) : base(message, innerException)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature";
        }
    }
}