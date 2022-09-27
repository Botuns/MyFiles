using BotunsEntities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<T> Register(T entity);

        Task<T> Update(T entity);

        Task<T> Get(Expression<Func<T, bool>> expression);

        Task<IList<T>> GetAll();

        Task<bool> Delete(T entity);

        Task<IList<T>> GetByExpression(Expression<Func<T, bool>> expression);
    }
}
