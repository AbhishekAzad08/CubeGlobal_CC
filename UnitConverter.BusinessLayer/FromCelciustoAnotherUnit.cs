using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using UnitConverter.BusinessLayer.Interfaces;

namespace UnitConverter.BusinessLayer
{
    public class FromCelciustoAnotherUnit : IToAnotherUnit
    {
        public double ConvertToOtherUnit(double temperature, Units toUnit)
        {
            switch (toUnit)
            {
                case Units.FAHRENHEIT:
                    return ConvertToFahrenheit(temperature);
                case Units.KELVIN:
                    return ConvertToKelvin(temperature);
                default:
                    return temperature;
            }
        }

        private double ConvertToKelvin(double temperature)
        {
            return (temperature + 273.15);
        }

        private double ConvertToFahrenheit(double temperature)
        {
            return (9 * temperature / 5) + 32;
        }
    }
}
