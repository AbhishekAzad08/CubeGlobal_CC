using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitConverter.BusinessLayer.Enums;
using UnitConverter.BusinessLayer.Interfaces;
using UnitConverter.BusinessLayer.Model;

namespace UnitConverter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitConversionController : ControllerBase
    {
        private readonly Func<Units, IToAnotherUnit> _serviceResolver;
        public UnitConversionController(Func<Units, IToAnotherUnit> serviceResolver)
        {
            _serviceResolver = serviceResolver;
        }

        [HttpPost]
        //[Route("Convert")]
        //[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(int), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(int), StatusCodes.Status404NotFound)]
        //[ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
        public double ConvertToAnotherUnit([FromBody]ConversionRequest request)
        {
            double returnVal = 0d;
            IToAnotherUnit resolvedService = null;

            resolvedService = _serviceResolver((Units)Enum.Parse(typeof(Units), request.fromUnit.ToUpper()));
            returnVal = resolvedService.ConvertToOtherUnit(request.temperature, (Units)Enum.Parse(typeof(Units), request.toUnit.ToUpper()));
            
            return returnVal;
        }

    }
}
