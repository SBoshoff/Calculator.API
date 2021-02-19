using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Models;

namespace Calculator.API.Domain.Services.Interfaces
{
    public interface IAccessLogService
    {
        /// <summary>
        ///     Calls a repository function to log the ip address and current date in the database.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns> Task </returns>
        Task<AccessLog> logRequest(string ip);
    }
}