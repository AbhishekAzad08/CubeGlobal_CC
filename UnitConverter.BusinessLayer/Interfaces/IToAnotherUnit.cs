using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.BusinessLayer.Enums;

namespace UnitConverter.BusinessLayer.Interfaces
{
    public interface IToAnotherUnit
    {
        double ConvertToOtherUnit(double temperature, Units toUnit);
    }
}
