using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Models;

namespace Calculator.API.Domain.Services.Interfaces
{
    public interface IAccessLogService
    {
        Task<AccessLog> logRequest(string ip);
    }
}