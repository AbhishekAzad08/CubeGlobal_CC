using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using UnitConverter.BusinessLayer.Interfaces;

namespace UnitConverter.BusinessLayer
{
    public class FromKelvinToAnotherUnit : IToAnotherUnit
    {
        public double ConvertToOtherUnit(double temperature, Units toUnit)
        {
            switch (toUnit)
            {
                case Units.CELCIUS:
                    return ConvertToCelcius(temperature);
                case Units.FAHRENHEIT:
                    return ConvertToFahrenheit(temperature);
                default:
                    return temperature;
            }
        }

        private double ConvertToFahrenheit(double temperature)
        {
            var celciusTemperature = ConvertToCelcius(temperature);
            return (9 * celciusTemperature / 5) + 32;
        }

        private double ConvertToCelcius(double temperature)
        {
            return (temperature - 273.15);
        }
    }
}
