using System;

namespace ClassLibraryTemperature_v2.Exceptions
{
    public class ImpossibleTemperatureIncreasingException : Exception
    {
        public ImpossibleTemperatureIncreasingException() : base()
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureIncreasingException(string message) : base(message)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }

        public ImpossibleTemperatureIncreasingException(string message, Exception innerException) : base(message, innerException)
        {
            HelpLink = "https://bfy.tw/Pgzo";
            Source = "ClassLibraryTemperature_v2";
        }
    }
}