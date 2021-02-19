using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.API.Domain.Models.Interfaces;

namespace Calculator.API.Domain.Repositories.Interfaces
{
    public interface IRepository<T> where T : IEntityBase
    {
        Task<List<T>> Get();
        Task<T> Add(T item);
    }
}
