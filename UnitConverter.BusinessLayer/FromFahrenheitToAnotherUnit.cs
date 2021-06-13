using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using UnitConverter.BusinessLayer.Interfaces;

namespace UnitConverter.BusinessLayer
{
    public class FromFahrenheitToAnotherUnit : IToAnotherUnit
    {
        public double ConvertToOtherUnit(double temperature, Units toUnit)
        {
            switch (toUnit)
            {
                case Units.CELCIUS:
                    return ConvertToCelcius(temperature);
                case Units.KELVIN:
                    return ConvertToKelvin(temperature);
                default:
                    return temperature;
            }
        }

        private double ConvertToKelvin(double temperature)
        {
            return ConvertToCelcius(temperature) + 273.15;
        }

        private double ConvertToCelcius(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }
}
