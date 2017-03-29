using System.Linq;

namespace Cedro.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IQueryable<TEntity> Get();

        TEntity GetById(int id);

    }
}
