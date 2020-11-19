using System;

namespace ClassLibraryTemperature_v2.Exceptions
{
    public class ImpossibleTemperatureException : Exception
    {
        public ImpossibleTemperatureException() : base()
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureException(string message) : base(message)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureException(string message, Exception innerException) : base(message, innerException)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }
    }
}