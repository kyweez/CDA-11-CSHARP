using ClassLibraryTemperature_v2;
using System;

namespace ConsoleAppPhysic
{
    class Program
    {
        static void Main(string[] args)
        {

            Temperature evaporationTemperature = new Temperature(-200f, PhysicDictionaries.EvaporationDictionary());
            Temperature fusionTemperature = new Temperature(-200f, PhysicDictionaries.FusionDictionary());

            evaporationTemperature.SpecificTemperatureEvent += Temperature_SpecificTemperatureEvent;
            fusionTemperature.SpecificTemperatureEvent += Temperature_SpecificTemperatureEvent;

            for (int i = 0; i < 3000; i++)
            {
                evaporationTemperature.IncreaseTemperature(1f);
                fusionTemperature.IncreaseTemperature(1f);
            }
            Console.WriteLine("\n===============================\n");
            for (int i = 0; i < 3000; i++)
            {
                evaporationTemperature.DecreaseTemperature(1f);
                fusionTemperature.DecreaseTemperature(1f);
            }
        }

        private static void Temperature_SpecificTemperatureEvent(System.Collections.Generic.KeyValuePair<float, string> keyValuePair)
        {
            Console.WriteLine(keyValuePair.Value);
        }
    }
}