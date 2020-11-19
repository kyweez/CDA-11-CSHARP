using ClassLibraryTemperature_v2.Exceptions;
using System;
using System.Collections.Generic;

namespace ClassLibraryTemperature_v2
{
    public class Temperature
    {
        #region ############### CONSTANTS ###############
        private const float ABSOLUTE_ZERO = -273.15f;
        private const float MAX_TEMPERATURE = 1000000000f;
        #endregion

        #region ############### PROPERTIES ###############
        public float TemperatureInCelsius
        {
            get;
            private set;
        }

        public Dictionary<float, string> TemperatureDictionary
        {
            get;
            private set;
        }
        #endregion

        #region ############### EVENTS ###############
        public delegate void DelegateTemperature(KeyValuePair<float, string> keyValuePair);
        public event DelegateTemperature SpecificTemperatureEvent;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public Temperature(float _temperature, Dictionary<float, string> _temperatureDictionnary)
        {
            if (_temperature < ABSOLUTE_ZERO || _temperature > MAX_TEMPERATURE)
                throw new ImpossibleTemperatureException("This temperature doesn't exists in classical physic");
            if (_temperatureDictionnary == null)
                throw new ArgumentNullException("The temperature dictionnary is null");
            TemperatureInCelsius = _temperature;
            TemperatureDictionary = _temperatureDictionnary;
        }
        #endregion

        #region ############### METHODS ###############
        public void IncreaseTemperature(float _temperature)
        {
            float delta;
            if (TemperatureInCelsius < 0f)
                delta = MAX_TEMPERATURE + Math.Abs(TemperatureInCelsius);
            else
                delta = MAX_TEMPERATURE - TemperatureInCelsius;

            if (_temperature <= 0)
                throw new WrongTemperatureArgumentException("You can't increase the temperature with a negative value");
            if (TemperatureInCelsius >= MAX_TEMPERATURE)
                throw new ImpossibleTemperatureIncreasingException("The current temperature has already reached the Max temperature");
            if (delta < _temperature)
                throw new ImpossibleTemperatureIncreasingException($"Can't increase this value : {_temperature}. Too high value");
            TemperatureInCelsius += _temperature;
            if (TemperatureDictionary.ContainsKey(TemperatureInCelsius) && SpecificTemperatureEvent != null)
                SpecificTemperatureEvent(new KeyValuePair<float, string>(TemperatureInCelsius, TemperatureDictionary[TemperatureInCelsius]));
        }

        public void DecreaseTemperature(float _temperature)
        {
            float delta;
            if (TemperatureInCelsius < 0f)
                delta = Math.Abs(ABSOLUTE_ZERO) - Math.Abs(TemperatureInCelsius);
            else
                delta = Math.Abs(ABSOLUTE_ZERO) + TemperatureInCelsius;

            if (_temperature <= 0)
                throw new WrongTemperatureArgumentException("You can't decrease the temperature with a negative value");
            if (TemperatureInCelsius <= ABSOLUTE_ZERO)
                throw new ImpossibleTemperatureDecreasingException("The current temperature has already reached the absolute zero");
            if (delta < _temperature)
                throw new ImpossibleTemperatureDecreasingException($"Can't decrease this value : {_temperature}. Too high value");
            TemperatureInCelsius -= _temperature;
            if (TemperatureDictionary.ContainsKey(TemperatureInCelsius))
                SpecificTemperatureEvent(new KeyValuePair<float, string>(TemperatureInCelsius, TemperatureDictionary[TemperatureInCelsius]));
        }
        #endregion
    }
}