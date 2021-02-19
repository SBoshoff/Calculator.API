using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Models;

namespace Calculator.API.Domain.Services.Interfaces
{
    public interface ICalculatorService
    {
        /// <summary>
        ///     Performs the calculation and returns the calculation result as a string.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns> string </returns>
        Task<string> calculate(string expression);
    }
}