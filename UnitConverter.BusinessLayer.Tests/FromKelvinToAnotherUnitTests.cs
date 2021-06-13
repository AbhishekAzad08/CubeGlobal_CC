using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using Xunit;

namespace UnitConverter.BusinessLayer.Tests
{
    public class FromKelvinToAnotherUnitTests
    {
        /// <summary>
        /// Test conversion to Celcius
        /// </summary>
        [Fact]
        public void ConvertToCelcius_Test_SUCCESS()
        {
            var converter = new FromKelvinToAnotherUnit();
            double celciusTemp = converter.ConvertToOtherUnit(273.15, Units.CELCIUS);
            Assert.Equal(0, celciusTemp);
        }

        /// <summary>
        /// Test conversion to Fahrenheit
        /// </summary>
        [Fact]
        public void ConvertToFahrenheit_Test_SUCCESS()
        {
            var converter = new FromKelvinToAnotherUnit();
            double fahrenheitTemp = converter.ConvertToOtherUnit(273.15, Units.FAHRENHEIT);
            Assert.Equal(32, fahrenheitTemp);
        }
    }
}
