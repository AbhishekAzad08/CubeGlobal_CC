using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;
using Xunit;

namespace UnitConverter.BusinessLayer.Tests
{
    public class FromCelciusToAnotherUnitTests
    {
        /// <summary>
        /// Test conversion to Kelvin
        /// </summary>
        [Fact]
        public void ConvertToKelvin_Test_SUCCESS()
        {
            var converter = new FromCelciustoAnotherUnit();
            double kelvinTemp=converter.ConvertToOtherUnit(0,Units.KELVIN);
            Assert.Equal(273.15, kelvinTemp);            
        }

        /// <summary>
        /// Test conversion to Fahrenheit
        /// </summary>
        [Fact]
        public void ConvertToFahrenheit_Test_SUCCESS()
        {
            var converter = new FromCelciustoAnotherUnit();
            double fahrenheitTemp = converter.ConvertToOtherUnit(0, Units.FAHRENHEIT);
            Assert.Equal(32, fahrenheitTemp);
        }
    }
}
