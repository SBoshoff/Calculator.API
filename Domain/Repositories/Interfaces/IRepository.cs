using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.API.Domain.Models.Interfaces;

namespace Calculator.API.Domain.Repositories.Interfaces
{
    public interface IRepository<T> where T : IEntityBase
    {
        /// <summary>
        ///     Gets all entities
        /// </summary>
        /// <returns></returns>
        Task<List<T>> Get();

        /// <summary>
        ///     Adds new entity
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<T> Add(T item);
    }
}
