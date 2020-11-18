using ClassLibraryTemperature;
using ClassLibraryTemperature.Exceptions;
using System;

namespace ConsoleAppGardener
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature patientTemperature;

            try
            {
                patientTemperature = new Temperature(37.0f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(2f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"This temperature can't be instanciated : {e.Message}");
            }
        }

        private static void PatientTemperature_FeverTemperature(Temperature sender)
        {
            Console.WriteLine("The patient is feverish call a doctor !");
        }
    }
}
}