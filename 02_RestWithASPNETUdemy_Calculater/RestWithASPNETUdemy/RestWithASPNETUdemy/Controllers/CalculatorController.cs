using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        public readonly ILogger<CalculatorController> _logger;
        public  CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sun/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumbe)
        {
            if (Isnumeric(firstNumber) && Isnumeric(secondNumbe))

            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumbe);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        private int ConvertToDecimal(string secondNumbe)
        {
            throw new NotImplementedException();
        }

        private bool Isnumeric(string secondNumbe)
        {
            throw new NotImplementedException();
        }
    }
}
