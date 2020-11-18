using ClassLibraryTemperature.Exceptions;
using System;

namespace ClassLibraryTemperature
{
    public class Temperature
    {
        private const float ABSOLUTE_ZERO = -273.15f;
        private const float PLANCK_TEMPERATURE = 141683196372900000000000000000000f;

        public float TemperatureInCelsius
        {
            get;
            private set;
        }

        public delegate void DelegateTemperature(Temperature sender);
        public event DelegateTemperature FreezingTemperature;
        public event DelegateTemperature FeverTemperature;

        public Temperature(float _temperature)
        {
            if (_temperature < ABSOLUTE_ZERO || _temperature > PLANCK_TEMPERATURE)
                throw new ImpossibleTemperatureException("This temperature doesn't exists");
            TemperatureInCelsius = _temperature;
        }

        public Temperature() : this(1f)
        {
        }

        private void CheckTemperature()
        {
            if (TemperatureInCelsius <= 0f && FreezingTemperature != null)
                FreezingTemperature(this);
            if (TemperatureInCelsius >= 38f && FeverTemperature != null)
                FeverTemperature(this);
        }

        public void IncreaseTemperature(float _temperature)
        {
            if (_temperature <= 0)
                throw new WrongTemperatureArgumentException("You can't increase the temperature with a negative value");
            if (TemperatureInCelsius >= PLANCK_TEMPERATURE)
                throw new ImpossibleTemperatureIncreasingException("The current temperature has already reached the Planck temperature");
            Console.WriteLine($"PLANCK_TEMPERATURE                        : {PLANCK_TEMPERATURE}");
            Console.WriteLine($"TemperatureInCelsius                      : {TemperatureInCelsius}");
            Console.WriteLine($"PLANCK_TEMPERATURE - TemperatureInCelsius : {PLANCK_TEMPERATURE - TemperatureInCelsius}");
            Console.WriteLine($"_temperature                              : {_temperature}");
            if (TemperatureInCelsius >= 0 && PLANCK_TEMPERATURE - TemperatureInCelsius < _temperature)
                throw new ImpossibleTemperatureIncreasingException($"Can't increase this value : {_temperature}. Too high value");
            TemperatureInCelsius += _temperature;
            CheckTemperature();
        }

        public void DecreaseTemperature(float _temperature)
        {
            if (_temperature <= 0)
                throw new WrongTemperatureArgumentException("You can't decrease the temperature with a negative value");
            if (TemperatureInCelsius <= ABSOLUTE_ZERO)
                throw new ImpossibleTemperatureDecreasingException("The current temperature has already reached the absolute zero");
            if (_temperature > PLANCK_TEMPERATURE + Math.Abs(ABSOLUTE_ZERO)|| TemperatureInCelsius - _temperature < ABSOLUTE_ZERO)
                throw new ImpossibleTemperatureDecreasingException($"Can't decrease this value : {_temperature}. Too high value");
            TemperatureInCelsius -= _temperature;
            CheckTemperature();
        }

    }
}
