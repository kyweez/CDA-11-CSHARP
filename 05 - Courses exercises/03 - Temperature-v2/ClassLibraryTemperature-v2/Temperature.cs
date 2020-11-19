using ClassLibraryTemperature_v2.Exceptions;
using System;

namespace ClassLibraryTemperature_v2
{
    public class Temperature
    {
        private const float ABSOLUTE_ZERO = -273.15f;
        private const float MAX_TEMPERATURE = 1000000000f;

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
            if (_temperature < ABSOLUTE_ZERO || _temperature > MAX_TEMPERATURE)
                throw new ImpossibleTemperatureException("This temperature doesn't exists in classical physic");
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
            CheckTemperature();
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
            CheckTemperature();
        }

    }
}
