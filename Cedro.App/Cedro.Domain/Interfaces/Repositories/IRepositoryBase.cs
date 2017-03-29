using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cedro.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IQueryable<TEntity> Get();

        TEntity GetById(int id);

     

    }
}
