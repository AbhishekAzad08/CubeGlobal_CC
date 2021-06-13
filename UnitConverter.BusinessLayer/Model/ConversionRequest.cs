using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter.BusinessLayer.Model
{
    public class ConversionRequest
    {
        public double temperature { get; set; }
        public string fromUnit { get; set; }
        public string toUnit { get; set; }
    }
}
