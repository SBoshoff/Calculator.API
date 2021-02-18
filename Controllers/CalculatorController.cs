using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Services.Interfaces;

namespace Calculator.API.Controllers
{
    [Route("/api/[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;    
        }

        [HttpGet]
        public async Task<string> calculate(string expression)
        {
            string result = await _calculatorService.calculate(expression);
            return result;
        }
    }
}