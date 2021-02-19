using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.API.Domain.Repositories.Interfaces;
using Calculator.API.Domain.Models;
using Calculator.API.DAL;
using Microsoft.EntityFrameworkCore;

namespace Calculator.API.Domain.Repositories
{
    public class AccessLogRepository : IRepository<AccessLog>
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public AccessLogRepository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        public async Task<List<AccessLog>> Get()
        {
            return await _applicationDBContext.Set<AccessLog>().ToListAsync();
        }

        public async Task<AccessLog> Add(AccessLog item)
        {
            _applicationDBContext.Set<AccessLog>().Add(item);
            await _applicationDBContext.SaveChangesAsync();
            return item;
        }
    }
}
