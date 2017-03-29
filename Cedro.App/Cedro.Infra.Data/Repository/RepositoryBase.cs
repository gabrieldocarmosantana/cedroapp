using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Infra.Data.Context;

namespace Cedro.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly CedroContext _ctx;

        public RepositoryBase(CedroContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            _ctx.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Modified;
            _ctx.SaveChanges();

        }

        public void Remove(TEntity obj)
        {
            _ctx.Set<TEntity>().Remove(obj);
            _ctx.SaveChanges();
        }
    

        public IQueryable<TEntity> Get()
        {
            return _ctx.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _ctx.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}