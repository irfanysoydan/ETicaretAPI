using ETicaretAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracker = true);

        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracker = true);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracker = true);

        Task<T> GetByIdAsync(string id, bool tracker = true);
    }
}
