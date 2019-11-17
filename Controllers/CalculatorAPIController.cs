using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RomanNumeralCalculator.Models;
using RomanNumeralCalculator.Business;
using RomanNumeralCalculator.Controllers;

namespace RomanNumeralCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorAPIController : ControllerBase
    {
        public CalculatorServiceInterface _calcSI;
        public ConverterServiceInterface _conSI;

        public CalculatorAPIController(CalculatorServiceInterface calcSI, ConverterServiceInterface conSI)
        {
            _calcSI = calcSI;
            _conSI = conSI;

        }

        // POST: api/CalculatorAPI
        [HttpPost]
        public Calculator Post(Calculator calc)
        {
            // send data to controller
            CalculatorController controller = new CalculatorController(_calcSI, _conSI);
            return controller.getData(calc);         
        }
    }
}
