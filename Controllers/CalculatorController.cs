using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Services.Interfaces;
using Calculator.API.Domain.Repositories.Interfaces;
using Calculator.API.Domain.Models;

namespace Calculator.API.Controllers
{
    [Route("/api/[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;
        private readonly IAccessLogService _accessLogService;

        public CalculatorController(ICalculatorService calculatorService, IAccessLogService accessLogService)
        {
            _calculatorService = calculatorService;    
            _accessLogService = accessLogService;    
        }

        [HttpPost]
        public async Task<string> calculate(string expression)
        {
            string IpAddress = HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            await _accessLogService.logRequest(IpAddress);
            string result = await _calculatorService.calculate(expression);
            return result;
        }
    }
}