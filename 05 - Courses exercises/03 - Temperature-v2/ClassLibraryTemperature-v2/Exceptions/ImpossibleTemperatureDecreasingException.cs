using System;

namespace ClassLibraryTemperature_v2.Exceptions
{
    public class ImpossibleTemperatureDecreasingException : Exception
    {
        public ImpossibleTemperatureDecreasingException() : base()
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureDecreasingException(string message) : base(message)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureDecreasingException(string message, Exception innerException) : base(message, innerException)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }
    }
}