using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using Xunit;

namespace UnitConverter.BusinessLayer.Tests
{
    public class FromFahrenheitToAnotherUnitTests
    {
        /// <summary>
        /// Test conversion to Kelvin
        /// </summary>
        [Fact]
        public void ConvertToKelvin_Test_SUCCESS()
        {
            var converter = new FromFahrenheitToAnotherUnit();
            double kelvinTemp = converter.ConvertToOtherUnit(32, Units.KELVIN);
            Assert.Equal(273.15, kelvinTemp);
        }

        /// <summary>
        /// Test conversion to Celcius
        /// </summary>
        [Fact]
        public void ConvertToCelcius_Test_SUCCESS()
        {
            var converter = new FromFahrenheitToAnotherUnit();
            double celciusTemp = converter.ConvertToOtherUnit(32, Units.CELCIUS);
            Assert.Equal(0, celciusTemp);
        }
    }
}
