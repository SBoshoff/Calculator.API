using System.Threading.Tasks;
using Calculator.API.Domain.Services.Interfaces;
using Calculator.API.Domain.Models;
using Calculator.API.Domain.Repositories.Interfaces;
using System;

namespace Calculator.API.Domain.Services
{
    public class AccessLogService : IAccessLogService {

        IRepository<AccessLog> _accessLogRepository;
        public AccessLogService(IRepository<AccessLog> accessLogRepository)
        {
            _accessLogRepository = accessLogRepository;
        }
        public async Task<AccessLog> logRequest(string ip)
        {
            AccessLog al = new AccessLog();
            al.IpAddress = ip;
            al.dateOfAccess = DateTime.Now;

            await _accessLogRepository.Add(al);

            return al;
        }
    }
}