using System.Collections.Generic;
using System.Threading.Tasks;
using Calculator.API.Domain.Models;

namespace Calculator.API.Domain.Repositories.Interfaces
{
    public interface IAccessLogRepository
    {
        Task saveAuditLog();
    }
}