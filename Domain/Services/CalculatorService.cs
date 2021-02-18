using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Services.Interfaces;
using System.Web;
using System.Data;

namespace Calculator.API.Domain.Services
{
    public class CalculatorService : ICalculatorService {
        public async Task<string> calculate(string expression)
        {
            if (expression == null) {
                return "N/A";
            }

            return new DataTable().Compute(expression, "").ToString();
        }
    }
}