using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Services.Interfaces;

namespace Calculator.API.Domain.Services
{
    public class CalculatorService : ICalculatorService {
        public async Task<string> calculate(string expression)
        {
            string output;
            string[] values = expression.Split(' ');

            double first = float.Parse(values[0]);
            double second = float.Parse(values[2]);
            string op = values[1];

            double result = 0;

            switch (op)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    if (second != 0)
                    {
                        result = first / second;
                    }
                    else
                    {
                        result = double.NaN;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            if (result != double.NaN)
            {
                output = result.ToString();
            }
            else
            {
                output = "NaN";
            }

            return output;
        }
    }
}